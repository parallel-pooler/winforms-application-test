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
		private void _enableControls (bool enable = true) {
			this._tasksCount.Enabled = enable;
			this._minThreads.Enabled = enable;
			this._maxThreads.Enabled = enable;
			this._currentlyRunningThreadsMin.Enabled = enable;
			this._currentlyRunningThreadsMax.Enabled = enable;
			this._currentlyRunningThreadsValue.Enabled = enable;
			this._taskPauseMilisecondsMin.Enabled = enable;
			this._taskPauseMilisecondsMax.Enabled = enable;
			this._taskPauseMilisecondsValue.Enabled = enable;
			this._threadingStartsProgressText.Enabled = enable;
			this._threadsDoneProgressText.Enabled = enable;
			this._threadsExceptionsProgressText.Enabled = enable;
			this._currentlyRuningThreadsAgainstMaximumText.Enabled = enable;
			this._startedThreadsCount.Enabled = enable;
			this._doneThreadsCount.Enabled = enable;
			this._exceptionThreadsCount.Enabled = enable;
			this._currentlyRunningThreads.Enabled = enable;
			this._maxThreadsCountPeak.Enabled = enable;
			this._spendedTime.Enabled = enable;
			this._startBtn.Enabled = enable;
			this._stopBtn.Enabled = !enable;
		}
		private void _parseTextInputValues () {
			int tasksCount = Main.TASKS_COUNT_DEFAULT;
			int minThreadsCount = Main.MIN_THREADS_DEFAULT;
			int maxThreadsCount = Main.MAX_THREADS_DEFAULT;
			int.TryParse(this._tasksCount.Text, out tasksCount);
			int.TryParse(this._minThreads.Text, out minThreadsCount);
			int.TryParse(this._maxThreads.Text, out maxThreadsCount);
			this._tasksCountValue = tasksCount;
			this._minThreadsCount = minThreadsCount;
			this._maxThreadsCount = maxThreadsCount;
			this._pauseMiliSeconds = this._taskPauseMilisecondsSlider.Value * 10;
		}
		private int _getInputPoolStartThreadsCount () {
			return Convert.ToInt32(this._minThreadsCount + (
				(((float)this._currentlyRunningThreadsSlider.Value) / 100) * (this._maxThreadsCount - this._minThreadsCount)
			));
		}
	}
}
