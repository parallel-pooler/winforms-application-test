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
		public void StartBtnOnClick (object sender, EventArgs e) {
			// disable all other controls except stop button and slides
			this._enableControls(false);

			// set all report values to start values
			this._taskBeginCounter = 0;
			this._taskDoneCounter = 0;
			this._taskExceptionCounter = 0;
			this._currentlyRunningTasksCounter = 0;
			this._peakThreadsCounter = 0;

			// get integer values from text fields
			this._parseTextInputValues();

			// create new stop watch to measure time
			this._stopWatch = Stopwatch.StartNew();

			// set priority for Winforms thread to highest to be able 
			// to drive the application in large CPU load
			Thread.CurrentThread.Priority = ThreadPriority.Highest;

			// start reporting thread
			this.initAnsStartBackgroundReporting();
			
			// start pooler by combobox type value
			if (this._testType.SelectedItem.ToString() == "Parallel test") {
				this._initAndStartParallel();
			} else {
				this._initAndStartRepeater();
			}
		}
		private void _initAndStartParallel () {
			Parallel pool = new Pooler.Parallel(
				// threads count in pool
				this._getInputPoolStartThreadsCount(), 
				// possible miliseconds pause in job function body
				this._pauseMiliSeconds
			);
			// pool handlers
			pool.AllDone += this._allDoneHandler;
			pool.TaskDone += this._taskDoneHandler;
			pool.TaskException += this._threadExceptionHandler;
			// add tasks to the pool
			bool startThreadimediatellyAfterAdded = !this._heapStartCheckbox.Checked;
			for (int i = 0; i < this._tasksCountValue; i++) {
				pool.Add(
					new Pooler.TaskDelegate(this.TestJob),
					startThreadimediatellyAfterAdded,
					System.Threading.ThreadPriority.Lowest,
					false
				);
			}
			// kick the pool to start
			if (this._heapStartCheckbox.Checked) {
				this._pool.StartProcessing();
			}
			this._pool = pool;
		}
		private void _initAndStartRepeater () {
			Repeater pool = Repeater.CreateNew(
				// threads in pool count
				this._getInputPoolStartThreadsCount(), 
				// single tasks to be executed count
				this._tasksCountValue, 
				// possible miliseconds pause in job function body
				this._pauseMiliSeconds
			);
			// pool handlers
			pool.AllDone += this._allDoneHandler;
			pool.TaskDone += this._taskDoneHandler;
			pool.TaskException += this._threadExceptionHandler;
			// adding the single task into the pool
			pool.Set(
				new Pooler.TaskDelegate(this.TestJob),
				true,
				System.Threading.ThreadPriority.Lowest,
				false
			);
			// lick the pool to start processing
			this._pool = pool;
		}
		private void initAnsStartBackgroundReporting () {
			this._reportThread = new Thread(new ThreadStart(delegate {
				while (true) {
					this.BackgroundReporting();
					Thread.Sleep(500);
				}
			}));
			this._reportThread.Priority = ThreadPriority.Highest;
			this._reportThread.IsBackground = true;
			this._reportThread.Start();
		}
	}
}
