using System;
using System.Windows.Forms;

namespace FlashNumber
{
    public partial class FlashNumbersConfiguration : Form
    {
        public FlashNumbersConfiguration()
        {
            InitializeComponent();
        }

        internal Business.IFlashNumbers FlashNumberObject { get; set; }
        public int NoOfDigit { get; internal set; }
        public int NoOfSum { get; internal set; }
        public int Interval { get; internal set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            txtNumberOfTime.Enabled = FlashNumberObject.NoOfTimesEnabled;
            txtNumberOfDigit.Enabled = FlashNumberObject.NoOfDigitsEnabled;

            if (!FlashNumberObject.NoOfDigitsEnabled)
                this.txtNumberOfDigit.Value = FlashNumberObject.NoOfDigits;

            if (!FlashNumberObject.NoOfTimesEnabled)
                this.txtNumberOfTime.Value = FlashNumberObject.NoOfTimes;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            NoOfDigit = (int)this.txtNumberOfDigit.Value;
            NoOfSum = (int)this.txtNumberOfTime.Value;
            Interval = (int)this.txtInterval.Value;
            this.DialogResult = DialogResult.OK;
        }
    }
}
