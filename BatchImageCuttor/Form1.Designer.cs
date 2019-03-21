namespace BatchImageCuttor
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbInputDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowseImportDir = new System.Windows.Forms.Button();
            this.tbOutputDirectory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowseOuput = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbOutputFormat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTargetHeightPixels = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTargetWidthPixels = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.btnCut = new System.Windows.Forms.Button();
            this.dirBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入目录：";
            // 
            // tbInputDirectory
            // 
            this.tbInputDirectory.Location = new System.Drawing.Point(84, 20);
            this.tbInputDirectory.Name = "tbInputDirectory";
            this.tbInputDirectory.Size = new System.Drawing.Size(575, 21);
            this.tbInputDirectory.TabIndex = 1;
            // 
            // btnBrowseImportDir
            // 
            this.btnBrowseImportDir.Location = new System.Drawing.Point(665, 18);
            this.btnBrowseImportDir.Name = "btnBrowseImportDir";
            this.btnBrowseImportDir.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseImportDir.TabIndex = 2;
            this.btnBrowseImportDir.Text = "浏览...";
            this.btnBrowseImportDir.UseVisualStyleBackColor = true;
            this.btnBrowseImportDir.Click += new System.EventHandler(this.BtnBrowseImportDir_Click);
            // 
            // tbOutputDirectory
            // 
            this.tbOutputDirectory.Location = new System.Drawing.Point(84, 47);
            this.tbOutputDirectory.Name = "tbOutputDirectory";
            this.tbOutputDirectory.Size = new System.Drawing.Size(575, 21);
            this.tbOutputDirectory.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "输出目录：";
            // 
            // btnBrowseOuput
            // 
            this.btnBrowseOuput.Location = new System.Drawing.Point(665, 45);
            this.btnBrowseOuput.Name = "btnBrowseOuput";
            this.btnBrowseOuput.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseOuput.TabIndex = 5;
            this.btnBrowseOuput.Text = "浏览...";
            this.btnBrowseOuput.UseVisualStyleBackColor = true;
            this.btnBrowseOuput.Click += new System.EventHandler(this.BtnBrowseOuput_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBrowseOuput);
            this.groupBox1.Controls.Add(this.tbInputDirectory);
            this.groupBox1.Controls.Add(this.btnBrowseImportDir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbOutputDirectory);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 82);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "第一步：选择输入和输出图片目录";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbOutputFormat);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbTargetHeightPixels);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbTargetWidthPixels);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 52);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "第二步：选择输出图片的大小和输出格式";
            // 
            // cbOutputFormat
            // 
            this.cbOutputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOutputFormat.FormattingEnabled = true;
            this.cbOutputFormat.Items.AddRange(new object[] {
            "JPG"});
            this.cbOutputFormat.Location = new System.Drawing.Point(494, 20);
            this.cbOutputFormat.Name = "cbOutputFormat";
            this.cbOutputFormat.Size = new System.Drawing.Size(121, 20);
            this.cbOutputFormat.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "输出格式：";
            // 
            // tbTargetHeightPixels
            // 
            this.tbTargetHeightPixels.Location = new System.Drawing.Point(298, 20);
            this.tbTargetHeightPixels.Name = "tbTargetHeightPixels";
            this.tbTargetHeightPixels.Size = new System.Drawing.Size(100, 21);
            this.tbTargetHeightPixels.TabIndex = 9;
            this.tbTargetHeightPixels.Text = "250";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "高（像素）：";
            // 
            // tbTargetWidthPixels
            // 
            this.tbTargetWidthPixels.Location = new System.Drawing.Point(96, 20);
            this.tbTargetWidthPixels.Name = "tbTargetWidthPixels";
            this.tbTargetWidthPixels.Size = new System.Drawing.Size(100, 21);
            this.tbTargetWidthPixels.TabIndex = 7;
            this.tbTargetWidthPixels.Text = "250";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "长（像素）：";
            // 
            // logBox
            // 
            this.logBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logBox.Location = new System.Drawing.Point(12, 158);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(747, 200);
            this.logBox.TabIndex = 7;
            this.logBox.Text = "";
            // 
            // btnCut
            // 
            this.btnCut.Location = new System.Drawing.Point(684, 364);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(75, 23);
            this.btnCut.TabIndex = 8;
            this.btnCut.Text = "开始裁剪";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.BtnCut_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 397);
            this.Controls.Add(this.btnCut);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "批量图片裁剪";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInputDirectory;
        private System.Windows.Forms.Button btnBrowseImportDir;
        private System.Windows.Forms.TextBox tbOutputDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowseOuput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTargetWidthPixels;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTargetHeightPixels;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbOutputFormat;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.FolderBrowserDialog dirBrowser;
    }
}

