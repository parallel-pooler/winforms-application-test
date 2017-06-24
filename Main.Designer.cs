namespace WinFormsApplicationParallelTest {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
			this._startBtn = new System.Windows.Forms.Button();
			this.definitionGroup = new System.Windows.Forms.GroupBox();
			this._heapIncreaseForRunningThreadsCount = new System.Windows.Forms.CheckBox();
			this._heapStartCheckbox = new System.Windows.Forms.CheckBox();
			this._taskPauseMilisecondsValue = new System.Windows.Forms.TextBox();
			this._currentlyRunningThreadsValue = new System.Windows.Forms.TextBox();
			this._taskPauseMilisecondsMin = new System.Windows.Forms.TextBox();
			this._taskPauseMilisecondsMax = new System.Windows.Forms.TextBox();
			this.taskPauseMilisecondsLabel = new System.Windows.Forms.Label();
			this._taskPauseMilisecondsSlider = new System.Windows.Forms.TrackBar();
			this._currentlyRunningThreadsMin = new System.Windows.Forms.TextBox();
			this._currentlyRunningThreadsMax = new System.Windows.Forms.TextBox();
			this.minThreadsLabel = new System.Windows.Forms.Label();
			this._minThreads = new System.Windows.Forms.TextBox();
			this.currentlyRunningThreadsLabel1 = new System.Windows.Forms.Label();
			this._currentlyRunningThreadsSlider = new System.Windows.Forms.TrackBar();
			this.maxThreadsLabel = new System.Windows.Forms.Label();
			this.tasksCountLabel = new System.Windows.Forms.Label();
			this._maxThreads = new System.Windows.Forms.TextBox();
			this._tasksCount = new System.Windows.Forms.TextBox();
			this.monitoringGroup = new System.Windows.Forms.GroupBox();
			this._spendedTime = new System.Windows.Forms.TextBox();
			this._maxThreadsCountPeak = new System.Windows.Forms.TextBox();
			this._currentlyRunningThreads = new System.Windows.Forms.TextBox();
			this._exceptionThreadsCount = new System.Windows.Forms.TextBox();
			this._doneThreadsCount = new System.Windows.Forms.TextBox();
			this._startedThreadsCount = new System.Windows.Forms.TextBox();
			this.spendedTimeLabel = new System.Windows.Forms.Label();
			this.maxThreadsCountPeakLabel = new System.Windows.Forms.Label();
			this.currentlyRunningThreadsLabel2 = new System.Windows.Forms.Label();
			this.exceptionThreadsCountLabel = new System.Windows.Forms.Label();
			this.doneThreadsCountLabel = new System.Windows.Forms.Label();
			this.startedThreadsCountLabel = new System.Windows.Forms.Label();
			this._currentlyRuningThreadsAgainstMaximumText = new System.Windows.Forms.TextBox();
			this._threadingStartsProgressBar = new System.Windows.Forms.ProgressBar();
			this.currentlyRuningThreadsAgainstMaximumLabel = new System.Windows.Forms.Label();
			this._threadsExceptionsProgressText = new System.Windows.Forms.TextBox();
			this._currentlyRuningThreadsAgainstMaximumBar = new System.Windows.Forms.ProgressBar();
			this.threadingStartsProgressLabel = new System.Windows.Forms.Label();
			this.threadsExceptionsProgressLabel = new System.Windows.Forms.Label();
			this._threadingStartsProgressText = new System.Windows.Forms.TextBox();
			this._threadsExceptionsProgressBar = new System.Windows.Forms.ProgressBar();
			this._threadsDoneProgressBar = new System.Windows.Forms.ProgressBar();
			this._threadsDoneProgressText = new System.Windows.Forms.TextBox();
			this.threadsDoneProgressLabel = new System.Windows.Forms.Label();
			this._stopBtn = new System.Windows.Forms.Button();
			this._testType = new System.Windows.Forms.ComboBox();
			this.definitionGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._taskPauseMilisecondsSlider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._currentlyRunningThreadsSlider)).BeginInit();
			this.monitoringGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// _startBtn
			// 
			this._startBtn.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this._startBtn.Location = new System.Drawing.Point(12, 654);
			this._startBtn.Name = "_startBtn";
			this._startBtn.Size = new System.Drawing.Size(334, 68);
			this._startBtn.TabIndex = 0;
			this._startBtn.Text = "Start test";
			this._startBtn.UseVisualStyleBackColor = true;
			this._startBtn.Click += new System.EventHandler(this._startBtn_Click);
			// 
			// definitionGroup
			// 
			this.definitionGroup.Controls.Add(this._testType);
			this.definitionGroup.Controls.Add(this._heapIncreaseForRunningThreadsCount);
			this.definitionGroup.Controls.Add(this._heapStartCheckbox);
			this.definitionGroup.Controls.Add(this._taskPauseMilisecondsValue);
			this.definitionGroup.Controls.Add(this._currentlyRunningThreadsValue);
			this.definitionGroup.Controls.Add(this._taskPauseMilisecondsMin);
			this.definitionGroup.Controls.Add(this._taskPauseMilisecondsMax);
			this.definitionGroup.Controls.Add(this.taskPauseMilisecondsLabel);
			this.definitionGroup.Controls.Add(this._taskPauseMilisecondsSlider);
			this.definitionGroup.Controls.Add(this._currentlyRunningThreadsMin);
			this.definitionGroup.Controls.Add(this._currentlyRunningThreadsMax);
			this.definitionGroup.Controls.Add(this.minThreadsLabel);
			this.definitionGroup.Controls.Add(this._minThreads);
			this.definitionGroup.Controls.Add(this.currentlyRunningThreadsLabel1);
			this.definitionGroup.Controls.Add(this._currentlyRunningThreadsSlider);
			this.definitionGroup.Controls.Add(this.maxThreadsLabel);
			this.definitionGroup.Controls.Add(this.tasksCountLabel);
			this.definitionGroup.Controls.Add(this._maxThreads);
			this.definitionGroup.Controls.Add(this._tasksCount);
			this.definitionGroup.Location = new System.Drawing.Point(12, 12);
			this.definitionGroup.Name = "definitionGroup";
			this.definitionGroup.Size = new System.Drawing.Size(688, 285);
			this.definitionGroup.TabIndex = 13;
			this.definitionGroup.TabStop = false;
			this.definitionGroup.Text = "Definition:";
			// 
			// _heapIncreaseForRunningThreadsCount
			// 
			this._heapIncreaseForRunningThreadsCount.AutoSize = true;
			this._heapIncreaseForRunningThreadsCount.Location = new System.Drawing.Point(389, 249);
			this._heapIncreaseForRunningThreadsCount.Name = "_heapIncreaseForRunningThreadsCount";
			this._heapIncreaseForRunningThreadsCount.Size = new System.Drawing.Size(286, 21);
			this._heapIncreaseForRunningThreadsCount.TabIndex = 31;
			this._heapIncreaseForRunningThreadsCount.Text = "Heap increase for running threads count";
			this._heapIncreaseForRunningThreadsCount.UseVisualStyleBackColor = true;
			// 
			// _heapStartCheckbox
			// 
			this._heapStartCheckbox.AutoSize = true;
			this._heapStartCheckbox.Location = new System.Drawing.Point(176, 249);
			this._heapStartCheckbox.Name = "_heapStartCheckbox";
			this._heapStartCheckbox.Size = new System.Drawing.Size(200, 21);
			this._heapStartCheckbox.TabIndex = 30;
			this._heapStartCheckbox.Text = "Heap pool processing start";
			this._heapStartCheckbox.UseVisualStyleBackColor = true;
			// 
			// _taskPauseMilisecondsValue
			// 
			this._taskPauseMilisecondsValue.BackColor = System.Drawing.SystemColors.Control;
			this._taskPauseMilisecondsValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._taskPauseMilisecondsValue.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this._taskPauseMilisecondsValue.Location = new System.Drawing.Point(304, 213);
			this._taskPauseMilisecondsValue.Name = "_taskPauseMilisecondsValue";
			this._taskPauseMilisecondsValue.Size = new System.Drawing.Size(100, 16);
			this._taskPauseMilisecondsValue.TabIndex = 29;
			this._taskPauseMilisecondsValue.Text = "0";
			this._taskPauseMilisecondsValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// _currentlyRunningThreadsValue
			// 
			this._currentlyRunningThreadsValue.BackColor = System.Drawing.SystemColors.Control;
			this._currentlyRunningThreadsValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._currentlyRunningThreadsValue.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this._currentlyRunningThreadsValue.Location = new System.Drawing.Point(304, 134);
			this._currentlyRunningThreadsValue.Name = "_currentlyRunningThreadsValue";
			this._currentlyRunningThreadsValue.Size = new System.Drawing.Size(100, 16);
			this._currentlyRunningThreadsValue.TabIndex = 28;
			this._currentlyRunningThreadsValue.Text = "10";
			this._currentlyRunningThreadsValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// _taskPauseMilisecondsMin
			// 
			this._taskPauseMilisecondsMin.BackColor = System.Drawing.SystemColors.Control;
			this._taskPauseMilisecondsMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._taskPauseMilisecondsMin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this._taskPauseMilisecondsMin.Location = new System.Drawing.Point(15, 214);
			this._taskPauseMilisecondsMin.Name = "_taskPauseMilisecondsMin";
			this._taskPauseMilisecondsMin.Size = new System.Drawing.Size(100, 16);
			this._taskPauseMilisecondsMin.TabIndex = 27;
			this._taskPauseMilisecondsMin.Text = "0";
			// 
			// _taskPauseMilisecondsMax
			// 
			this._taskPauseMilisecondsMax.BackColor = System.Drawing.SystemColors.Control;
			this._taskPauseMilisecondsMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._taskPauseMilisecondsMax.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this._taskPauseMilisecondsMax.Location = new System.Drawing.Point(572, 213);
			this._taskPauseMilisecondsMax.Name = "_taskPauseMilisecondsMax";
			this._taskPauseMilisecondsMax.Size = new System.Drawing.Size(100, 16);
			this._taskPauseMilisecondsMax.TabIndex = 26;
			this._taskPauseMilisecondsMax.Text = "1000";
			this._taskPauseMilisecondsMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// taskPauseMilisecondsLabel
			// 
			this.taskPauseMilisecondsLabel.AutoSize = true;
			this.taskPauseMilisecondsLabel.Location = new System.Drawing.Point(12, 154);
			this.taskPauseMilisecondsLabel.Name = "taskPauseMilisecondsLabel";
			this.taskPauseMilisecondsLabel.Size = new System.Drawing.Size(163, 17);
			this.taskPauseMilisecondsLabel.TabIndex = 25;
			this.taskPauseMilisecondsLabel.Text = "Task pause miliseconds:";
			// 
			// _taskPauseMilisecondsSlider
			// 
			this._taskPauseMilisecondsSlider.Location = new System.Drawing.Point(15, 174);
			this._taskPauseMilisecondsSlider.Maximum = 100;
			this._taskPauseMilisecondsSlider.Name = "_taskPauseMilisecondsSlider";
			this._taskPauseMilisecondsSlider.Size = new System.Drawing.Size(657, 56);
			this._taskPauseMilisecondsSlider.TabIndex = 24;
			this._taskPauseMilisecondsSlider.Scroll += new System.EventHandler(this._taskPauseMilisecondsSlider_Scroll);
			// 
			// _currentlyRunningThreadsMin
			// 
			this._currentlyRunningThreadsMin.BackColor = System.Drawing.SystemColors.Control;
			this._currentlyRunningThreadsMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._currentlyRunningThreadsMin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this._currentlyRunningThreadsMin.Location = new System.Drawing.Point(15, 134);
			this._currentlyRunningThreadsMin.Name = "_currentlyRunningThreadsMin";
			this._currentlyRunningThreadsMin.Size = new System.Drawing.Size(100, 16);
			this._currentlyRunningThreadsMin.TabIndex = 23;
			this._currentlyRunningThreadsMin.Text = "10";
			// 
			// _currentlyRunningThreadsMax
			// 
			this._currentlyRunningThreadsMax.BackColor = System.Drawing.SystemColors.Control;
			this._currentlyRunningThreadsMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._currentlyRunningThreadsMax.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this._currentlyRunningThreadsMax.Location = new System.Drawing.Point(572, 133);
			this._currentlyRunningThreadsMax.Name = "_currentlyRunningThreadsMax";
			this._currentlyRunningThreadsMax.Size = new System.Drawing.Size(100, 16);
			this._currentlyRunningThreadsMax.TabIndex = 22;
			this._currentlyRunningThreadsMax.Text = "100";
			this._currentlyRunningThreadsMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// minThreadsLabel
			// 
			this.minThreadsLabel.AutoSize = true;
			this.minThreadsLabel.Location = new System.Drawing.Point(244, 30);
			this.minThreadsLabel.Name = "minThreadsLabel";
			this.minThreadsLabel.Size = new System.Drawing.Size(90, 17);
			this.minThreadsLabel.TabIndex = 20;
			this.minThreadsLabel.Text = "Min. threads:";
			// 
			// _minThreads
			// 
			this._minThreads.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this._minThreads.Location = new System.Drawing.Point(337, 21);
			this._minThreads.Name = "_minThreads";
			this._minThreads.Size = new System.Drawing.Size(100, 30);
			this._minThreads.TabIndex = 19;
			this._minThreads.Text = "10";
			this._minThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this._minThreads.TextChanged += new System.EventHandler(this._minThreads_TextChanged);
			// 
			// currentlyRunningThreadsLabel1
			// 
			this.currentlyRunningThreadsLabel1.AutoSize = true;
			this.currentlyRunningThreadsLabel1.Location = new System.Drawing.Point(12, 74);
			this.currentlyRunningThreadsLabel1.Name = "currentlyRunningThreadsLabel1";
			this.currentlyRunningThreadsLabel1.Size = new System.Drawing.Size(173, 17);
			this.currentlyRunningThreadsLabel1.TabIndex = 18;
			this.currentlyRunningThreadsLabel1.Text = "Currently running threads:";
			// 
			// _currentlyRunningThreadsSlider
			// 
			this._currentlyRunningThreadsSlider.Location = new System.Drawing.Point(15, 94);
			this._currentlyRunningThreadsSlider.Maximum = 100;
			this._currentlyRunningThreadsSlider.Name = "_currentlyRunningThreadsSlider";
			this._currentlyRunningThreadsSlider.Size = new System.Drawing.Size(657, 56);
			this._currentlyRunningThreadsSlider.TabIndex = 17;
			this._currentlyRunningThreadsSlider.Scroll += new System.EventHandler(this._currentlyRunningThreadsSlider_Scroll);
			// 
			// maxThreadsLabel
			// 
			this.maxThreadsLabel.AutoSize = true;
			this.maxThreadsLabel.Location = new System.Drawing.Point(477, 30);
			this.maxThreadsLabel.Name = "maxThreadsLabel";
			this.maxThreadsLabel.Size = new System.Drawing.Size(93, 17);
			this.maxThreadsLabel.TabIndex = 16;
			this.maxThreadsLabel.Text = "Max. threads:";
			// 
			// tasksCountLabel
			// 
			this.tasksCountLabel.AutoSize = true;
			this.tasksCountLabel.Location = new System.Drawing.Point(12, 30);
			this.tasksCountLabel.Name = "tasksCountLabel";
			this.tasksCountLabel.Size = new System.Drawing.Size(89, 17);
			this.tasksCountLabel.TabIndex = 15;
			this.tasksCountLabel.Text = "Tasks count:";
			// 
			// _maxThreads
			// 
			this._maxThreads.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this._maxThreads.Location = new System.Drawing.Point(572, 21);
			this._maxThreads.Name = "_maxThreads";
			this._maxThreads.Size = new System.Drawing.Size(100, 30);
			this._maxThreads.TabIndex = 1;
			this._maxThreads.Text = "100";
			this._maxThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this._maxThreads.TextChanged += new System.EventHandler(this._maxThreads_TextChanged);
			// 
			// _tasksCount
			// 
			this._tasksCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this._tasksCount.Location = new System.Drawing.Point(104, 21);
			this._tasksCount.Name = "_tasksCount";
			this._tasksCount.Size = new System.Drawing.Size(100, 30);
			this._tasksCount.TabIndex = 0;
			this._tasksCount.Text = "3000";
			this._tasksCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this._tasksCount.TextChanged += new System.EventHandler(this._tasksCount_TextChanged);
			// 
			// monitoringGroup
			// 
			this.monitoringGroup.Controls.Add(this._spendedTime);
			this.monitoringGroup.Controls.Add(this._maxThreadsCountPeak);
			this.monitoringGroup.Controls.Add(this._currentlyRunningThreads);
			this.monitoringGroup.Controls.Add(this._exceptionThreadsCount);
			this.monitoringGroup.Controls.Add(this._doneThreadsCount);
			this.monitoringGroup.Controls.Add(this._startedThreadsCount);
			this.monitoringGroup.Controls.Add(this.spendedTimeLabel);
			this.monitoringGroup.Controls.Add(this.maxThreadsCountPeakLabel);
			this.monitoringGroup.Controls.Add(this.currentlyRunningThreadsLabel2);
			this.monitoringGroup.Controls.Add(this.exceptionThreadsCountLabel);
			this.monitoringGroup.Controls.Add(this.doneThreadsCountLabel);
			this.monitoringGroup.Controls.Add(this.startedThreadsCountLabel);
			this.monitoringGroup.Controls.Add(this._currentlyRuningThreadsAgainstMaximumText);
			this.monitoringGroup.Controls.Add(this._threadingStartsProgressBar);
			this.monitoringGroup.Controls.Add(this.currentlyRuningThreadsAgainstMaximumLabel);
			this.monitoringGroup.Controls.Add(this._threadsExceptionsProgressText);
			this.monitoringGroup.Controls.Add(this._currentlyRuningThreadsAgainstMaximumBar);
			this.monitoringGroup.Controls.Add(this.threadingStartsProgressLabel);
			this.monitoringGroup.Controls.Add(this.threadsExceptionsProgressLabel);
			this.monitoringGroup.Controls.Add(this._threadingStartsProgressText);
			this.monitoringGroup.Controls.Add(this._threadsExceptionsProgressBar);
			this.monitoringGroup.Controls.Add(this._threadsDoneProgressBar);
			this.monitoringGroup.Controls.Add(this._threadsDoneProgressText);
			this.monitoringGroup.Controls.Add(this.threadsDoneProgressLabel);
			this.monitoringGroup.Location = new System.Drawing.Point(12, 313);
			this.monitoringGroup.Name = "monitoringGroup";
			this.monitoringGroup.Size = new System.Drawing.Size(688, 328);
			this.monitoringGroup.TabIndex = 14;
			this.monitoringGroup.TabStop = false;
			this.monitoringGroup.Text = "Monitoring:";
			// 
			// _spendedTime
			// 
			this._spendedTime.BackColor = System.Drawing.SystemColors.ButtonFace;
			this._spendedTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._spendedTime.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this._spendedTime.Location = new System.Drawing.Point(557, 297);
			this._spendedTime.Name = "_spendedTime";
			this._spendedTime.Size = new System.Drawing.Size(115, 16);
			this._spendedTime.TabIndex = 56;
			this._spendedTime.Text = "00:00:00:000";
			this._spendedTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// _maxThreadsCountPeak
			// 
			this._maxThreadsCountPeak.BackColor = System.Drawing.SystemColors.ButtonFace;
			this._maxThreadsCountPeak.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._maxThreadsCountPeak.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this._maxThreadsCountPeak.Location = new System.Drawing.Point(557, 272);
			this._maxThreadsCountPeak.Name = "_maxThreadsCountPeak";
			this._maxThreadsCountPeak.Size = new System.Drawing.Size(115, 16);
			this._maxThreadsCountPeak.TabIndex = 55;
			this._maxThreadsCountPeak.Text = "0";
			this._maxThreadsCountPeak.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// _currentlyRunningThreads
			// 
			this._currentlyRunningThreads.BackColor = System.Drawing.SystemColors.ButtonFace;
			this._currentlyRunningThreads.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._currentlyRunningThreads.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this._currentlyRunningThreads.Location = new System.Drawing.Point(557, 247);
			this._currentlyRunningThreads.Name = "_currentlyRunningThreads";
			this._currentlyRunningThreads.Size = new System.Drawing.Size(115, 16);
			this._currentlyRunningThreads.TabIndex = 54;
			this._currentlyRunningThreads.Text = "0";
			this._currentlyRunningThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// _exceptionThreadsCount
			// 
			this._exceptionThreadsCount.BackColor = System.Drawing.SystemColors.ButtonFace;
			this._exceptionThreadsCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._exceptionThreadsCount.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this._exceptionThreadsCount.Location = new System.Drawing.Point(216, 297);
			this._exceptionThreadsCount.Name = "_exceptionThreadsCount";
			this._exceptionThreadsCount.Size = new System.Drawing.Size(115, 16);
			this._exceptionThreadsCount.TabIndex = 53;
			this._exceptionThreadsCount.Text = "0";
			this._exceptionThreadsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// _doneThreadsCount
			// 
			this._doneThreadsCount.BackColor = System.Drawing.SystemColors.ButtonFace;
			this._doneThreadsCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._doneThreadsCount.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this._doneThreadsCount.Location = new System.Drawing.Point(216, 272);
			this._doneThreadsCount.Name = "_doneThreadsCount";
			this._doneThreadsCount.Size = new System.Drawing.Size(115, 16);
			this._doneThreadsCount.TabIndex = 52;
			this._doneThreadsCount.Text = "0";
			this._doneThreadsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// _startedThreadsCount
			// 
			this._startedThreadsCount.BackColor = System.Drawing.SystemColors.ButtonFace;
			this._startedThreadsCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._startedThreadsCount.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this._startedThreadsCount.Location = new System.Drawing.Point(216, 247);
			this._startedThreadsCount.Name = "_startedThreadsCount";
			this._startedThreadsCount.Size = new System.Drawing.Size(115, 16);
			this._startedThreadsCount.TabIndex = 51;
			this._startedThreadsCount.Text = "0";
			this._startedThreadsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// spendedTimeLabel
			// 
			this.spendedTimeLabel.AutoSize = true;
			this.spendedTimeLabel.Location = new System.Drawing.Point(351, 296);
			this.spendedTimeLabel.Name = "spendedTimeLabel";
			this.spendedTimeLabel.Size = new System.Drawing.Size(99, 17);
			this.spendedTimeLabel.TabIndex = 50;
			this.spendedTimeLabel.Text = "Spended time:";
			// 
			// maxThreadsCountPeakLabel
			// 
			this.maxThreadsCountPeakLabel.AutoSize = true;
			this.maxThreadsCountPeakLabel.Location = new System.Drawing.Point(351, 271);
			this.maxThreadsCountPeakLabel.Name = "maxThreadsCountPeakLabel";
			this.maxThreadsCountPeakLabel.Size = new System.Drawing.Size(167, 17);
			this.maxThreadsCountPeakLabel.TabIndex = 49;
			this.maxThreadsCountPeakLabel.Text = "Max. threads count peak:";
			// 
			// currentlyRunningThreadsLabel2
			// 
			this.currentlyRunningThreadsLabel2.AutoSize = true;
			this.currentlyRunningThreadsLabel2.Location = new System.Drawing.Point(351, 246);
			this.currentlyRunningThreadsLabel2.Name = "currentlyRunningThreadsLabel2";
			this.currentlyRunningThreadsLabel2.Size = new System.Drawing.Size(173, 17);
			this.currentlyRunningThreadsLabel2.TabIndex = 48;
			this.currentlyRunningThreadsLabel2.Text = "Currently running threads:";
			// 
			// exceptionThreadsCountLabel
			// 
			this.exceptionThreadsCountLabel.AutoSize = true;
			this.exceptionThreadsCountLabel.Location = new System.Drawing.Point(12, 296);
			this.exceptionThreadsCountLabel.Name = "exceptionThreadsCountLabel";
			this.exceptionThreadsCountLabel.Size = new System.Drawing.Size(164, 17);
			this.exceptionThreadsCountLabel.TabIndex = 47;
			this.exceptionThreadsCountLabel.Text = "Exception threads count:";
			// 
			// doneThreadsCountLabel
			// 
			this.doneThreadsCountLabel.AutoSize = true;
			this.doneThreadsCountLabel.Location = new System.Drawing.Point(12, 271);
			this.doneThreadsCountLabel.Name = "doneThreadsCountLabel";
			this.doneThreadsCountLabel.Size = new System.Drawing.Size(137, 17);
			this.doneThreadsCountLabel.TabIndex = 46;
			this.doneThreadsCountLabel.Text = "Done threads count:";
			// 
			// startedThreadsCountLabel
			// 
			this.startedThreadsCountLabel.AutoSize = true;
			this.startedThreadsCountLabel.Location = new System.Drawing.Point(12, 246);
			this.startedThreadsCountLabel.Name = "startedThreadsCountLabel";
			this.startedThreadsCountLabel.Size = new System.Drawing.Size(149, 17);
			this.startedThreadsCountLabel.TabIndex = 45;
			this.startedThreadsCountLabel.Text = "Started threads count:";
			// 
			// _currentlyRuningThreadsAgainstMaximumText
			// 
			this._currentlyRuningThreadsAgainstMaximumText.BackColor = System.Drawing.SystemColors.ButtonFace;
			this._currentlyRuningThreadsAgainstMaximumText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this._currentlyRuningThreadsAgainstMaximumText.Location = new System.Drawing.Point(607, 201);
			this._currentlyRuningThreadsAgainstMaximumText.Name = "_currentlyRuningThreadsAgainstMaximumText";
			this._currentlyRuningThreadsAgainstMaximumText.Size = new System.Drawing.Size(68, 30);
			this._currentlyRuningThreadsAgainstMaximumText.TabIndex = 44;
			this._currentlyRuningThreadsAgainstMaximumText.Text = "0 %";
			this._currentlyRuningThreadsAgainstMaximumText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// _threadingStartsProgressBar
			// 
			this._threadingStartsProgressBar.Location = new System.Drawing.Point(12, 45);
			this._threadingStartsProgressBar.Maximum = 1000;
			this._threadingStartsProgressBar.Name = "_threadingStartsProgressBar";
			this._threadingStartsProgressBar.Size = new System.Drawing.Size(589, 30);
			this._threadingStartsProgressBar.TabIndex = 34;
			// 
			// currentlyRuningThreadsAgainstMaximumLabel
			// 
			this.currentlyRuningThreadsAgainstMaximumLabel.AutoSize = true;
			this.currentlyRuningThreadsAgainstMaximumLabel.Location = new System.Drawing.Point(12, 181);
			this.currentlyRuningThreadsAgainstMaximumLabel.Name = "currentlyRuningThreadsAgainstMaximumLabel";
			this.currentlyRuningThreadsAgainstMaximumLabel.Size = new System.Drawing.Size(281, 17);
			this.currentlyRuningThreadsAgainstMaximumLabel.TabIndex = 43;
			this.currentlyRuningThreadsAgainstMaximumLabel.Text = "Currently runing threads  against maximum:";
			// 
			// _threadsExceptionsProgressText
			// 
			this._threadsExceptionsProgressText.BackColor = System.Drawing.SystemColors.ButtonFace;
			this._threadsExceptionsProgressText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this._threadsExceptionsProgressText.Location = new System.Drawing.Point(607, 149);
			this._threadsExceptionsProgressText.Name = "_threadsExceptionsProgressText";
			this._threadsExceptionsProgressText.Size = new System.Drawing.Size(68, 30);
			this._threadsExceptionsProgressText.TabIndex = 33;
			this._threadsExceptionsProgressText.Text = "0 %";
			this._threadsExceptionsProgressText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// _currentlyRuningThreadsAgainstMaximumBar
			// 
			this._currentlyRuningThreadsAgainstMaximumBar.Location = new System.Drawing.Point(12, 201);
			this._currentlyRuningThreadsAgainstMaximumBar.Maximum = 1000;
			this._currentlyRuningThreadsAgainstMaximumBar.Name = "_currentlyRuningThreadsAgainstMaximumBar";
			this._currentlyRuningThreadsAgainstMaximumBar.Size = new System.Drawing.Size(589, 30);
			this._currentlyRuningThreadsAgainstMaximumBar.TabIndex = 42;
			// 
			// threadingStartsProgressLabel
			// 
			this.threadingStartsProgressLabel.AutoSize = true;
			this.threadingStartsProgressLabel.Location = new System.Drawing.Point(12, 25);
			this.threadingStartsProgressLabel.Name = "threadingStartsProgressLabel";
			this.threadingStartsProgressLabel.Size = new System.Drawing.Size(176, 17);
			this.threadingStartsProgressLabel.TabIndex = 35;
			this.threadingStartsProgressLabel.Text = "Threading starts progress:";
			// 
			// threadsExceptionsProgressLabel
			// 
			this.threadsExceptionsProgressLabel.AutoSize = true;
			this.threadsExceptionsProgressLabel.Location = new System.Drawing.Point(12, 129);
			this.threadsExceptionsProgressLabel.Name = "threadsExceptionsProgressLabel";
			this.threadsExceptionsProgressLabel.Size = new System.Drawing.Size(196, 17);
			this.threadsExceptionsProgressLabel.TabIndex = 41;
			this.threadsExceptionsProgressLabel.Text = "Threads exceptions progress:";
			// 
			// _threadingStartsProgressText
			// 
			this._threadingStartsProgressText.BackColor = System.Drawing.SystemColors.ButtonFace;
			this._threadingStartsProgressText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this._threadingStartsProgressText.Location = new System.Drawing.Point(607, 45);
			this._threadingStartsProgressText.Name = "_threadingStartsProgressText";
			this._threadingStartsProgressText.Size = new System.Drawing.Size(68, 30);
			this._threadingStartsProgressText.TabIndex = 36;
			this._threadingStartsProgressText.Text = "0 %";
			this._threadingStartsProgressText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// _threadsExceptionsProgressBar
			// 
			this._threadsExceptionsProgressBar.Location = new System.Drawing.Point(12, 149);
			this._threadsExceptionsProgressBar.Maximum = 1000;
			this._threadsExceptionsProgressBar.Name = "_threadsExceptionsProgressBar";
			this._threadsExceptionsProgressBar.Size = new System.Drawing.Size(589, 30);
			this._threadsExceptionsProgressBar.TabIndex = 40;
			// 
			// _threadsDoneProgressBar
			// 
			this._threadsDoneProgressBar.Location = new System.Drawing.Point(12, 97);
			this._threadsDoneProgressBar.Maximum = 1000;
			this._threadsDoneProgressBar.Name = "_threadsDoneProgressBar";
			this._threadsDoneProgressBar.Size = new System.Drawing.Size(589, 30);
			this._threadsDoneProgressBar.TabIndex = 37;
			// 
			// _threadsDoneProgressText
			// 
			this._threadsDoneProgressText.BackColor = System.Drawing.SystemColors.ButtonFace;
			this._threadsDoneProgressText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this._threadsDoneProgressText.Location = new System.Drawing.Point(607, 97);
			this._threadsDoneProgressText.Name = "_threadsDoneProgressText";
			this._threadsDoneProgressText.Size = new System.Drawing.Size(68, 30);
			this._threadsDoneProgressText.TabIndex = 39;
			this._threadsDoneProgressText.Text = "0 %";
			this._threadsDoneProgressText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// threadsDoneProgressLabel
			// 
			this.threadsDoneProgressLabel.AutoSize = true;
			this.threadsDoneProgressLabel.Location = new System.Drawing.Point(12, 77);
			this.threadsDoneProgressLabel.Name = "threadsDoneProgressLabel";
			this.threadsDoneProgressLabel.Size = new System.Drawing.Size(161, 17);
			this.threadsDoneProgressLabel.TabIndex = 38;
			this.threadsDoneProgressLabel.Text = "Threads done progress:";
			// 
			// _stopBtn
			// 
			this._stopBtn.Enabled = false;
			this._stopBtn.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this._stopBtn.Location = new System.Drawing.Point(366, 654);
			this._stopBtn.Name = "_stopBtn";
			this._stopBtn.Size = new System.Drawing.Size(334, 68);
			this._stopBtn.TabIndex = 15;
			this._stopBtn.Text = "Stop test";
			this._stopBtn.UseVisualStyleBackColor = true;
			this._stopBtn.Click += new System.EventHandler(this._stopBtn_Click);
			// 
			// _testType
			// 
			this._testType.FormattingEnabled = true;
			this._testType.Items.AddRange(new object[] {
            "Parallel test",
            "Repeater test"});
			this._testType.Location = new System.Drawing.Point(15, 246);
			this._testType.Name = "_testType";
			this._testType.Size = new System.Drawing.Size(146, 24);
			this._testType.TabIndex = 32;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(715, 734);
			this.Controls.Add(this._stopBtn);
			this.Controls.Add(this.monitoringGroup);
			this.Controls.Add(this.definitionGroup);
			this.Controls.Add(this._startBtn);
			this.Name = "Main";
			this.Text = "Parallel Pooler Test";
			this.definitionGroup.ResumeLayout(false);
			this.definitionGroup.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._taskPauseMilisecondsSlider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._currentlyRunningThreadsSlider)).EndInit();
			this.monitoringGroup.ResumeLayout(false);
			this.monitoringGroup.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _startBtn;
        private System.Windows.Forms.GroupBox definitionGroup;
        private System.Windows.Forms.TextBox _tasksCount;
        private System.Windows.Forms.GroupBox monitoringGroup;
        private System.Windows.Forms.TextBox _currentlyRuningThreadsAgainstMaximumText;
        private System.Windows.Forms.ProgressBar _threadingStartsProgressBar;
        private System.Windows.Forms.Label currentlyRuningThreadsAgainstMaximumLabel;
        private System.Windows.Forms.TextBox _threadsExceptionsProgressText;
        private System.Windows.Forms.ProgressBar _currentlyRuningThreadsAgainstMaximumBar;
        private System.Windows.Forms.Label threadingStartsProgressLabel;
        private System.Windows.Forms.Label threadsExceptionsProgressLabel;
        private System.Windows.Forms.TextBox _threadingStartsProgressText;
        private System.Windows.Forms.ProgressBar _threadsExceptionsProgressBar;
        private System.Windows.Forms.ProgressBar _threadsDoneProgressBar;
        private System.Windows.Forms.TextBox _threadsDoneProgressText;
        private System.Windows.Forms.Label threadsDoneProgressLabel;
        private System.Windows.Forms.Label tasksCountLabel;
        private System.Windows.Forms.TextBox _maxThreads;
        private System.Windows.Forms.Label maxThreadsLabel;
        private System.Windows.Forms.Label minThreadsLabel;
        private System.Windows.Forms.TextBox _minThreads;
        private System.Windows.Forms.Label currentlyRunningThreadsLabel1;
        private System.Windows.Forms.TrackBar _currentlyRunningThreadsSlider;
        private System.Windows.Forms.TextBox _currentlyRunningThreadsMin;
        private System.Windows.Forms.TextBox _currentlyRunningThreadsMax;
        private System.Windows.Forms.TextBox _taskPauseMilisecondsMin;
        private System.Windows.Forms.TextBox _taskPauseMilisecondsMax;
        private System.Windows.Forms.Label taskPauseMilisecondsLabel;
        private System.Windows.Forms.TrackBar _taskPauseMilisecondsSlider;
        private System.Windows.Forms.TextBox _currentlyRunningThreadsValue;
        private System.Windows.Forms.TextBox _taskPauseMilisecondsValue;
        private System.Windows.Forms.Label exceptionThreadsCountLabel;
        private System.Windows.Forms.Label doneThreadsCountLabel;
        private System.Windows.Forms.Label startedThreadsCountLabel;
        private System.Windows.Forms.Label currentlyRunningThreadsLabel2;
        private System.Windows.Forms.Label maxThreadsCountPeakLabel;
        private System.Windows.Forms.Label spendedTimeLabel;
        private System.Windows.Forms.TextBox _spendedTime;
        private System.Windows.Forms.TextBox _maxThreadsCountPeak;
        private System.Windows.Forms.TextBox _currentlyRunningThreads;
        private System.Windows.Forms.TextBox _exceptionThreadsCount;
        private System.Windows.Forms.TextBox _doneThreadsCount;
        private System.Windows.Forms.TextBox _startedThreadsCount;
        private System.Windows.Forms.Button _stopBtn;
		private System.Windows.Forms.CheckBox _heapIncreaseForRunningThreadsCount;
		private System.Windows.Forms.CheckBox _heapStartCheckbox;
		private System.Windows.Forms.ComboBox _testType;
	}
}

