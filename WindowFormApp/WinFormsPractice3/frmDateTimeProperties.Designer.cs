namespace MyFirstWinFormsProject1
{
    partial class frmDateTimeProperties
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnShortDateString = new System.Windows.Forms.Button();
            this.btnLongDateString = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnSelectRange = new System.Windows.Forms.Button();
            this.btnSelectStartRange = new System.Windows.Forms.Button();
            this.btnSelectEndRange = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowIcon = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnShortDateString
            // 
            this.btnShortDateString.Location = new System.Drawing.Point(23, 50);
            this.btnShortDateString.Name = "btnShortDateString";
            this.btnShortDateString.Size = new System.Drawing.Size(102, 41);
            this.btnShortDateString.TabIndex = 1;
            this.btnShortDateString.Text = "Short Date String";
            this.btnShortDateString.UseVisualStyleBackColor = true;
            this.btnShortDateString.Click += new System.EventHandler(this.btnShortDateString_Click);
            // 
            // btnLongDateString
            // 
            this.btnLongDateString.Location = new System.Drawing.Point(129, 51);
            this.btnLongDateString.Name = "btnLongDateString";
            this.btnLongDateString.Size = new System.Drawing.Size(102, 41);
            this.btnLongDateString.TabIndex = 2;
            this.btnLongDateString.Text = "Long Date String";
            this.btnLongDateString.UseVisualStyleBackColor = true;
            this.btnLongDateString.Click += new System.EventHandler(this.btnLongDateString_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(338, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.ShowWeekNumbers = true;
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.LightGray;
            // 
            // btnSelectRange
            // 
            this.btnSelectRange.Location = new System.Drawing.Point(312, 192);
            this.btnSelectRange.Name = "btnSelectRange";
            this.btnSelectRange.Size = new System.Drawing.Size(96, 45);
            this.btnSelectRange.TabIndex = 5;
            this.btnSelectRange.Text = "Select Range";
            this.btnSelectRange.UseVisualStyleBackColor = true;
            this.btnSelectRange.Click += new System.EventHandler(this.btnSelectRange_Click);
            // 
            // btnSelectStartRange
            // 
            this.btnSelectStartRange.Location = new System.Drawing.Point(416, 192);
            this.btnSelectStartRange.Name = "btnSelectStartRange";
            this.btnSelectStartRange.Size = new System.Drawing.Size(112, 45);
            this.btnSelectStartRange.TabIndex = 6;
            this.btnSelectStartRange.Text = "Select Start Range";
            this.btnSelectStartRange.UseVisualStyleBackColor = true;
            this.btnSelectStartRange.Click += new System.EventHandler(this.btnSelectStartRange_Click);
            // 
            // btnSelectEndRange
            // 
            this.btnSelectEndRange.Location = new System.Drawing.Point(534, 192);
            this.btnSelectEndRange.Name = "btnSelectEndRange";
            this.btnSelectEndRange.Size = new System.Drawing.Size(110, 45);
            this.btnSelectEndRange.TabIndex = 7;
            this.btnSelectEndRange.Text = "Select End Range";
            this.btnSelectEndRange.UseVisualStyleBackColor = true;
            this.btnSelectEndRange.Click += new System.EventHandler(this.btnSelectEndRange_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(19, 250);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 24);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(101, 250);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 24);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Start Counting";
            // 
            // btnShowIcon
            // 
            this.btnShowIcon.Location = new System.Drawing.Point(55, 354);
            this.btnShowIcon.Name = "btnShowIcon";
            this.btnShowIcon.Size = new System.Drawing.Size(122, 39);
            this.btnShowIcon.TabIndex = 11;
            this.btnShowIcon.Text = "Show Icon";
            this.btnShowIcon.UseVisualStyleBackColor = true;
            this.btnShowIcon.Click += new System.EventHandler(this.btnShowIcon_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "\"This is a Title\"";
            this.notifyIcon1.BalloonTipTitle = "\"this is a message\"";
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "changeDataTimePiker";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(182, 250);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 24);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmDateTimeProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnShowIcon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSelectEndRange);
            this.Controls.Add(this.btnSelectStartRange);
            this.Controls.Add(this.btnSelectRange);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLongDateString);
            this.Controls.Add(this.btnShortDateString);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "frmDateTimeProperties";
            this.Text = "frmDateTimeProperties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnShortDateString;
        private System.Windows.Forms.Button btnLongDateString;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnSelectRange;
        private System.Windows.Forms.Button btnSelectStartRange;
        private System.Windows.Forms.Button btnSelectEndRange;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowIcon;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
    }
}