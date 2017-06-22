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
using Parallel;
using System.Threading;

namespace WinFormsApplicationTest {
    public partial class Main: Form {
		const int TASKS_COUNT_DEFAULT = 20000;
		const int MIN_THREADS_DEFAULT = 5;
		const int MAX_THREADS_DEFAULT = 30;
		const int TASKS_PAUSE_MILISECONDS_DEFAULT = 10;
		const int N_EXCEPTIONS = 0; // 0 or 1 means no exception, 2 means every second task throw an exception, 3 means every third task etc...

		private Parallel.Pooler _pool = null;

		private System.Diagnostics.Stopwatch _stopWatch;
		private Thread _reportThread = null;

        private int _taskBeginCounter = 0;
        private int _taskDoneCounter = 0;
        private int _taskExceptionCounter = 0;
        private int _currentlyRunningTasksCounter = 0;
        private int _peakThreadsCounter = 0;

		private int _tasksCountValue = Main.TASKS_COUNT_DEFAULT;
		private int _minThreadsCount = Main.MIN_THREADS_DEFAULT;
		private int _maxThreadsCount = Main.MAX_THREADS_DEFAULT;
		private int _pauseMiliSeconds = Main.TASKS_PAUSE_MILISECONDS_DEFAULT;

		private object _taskBeginCounterLock = new object { };
        private object _taskExceptionCounterLock = new object { };
        private object _taskDoneCounterLock = new object { };

		private delegate void ControlUpdate ();

        public Main () {
            this.InitializeComponent();

			this._tasksCount.Text = Main.TASKS_COUNT_DEFAULT.ToString();
			this._minThreads.Text = Main.MIN_THREADS_DEFAULT.ToString();
			this._maxThreads.Text = Main.MAX_THREADS_DEFAULT.ToString();
			this._taskPauseMilisecondsSlider.Value = Main.TASKS_PAUSE_MILISECONDS_DEFAULT;

			this._tasksCount_TextChanged(this._tasksCount, new EventArgs());
			this._minThreads_TextChanged(this._minThreads, new EventArgs());
			this._maxThreads_TextChanged(this._maxThreads, new EventArgs());
			this._currentlyRunningThreadsSlider_Scroll(this._currentlyRunningThreadsSlider, new EventArgs());
		}
        private void _startBtn_Click (object sender, EventArgs e) {
			this._enableControls(false);

			this._taskBeginCounter = 0;
			this._taskDoneCounter = 0;
			this._taskExceptionCounter = 0;
			this._currentlyRunningTasksCounter = 0;
			this._peakThreadsCounter = 0;

			this._stopWatch = Stopwatch.StartNew();

			Thread.CurrentThread.Priority = ThreadPriority.Highest;
			this._reportThread = new Thread(new ThreadStart(delegate {
				while(true) {
					this._report();
					Thread.Sleep(500);
				}
			}));
			this._reportThread.Priority = ThreadPriority.Highest;
			this._reportThread.IsBackground = true;
			this._reportThread.Start();

			Application.ApplicationExit += delegate {
				this._reportThread.Abort();
			};

			this._parseTextInputValues();

			int poolStartThreadsCount = Convert.ToInt32(this._minThreadsCount + (
				(((float)this._currentlyRunningThreadsSlider.Value) / 100) * (this._maxThreadsCount - this._minThreadsCount)
			));

			this._pool = new Parallel.Pooler(poolStartThreadsCount, this._pauseMiliSeconds);
			this._pool.AllDone += this._allDoneHandler;
			this._pool.TaskDone += this._taskDoneHandler;
			this._pool.ThreadException += this._threadExceptionHandler;
			if (this._heapStartCheckbox.Checked) {
				for (int i = 0; i < this._tasksCountValue; i++) {
					this._pool.Add(
						this._taskProvider(i),
						false,
						System.Threading.ThreadPriority.Lowest,
						false
					);
				}
				this._pool.StartProcessing();
			} else {
				for (int i = 0; i < this._tasksCountValue; i++) {
					this._pool.Add(
						this._taskProvider(i),
						true,
						System.Threading.ThreadPriority.Lowest,
						false
					);
				}
			}
		}

		private Pooler.TaskDelegate _taskProvider (int i) {
			return (Parallel.Pooler pool) => {
				lock (this._taskBeginCounterLock) {
					this._taskBeginCounter++;
				}
				// some dummy computation to execute
				long nthPrime;
				nthPrime = this._findPrimeNumber(1000);
				pool.Pause();
				if (Main.N_EXCEPTIONS > 1) { 
					if (i % 3 == Main.N_EXCEPTIONS) {
						throw new Exception($"Exception modulo " + Main.N_EXCEPTIONS);
					}
				}
				nthPrime = this._findPrimeNumber(1000);
			};
		}

		private void _threadExceptionHandler (Pooler pool, PoolerExceptionEventArgs poolThreadExceptionEventArgs) {
			lock (this._taskExceptionCounterLock) {
				this._taskExceptionCounter++;
			}
		}

		private void _taskDoneHandler (Pooler pool, PoolerTaskDoneEventArgs poolTaskDoneEventArgs) {
			lock (this._taskDoneCounterLock) {
				this._taskDoneCounter++;
				this._currentlyRunningTasksCounter = poolTaskDoneEventArgs.RunningThreadsCount;
			}
		}
		private void _allDoneHandler (Pooler pool, PoolerAllDoneEventArgs poolAllDoneEventArgs) {
			this._peakThreadsCounter = poolAllDoneEventArgs.PeakThreadsCount;
			if (poolAllDoneEventArgs.Exceptions.Count != this._taskExceptionCounter) {
				throw new Exception("Exceptions counter is wrong!");
			}
			this._peakThreadsCounter = poolAllDoneEventArgs.PeakThreadsCount;
			this._currentlyRunningTasksCounter = 0;
			this._report();
			this._reportThread.Abort();
			//poolAllDoneEventArgs.ExecutedTasksCount
			//poolAllDoneEventArgs.NotExecutedTasksCount
		}
		private void _report () {
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
			this._spendedTime.Invoke(new ControlUpdate (delegate {
				this._spendedTime.Text = spendedTimeText;
			}));
		}
		private void _stopBtn_Click (object sender, EventArgs e) {
			if (this._pool != null) this._pool.StopProcessing();
			if (this._reportThread != null) this._reportThread.Abort();
			this._taskBeginCounter = 0;
			this._taskDoneCounter = 0;
			this._taskExceptionCounter = 0;
			this._currentlyRunningTasksCounter = 0;
			this._peakThreadsCounter = 0;
			this._report();
			this._enableControls();
			this._reportThread.Abort();
		}
		private void _currentlyRunningThreadsSlider_Scroll (object sender, EventArgs e) {
			this._parseTextInputValues();
			int value = Convert.ToInt32(Math.Round(
				this._minThreadsCount + (
					((float)this._currentlyRunningThreadsSlider.Value / 100) * (this._maxThreadsCount - this._minThreadsCount)
				)
			));
			this._currentlyRunningThreadsValue.Text = value.ToString();
			if (this._pool == null) return;
			this._pool.SetMaxRunningTasks(value, this._heapIncreaseForRunningThreadsCount.Checked);
		}
		private void _taskPauseMilisecondsSlider_Scroll (object sender, EventArgs e) {
			this._taskPauseMilisecondsValue.Text = (this._taskPauseMilisecondsSlider.Value * 10).ToString();
			if (this._pool == null) return;
			this._pool.SetPauseMiliseconds(this._taskPauseMilisecondsSlider.Value * 10);
		}
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
		private void _tasksCount_TextChanged (object sender, EventArgs e) {
			Regex r = new Regex(@"^\d*$");
			if (!r.IsMatch(this._tasksCount.Text)) this._tasksCount.Text = Main.TASKS_COUNT_DEFAULT.ToString();
			this._parseTextInputValues();
			if (this._tasksCountValue < 1) this._tasksCount.Text = "1";
		}
		private void _minThreads_TextChanged (object sender, EventArgs e) {
			Regex r = new Regex(@"^\d*$");
			if (!r.IsMatch(this._minThreads.Text)) this._minThreads.Text = Main.MIN_THREADS_DEFAULT.ToString();
			this._currentlyRunningThreadsMin.Text = this._minThreads.Text;
			this._parseTextInputValues();
			if (this._minThreadsCount > this._maxThreadsCount) {
				this._minThreadsCount = this._maxThreadsCount;
				this._minThreads.Text = this._minThreadsCount.ToString();
			}
			this._currentlyRunningThreadsValue.Text = Math.Round(
				this._minThreadsCount + (
					((float)this._currentlyRunningThreadsSlider.Value / 100) * (this._maxThreadsCount - this._minThreadsCount)
				)
			).ToString();
		}
		private void _maxThreads_TextChanged (object sender, EventArgs e) {
			Regex r = new Regex(@"^\d*$");
			if (!r.IsMatch(this._maxThreads.Text)) this._maxThreads.Text = Main.MAX_THREADS_DEFAULT.ToString();
			this._currentlyRunningThreadsMax.Text = this._maxThreads.Text;
			this._parseTextInputValues();
			if (this._minThreadsCount > this._maxThreadsCount) {
				this._minThreadsCount = this._maxThreadsCount;
				this._minThreads.Text = this._minThreadsCount.ToString();
			}
			this._currentlyRunningThreadsValue.Text = Math.Round(
				this._minThreadsCount + (
					((float)this._currentlyRunningThreadsSlider.Value / 100) * (this._maxThreadsCount - this._minThreadsCount)
				)
			).ToString();
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
		private long _findPrimeNumber (int n) {
			int count=0;
			long a = 2;
			while (count < n) {
				long b = 2;
				int prime = 1;// to check if found a prime
				while (b * b <= a) {
					if (a % b == 0) {
						prime = 0;
						break;
					}
					b++;
				}
				if (prime > 0) {
					count++;
				}
				a++;
			}
			return (--a);
		}
	}
}
