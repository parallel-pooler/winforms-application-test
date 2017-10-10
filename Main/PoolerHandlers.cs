using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Pooler;
using System.Threading;

namespace WinFormsApplicationParallelTest {
	public partial class Main {
		private void _threadExceptionHandler (Pooler.Base pool, ExceptionEventArgs poolThreadExceptionEventArgs) {
			lock (this._taskExceptionCounterLock) {
				this._taskExceptionCounter++;
			}
		}
		private void _taskDoneHandler (Pooler.Base pool, TaskDoneEventArgs poolTaskDoneEventArgs) {
			lock (this._taskDoneCounterLock) {
				this._taskDoneCounter++;
				this._currentlyRunningTasksCounter = poolTaskDoneEventArgs.RunningTasksCount;
			}
		}
		private void _allDoneHandler (Pooler.Base pool, AllDoneEventArgs poolAllDoneEventArgs) {
			this._peakThreadsCounter = poolAllDoneEventArgs.PeakThreadsCount;
			if (poolAllDoneEventArgs.Exceptions.Count != this._taskExceptionCounter) {
				throw new Exception("Exceptions counter is wrong!");
			}
			this._peakThreadsCounter = poolAllDoneEventArgs.PeakThreadsCount;
			this._currentlyRunningTasksCounter = 0;
			this.BackgroundReporting();
			this._reportThread.Abort();
			//poolAllDoneEventArgs.ExecutedTasksCount
			//poolAllDoneEventArgs.NotExecutedTasksCount
		}
	}
}
