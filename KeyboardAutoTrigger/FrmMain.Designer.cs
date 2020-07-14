namespace KeyboardAutoTrigger
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbTimeCountdown = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lbTriggerInterval = new System.Windows.Forms.Label();
            this.counterHour = new System.Windows.Forms.NumericUpDown();
            this.counterMinute = new System.Windows.Forms.NumericUpDown();
            this.counterSecond = new System.Windows.Forms.NumericUpDown();
            this.cbRandomTimeDelta = new System.Windows.Forms.CheckBox();
            this.tbTimeDelta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbKeys = new System.Windows.Forms.Label();
            this.btnKeyChooser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.counterHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "下一次触发倒计时：";
            // 
            // lbTimeCountdown
            // 
            this.lbTimeCountdown.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTimeCountdown.Location = new System.Drawing.Point(122, 13);
            this.lbTimeCountdown.Name = "lbTimeCountdown";
            this.lbTimeCountdown.Size = new System.Drawing.Size(238, 52);
            this.lbTimeCountdown.TabIndex = 1;
            this.lbTimeCountdown.Text = "00:00:00";
            this.lbTimeCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbStatus
            // 
            this.lbStatus.BackColor = System.Drawing.Color.Gold;
            this.lbStatus.Location = new System.Drawing.Point(360, 133);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(81, 23);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "就绪状态";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(366, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(366, 42);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // lbTriggerInterval
            // 
            this.lbTriggerInterval.AutoSize = true;
            this.lbTriggerInterval.Location = new System.Drawing.Point(12, 111);
            this.lbTriggerInterval.Name = "lbTriggerInterval";
            this.lbTriggerInterval.Size = new System.Drawing.Size(323, 12);
            this.lbTriggerInterval.TabIndex = 5;
            this.lbTriggerInterval.Text = "触发时间间隔：         小时          分钟          秒";
            // 
            // counterHour
            // 
            this.counterHour.Location = new System.Drawing.Point(98, 107);
            this.counterHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.counterHour.Name = "counterHour";
            this.counterHour.Size = new System.Drawing.Size(49, 21);
            this.counterHour.TabIndex = 6;
            this.counterHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // counterMinute
            // 
            this.counterMinute.Location = new System.Drawing.Point(182, 107);
            this.counterMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.counterMinute.Name = "counterMinute";
            this.counterMinute.Size = new System.Drawing.Size(49, 21);
            this.counterMinute.TabIndex = 7;
            this.counterMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // counterSecond
            // 
            this.counterSecond.Location = new System.Drawing.Point(266, 107);
            this.counterSecond.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.counterSecond.Name = "counterSecond";
            this.counterSecond.Size = new System.Drawing.Size(49, 21);
            this.counterSecond.TabIndex = 8;
            this.counterSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbRandomTimeDelta
            // 
            this.cbRandomTimeDelta.AutoSize = true;
            this.cbRandomTimeDelta.Location = new System.Drawing.Point(12, 137);
            this.cbRandomTimeDelta.Name = "cbRandomTimeDelta";
            this.cbRandomTimeDelta.Size = new System.Drawing.Size(120, 16);
            this.cbRandomTimeDelta.TabIndex = 9;
            this.cbRandomTimeDelta.Text = "加入随机间隔误差";
            this.cbRandomTimeDelta.UseVisualStyleBackColor = true;
            this.cbRandomTimeDelta.CheckedChanged += new System.EventHandler(this.CbRandomTimeDelta_CheckedChanged);
            // 
            // tbTimeDelta
            // 
            this.tbTimeDelta.Enabled = false;
            this.tbTimeDelta.Location = new System.Drawing.Point(138, 135);
            this.tbTimeDelta.Name = "tbTimeDelta";
            this.tbTimeDelta.Size = new System.Drawing.Size(100, 21);
            this.tbTimeDelta.TabIndex = 10;
            this.tbTimeDelta.Text = "0";
            this.tbTimeDelta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "秒";
            // 
            // lbKeys
            // 
            this.lbKeys.AutoSize = true;
            this.lbKeys.Location = new System.Drawing.Point(12, 75);
            this.lbKeys.Name = "lbKeys";
            this.lbKeys.Size = new System.Drawing.Size(89, 12);
            this.lbKeys.TabIndex = 12;
            this.lbKeys.Text = "要触发的按键：";
            // 
            // btnKeyChooser
            // 
            this.btnKeyChooser.Location = new System.Drawing.Point(366, 71);
            this.btnKeyChooser.Name = "btnKeyChooser";
            this.btnKeyChooser.Size = new System.Drawing.Size(75, 23);
            this.btnKeyChooser.TabIndex = 13;
            this.btnKeyChooser.Text = "选择按键";
            this.btnKeyChooser.UseVisualStyleBackColor = true;
            this.btnKeyChooser.Click += new System.EventHandler(this.BtnKeyChooser_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(453, 165);
            this.Controls.Add(this.btnKeyChooser);
            this.Controls.Add(this.lbKeys);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTimeDelta);
            this.Controls.Add(this.cbRandomTimeDelta);
            this.Controls.Add(this.counterSecond);
            this.Controls.Add(this.counterMinute);
            this.Controls.Add(this.counterHour);
            this.Controls.Add(this.lbTriggerInterval);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbTimeCountdown);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "键盘事件自动触发器";
            ((System.ComponentModel.ISupportInitialize)(this.counterHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterSecond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTimeCountdown;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lbTriggerInterval;
        private System.Windows.Forms.NumericUpDown counterHour;
        private System.Windows.Forms.NumericUpDown counterMinute;
        private System.Windows.Forms.NumericUpDown counterSecond;
        private System.Windows.Forms.CheckBox cbRandomTimeDelta;
        private System.Windows.Forms.TextBox tbTimeDelta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbKeys;
        private System.Windows.Forms.Button btnKeyChooser;
    }
}

