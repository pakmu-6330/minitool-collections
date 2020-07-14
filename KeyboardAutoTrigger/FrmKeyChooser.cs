using System;
using System.Windows.Forms;

namespace KeyboardAutoTrigger
{
    public partial class FrmKeyChooser : Form
    {
        public Keys SelectedKey { get; private set; }

        public FrmKeyChooser()
        {
            InitializeComponent();

            DialogResult = DialogResult.Cancel;
        }

        private void SelectKey(Keys key)
        {
            SelectedKey = key;
            DialogResult = DialogResult.OK;

            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnQ_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.Q);
        }

        private void BtnW_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.W);
        }

        private void BtnE_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.E);
        }

        private void BtnR_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.R);
        }

        private void BtnT_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.T);
        }

        private void BtnY_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.Y);
        }

        private void BtnU_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.U);
        }

        private void BtnI_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.I);
        }

        private void BtnO_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.O);
        }

        private void BtnP_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.P);
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.A);
        }

        private void BtnS_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.S);
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.D);
        }

        private void BtnF_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.F);
        }

        private void BtnG_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.G);
        }

        private void BtnH_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.H);
        }

        private void BtnJ_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.J);
        }

        private void BtnK_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.K);
        }

        private void BtnL_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.L);
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.Enter);
        }

        private void BtnZ_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.Z);
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.X);
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.C);
        }

        private void BtnV_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.V);
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.B);
        }

        private void BtnN_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.N);
        }

        private void BtnM_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.M);
        }

        private void BtnSpace_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.Space);
        }

        private void BtnKey1_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.D1);
        }

        private void BtnKey2_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.D2);
        }

        private void BtnKey3_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.D3);
        }

        private void BtnKey4_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.D4);
        }

        private void BtnKey5_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.D5);
        }

        private void BtnKey6_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.D6);
        }

        private void BtnKey7_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.D7);
        }

        private void BtnKey8_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.D8);
        }

        private void BtnKey9_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.D9);
        }

        private void BtnKey0_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.D0);
        }

        private void BtnNum7_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.NumPad7);
        }

        private void BtnNum8_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.NumPad8);
        }

        private void BtnNum9_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.NumPad9);
        }

        private void BtnNum4_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.NumPad4);
        }

        private void BtnNum5_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.NumPad5);
        }

        private void BtnNum6_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.NumPad6);
        }

        private void BtnNum1_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.NumPad1);
        }

        private void BtnNum2_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.NumPad2);
        }

        private void BtnNum3_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.NumPad3);
        }

        private void BtnNum0_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.NumPad0);
        }

        private void BtnNumLock_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.NumLock);
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.Up);
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.Down);
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.Right);
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.Left);
        }

        private void BtnPrevTrack_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.MediaPreviousTrack);
        }

        private void BtnPlayPause_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.MediaPlayPause);
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.MediaStop);
        }

        private void BtnNextTrack_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.MediaNextTrack);
        }

        private void BtnVolPlus_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.VolumeUp);
        }

        private void BtnVolMinus_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.VolumeDown);
        }

        private void BtnMute_Click(object sender, EventArgs e)
        {
            SelectKey(Keys.VolumeMute);
        }
    }
}
