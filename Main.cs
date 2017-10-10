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
		const int TASKS_COUNT_DEFAULT = 20000;
		const int MIN_THREADS_DEFAULT = 5;
		const int MAX_THREADS_DEFAULT = 30;
		const int TASKS_PAUSE_MILISECONDS_DEFAULT = 10;
		const int N_EXCEPTIONS = 0; // 0 or 1 means no exception, 2 means every second task throw an exception, 3 means every third task etc...

		private Pooler.Base _pool = null;

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

			this._testType.SelectedItem = this._testType.Items[0];

			this._tasksCount.Text = Main.TASKS_COUNT_DEFAULT.ToString();
			this._minThreads.Text = Main.MIN_THREADS_DEFAULT.ToString();
			this._maxThreads.Text = Main.MAX_THREADS_DEFAULT.ToString();
			this._taskPauseMilisecondsSlider.Value = Main.TASKS_PAUSE_MILISECONDS_DEFAULT;

			this._tasksCount_TextChanged(this._tasksCount, new EventArgs());
			this._minThreads_TextChanged(this._minThreads, new EventArgs());
			this._maxThreads_TextChanged(this._maxThreads, new EventArgs());
			this._currentlyRunningThreadsSlider_Scroll(this._currentlyRunningThreadsSlider, new EventArgs());

			// set application exit to stop 
			Application.ApplicationExit += delegate {
				if (this._reportThread != null) this._reportThread.Abort();
				if (this._pool != null) this._pool.StopProcessing(true);
			};
		}		
	}
}
