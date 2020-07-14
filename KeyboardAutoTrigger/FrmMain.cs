using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KeyboardAutoTrigger
{
    public partial class FrmMain : Form
    {
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        private Keys _keyToBeTrigged;
        private int _countDownValue;
        private int _timerValue;
        private int _timeRandomDelta;
        private bool _timeDeltaEnabled;

        private readonly Random _random;

        public FrmMain()
        {
            _random = new Random();

            InitializeComponent();

            UpdateKeyToBeTrigged(Keys.A);
            _countDownValue = 0;
            _timerValue = 0;
            _timeRandomDelta = 0;
            _timeDeltaEnabled = false;
        }

        private void UpdateKeyToBeTrigged(Keys key)
        {
            _keyToBeTrigged = key;
            lbKeys.Text = $"要触发的按键：{key.ToString()}";
        }

        private void CbRandomTimeDelta_CheckedChanged(object sender, EventArgs e)
        {
            tbTimeDelta.Enabled = cbRandomTimeDelta.Checked;
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            _countDownValue--;
            if (_countDownValue == 0)
            {
                // 触发按键事件
                keybd_event((byte)_keyToBeTrigged, 0, 0, 0);
                keybd_event((byte)_keyToBeTrigged, 0, 2, 0);

                // 重新计算下次的时间间隔
                if (_timeDeltaEnabled)
                {
                    int value = _random.Next(_timeRandomDelta);
                    int negativeFix = _random.NextDouble() > 0.5 ? 1 : -1;

                    _countDownValue = _timerValue + (value * negativeFix);
                }
                else
                {
                    _countDownValue = _timerValue;
                }
            }

            lbTimeCountdown.Text = IntToTimeString(_countDownValue);
        }

        private string IntToTimeString(int second)
        {
            int hour = second / 3600;
            int minute = (second / 60) - (hour * 60);
            int sec = second % 60;

            return $"{hour:00}:{minute:00}:{sec:00}";
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            _timerValue = (int)((counterHour.Value * 3600) + (counterMinute.Value * 60) + counterSecond.Value);
            _countDownValue = _timerValue;
            lbTimeCountdown.Text = IntToTimeString(_timerValue);

            if (_timerValue == 0)
            {
                MessageBox.Show("触发间隔必须大于 0", "KeyboardAutoTrigger", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbRandomTimeDelta.Checked && (!int.TryParse(tbTimeDelta.Text, out _timeRandomDelta) || _timeRandomDelta <= 0))
            {
                MessageBox.Show("随机触发间隔的误差必须为大于 0 的正整数",
                    "KeyboardAutoTrigger", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_timeRandomDelta > _timerValue)
            {
                MessageBox.Show("随机间隔的误差不得大于正常的时间间隔", "KeyboardAutoTrigger", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _timeDeltaEnabled = cbRandomTimeDelta.Checked;

            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnKeyChooser.Enabled = false;

            SettingControlEnabled(false);
            SetStartStatus();
            mainTimer.Enabled = true;
        }

        private void SettingControlEnabled(bool enabled)
        {
            counterHour.Enabled = enabled;
            counterMinute.Enabled = enabled;
            counterSecond.Enabled = enabled;
            cbRandomTimeDelta.Enabled = enabled;
            tbTimeDelta.Enabled = enabled & cbRandomTimeDelta.Checked;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnKeyChooser.Enabled = true;
            btnStop.Enabled = false;
            mainTimer.Enabled = false;

            _countDownValue = 0;
            lbTimeCountdown.Text = "00:00:00";
            SetStopStatus();
            SettingControlEnabled(true);
        }

        private void SetStartStatus()
        {
            SetStatusLabel(Color.Lime, Color.Black, "工作中");
        }

        private void SetStopStatus()
        {
            SetStatusLabel(Color.Gold, Color.Black, "就绪状态");
        }

        private void SetStatusLabel(Color backColor, Color foreColor, string text)
        {
            lbStatus.BackColor = backColor;
            lbStatus.ForeColor = foreColor;
            lbStatus.Text = text;
        }

        private void BtnKeyChooser_Click(object sender, EventArgs e)
        {
            FrmKeyChooser chooser = new FrmKeyChooser();
            DialogResult result = chooser.ShowDialog();
            if (result == DialogResult.OK)
            {
                UpdateKeyToBeTrigged(chooser.SelectedKey);
            }
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Input
    {
        [FieldOffset(0)] public int type;
        [FieldOffset(4)] public tagKEYBDINPUT ki;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagKEYBDINPUT
    {
        public short wVk;
        public short wScan;
        public int dwFlags;
        public int time;
        public IntPtr dwExtraInfo;
    }
}
