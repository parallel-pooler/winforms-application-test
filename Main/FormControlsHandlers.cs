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
		private void _stopBtn_Click (object sender, EventArgs e) {
			if (this._pool != null) this._pool.StopProcessing();
			if (this._reportThread != null) this._reportThread.Abort();
			this._taskBeginCounter = 0;
			this._taskDoneCounter = 0;
			this._taskExceptionCounter = 0;
			this._currentlyRunningTasksCounter = 0;
			this._peakThreadsCounter = 0;
			this.BackgroundReporting();
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
	}
}
