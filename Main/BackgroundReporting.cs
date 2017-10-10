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
	public partial class Main: Form {
		public void BackgroundReporting () {
			int taskBeginCounter;
			int taskDoneCounter;
			int currentlyRunningTasksCounter;
			int taskExceptionCounter;

			lock (this._taskBeginCounterLock) {
				taskBeginCounter = this._taskBeginCounter;
			}
			lock (this._taskDoneCounterLock) {
				taskDoneCounter = this._taskDoneCounter;
				currentlyRunningTasksCounter = this._currentlyRunningTasksCounter;
			}
			lock (this._taskExceptionCounterLock) {
				taskExceptionCounter = this._taskExceptionCounter;
			}

			float threadsStartRatio = ((float)taskBeginCounter) / ((float)this._tasksCountValue);
			if (threadsStartRatio > 1) threadsStartRatio = 1;
			this._threadingStartsProgressBar.Invoke(new ControlUpdate(delegate {
				this._threadingStartsProgressBar.Value = Convert.ToInt32(Math.Round(threadsStartRatio * 1000));
			}));
			this._threadingStartsProgressText.Invoke(new ControlUpdate(delegate {
				this._threadingStartsProgressText.Text = Convert.ToInt32(Math.Round(threadsStartRatio * 100)).ToString() + " %";
			}));

			float threadsEndRatio = ((float)taskDoneCounter) / ((float)this._tasksCountValue);
			if (threadsEndRatio > 1) threadsEndRatio = 1;
			this._threadsDoneProgressBar.Invoke(new ControlUpdate(delegate {
				this._threadsDoneProgressBar.Value = Convert.ToInt32(Math.Round(threadsEndRatio * 1000));
			}));
			this._threadsDoneProgressText.Invoke(new ControlUpdate(delegate {
				this._threadsDoneProgressText.Text = Convert.ToInt32(Math.Round(threadsEndRatio * 100)).ToString() + " %";
			}));

			if (Main.N_EXCEPTIONS > 1) {
				float threadsExeptionsRatio = ((float)taskExceptionCounter) / (((float)this._tasksCountValue) / Main.N_EXCEPTIONS);
				if (threadsExeptionsRatio > 1) threadsExeptionsRatio = 1;
				this._threadsExceptionsProgressBar.Invoke(new ControlUpdate(delegate {
					this._threadsExceptionsProgressBar.Value = Convert.ToInt32(Math.Round(threadsExeptionsRatio * 1000));
				}));
				this._threadsExceptionsProgressText.Invoke(new ControlUpdate(delegate {
					this._threadsExceptionsProgressText.Text = Convert.ToInt32(Math.Round(threadsExeptionsRatio * 100)).ToString() + " %";
				}));
			}

			float threadsCountAgainstMaxRatio = ((float)currentlyRunningTasksCounter) / ((float)this._maxThreadsCount);
			if (threadsCountAgainstMaxRatio > 1) threadsCountAgainstMaxRatio = 1;
			this._currentlyRuningThreadsAgainstMaximumBar.Invoke(new ControlUpdate(delegate {
				this._currentlyRuningThreadsAgainstMaximumBar.Value = Convert.ToInt32(Math.Round(threadsCountAgainstMaxRatio * 1000));
			}));
			this._currentlyRuningThreadsAgainstMaximumText.Invoke(new ControlUpdate(delegate {
				this._currentlyRuningThreadsAgainstMaximumText.Text = Convert.ToInt32(Math.Round(threadsCountAgainstMaxRatio * 100)).ToString() + " %";
			}));

			this._startedThreadsCount.Invoke(new ControlUpdate(delegate {
				this._startedThreadsCount.Text = taskBeginCounter.ToString();
			}));
			this._doneThreadsCount.Invoke(new ControlUpdate(delegate {
				this._doneThreadsCount.Text = taskDoneCounter.ToString();
			}));
			this._exceptionThreadsCount.Invoke(new ControlUpdate(delegate {
				this._exceptionThreadsCount.Text = taskExceptionCounter.ToString();
			}));
			this._currentlyRunningThreads.Invoke(new ControlUpdate(delegate {
				this._currentlyRunningThreads.Text = currentlyRunningTasksCounter.ToString();
			}));
			this._maxThreadsCountPeak.Invoke(new ControlUpdate(delegate {
				this._maxThreadsCountPeak.Text = this._peakThreadsCounter.ToString();
			}));

			TimeSpan spendedTime = new TimeSpan(this._stopWatch.ElapsedTicks);
			string spendedTimeText = String.Format(
				"{0}:{1}:{2}:{3}",
				spendedTime.Hours.ToString().PadLeft(2, '0'),
				spendedTime.Minutes.ToString().PadLeft(2, '0'),
				spendedTime.Seconds.ToString().PadLeft(2, '0'),
				spendedTime.Milliseconds.ToString().PadLeft(2, '0')
			);
			this._spendedTime.Invoke(new ControlUpdate(delegate {
				this._spendedTime.Text = spendedTimeText;
			}));
		}
	}
}
