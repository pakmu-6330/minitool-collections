using BatchImageCuttor.Presentor;
using BatchImageCuttor.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchImageCuttor
{
    public partial class FrmMain : Form, IBatchImageCutterView
    {
        private static ImageFormat[] FORMAT = new ImageFormat[] { ImageFormat.Jpeg };

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            cbOutputFormat.SelectedIndex = 0;
        }

        private void BtnBrowseImportDir_Click(object sender, EventArgs e)
        {
            DialogResult result = dirBrowser.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            tbInputDirectory.Text = dirBrowser.SelectedPath;
        }

        private void BtnBrowseOuput_Click(object sender, EventArgs e)
        {
            DialogResult result = dirBrowser.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            tbOutputDirectory.Text = dirBrowser.SelectedPath;
        }

        private void ClearLogBox()
        {
            Invoke(new Action(() =>
            {
                logBox.Text = "";
            }));
        }

        public void BatchBegin()
        {
            Invoke(new Action(() =>
            {
                logBox.AppendText("开始裁剪...\r\n");
            }));
        }

        public void BeginFile(string file, int index, int total)
        {
            Invoke(new Action(() =>
            {
                logBox.AppendText($"({index + 1} / {total}) 开始裁剪文件：{file}\r\n");
            }));
        }

        public void FinishFile(string file, int index, int total)
        {
            Invoke(new Action(() =>
            {
                logBox.AppendText($"({index + 1} / {total}) 完成裁剪文件：{file}\r\n");
            }));
        }

        public void FailFile(string file, string cause, int index, int total)
        {
            Invoke(new Action(() =>
            {
                logBox.AppendText($"{index + 1} / {total} 裁剪文件 '{file}' 遇到错误：{cause}\r\n");
            }));
        }

        public void BatchFinish()
        {
            Invoke(new Action(() =>
            {
                logBox.AppendText("批量文件裁剪完成\r\n");
            }));
        }

        public void PrintCheckError(string errorMsg)
        {
            Invoke(new Action(() =>
            {
                logBox.AppendText($"参数错误：{errorMsg}\r\n");
            }));
        }

        public void PrintErrorMessage(string errorMsg)
        {
            Invoke(new Action(() =>
            {
                logBox.AppendText($"错误：{errorMsg}\r\n");
            }));
        }

        private void ControlEnabled(bool enabled)
        {
            Invoke(new Action(() =>
            {
                tbInputDirectory.Enabled = enabled;
                btnBrowseImportDir.Enabled = enabled;
                tbOutputDirectory.Enabled = enabled;
                btnBrowseOuput.Enabled = enabled;

                tbTargetWidthPixels.Enabled = enabled;
                tbTargetHeightPixels.Enabled = enabled;
                cbOutputFormat.Enabled = enabled;
            }));
        }

        private void BtnCut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbInputDirectory.Text))
            {
                MessageBox.Show("输入目录不能为空", "cutter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbOutputDirectory.Text))
            {
                MessageBox.Show("输出目录不能为空", "cutter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(tbTargetWidthPixels.Text, out int width) || width <= 0)
            {
                MessageBox.Show("输出图片宽度必须为正整数", "cutter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(tbTargetHeightPixels.Text, out int height) || height <= 0)
            {
                MessageBox.Show("输出图片高度必须为正整数", "cutter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BatchImageCutterPresentor presentor = new BatchImageCutterPresentor(this)
            {
                InputDirectory = tbInputDirectory.Text,
                OutputDirectory = tbOutputDirectory.Text,
                OutputWidth = width,
                OutputHeight = height,
                OutputFormat = FORMAT[cbOutputFormat.SelectedIndex]
            };
            presentor.Begin();
        }

        public void BeginProcess()
        {
            Invoke(new Action(() =>
            {
                ControlEnabled(false);
            }));
        }

        public void EndProcess()
        {
            Invoke(new Action(() =>
            {
                ControlEnabled(true);
            }));
        }
    }
}
