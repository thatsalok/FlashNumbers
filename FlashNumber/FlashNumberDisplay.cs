using FlashNumber.Business;
using System;
using System.ComponentModel;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace FlashNumber
{
    public partial class FlashNumberDisplay : Form
    {
        public FlashNumberDisplay()
        {
            InitializeComponent();
        }

        internal FormTypes FormType { get; set; }
        public IFlashNumbers FlashNumbers { get; set; }
        System.Threading.Timer TheTimer = null;
        SpeechSynthesizer _speechSynthesizer = null;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Configure the audio output. 
            _speechSynthesizer = new SpeechSynthesizer();
            _speechSynthesizer.SetOutputToDefaultAudioDevice();
            lblNumber.Text = "***";
            txtAnswer.Text = "";
            ProvideFlashNumberMemory(FormType);

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            if (_speechSynthesizer != null)
            {
                _speechSynthesizer.Dispose();
                _speechSynthesizer = null;
            }

        }

        private void StartGame()
        {
            RestructureForm(true);
            TheTimer = new System.Threading.Timer(this.Tick, null, 0, 1000 * FlashNumbers.Intervals);
        }

        private void RestructureForm(bool flag)
        {
            scPanels.Panel1Collapsed = !flag;
            scPanels.Panel2Collapsed = flag;

            grpEndGame.Visible = true;
        }

        public void Tick(object info)
        {
            this.Invoke((Action)this.UpdateCountdown);
        }

        private void UpdateCountdown()
        {
            string displaytext = string.Empty;

            if (!FlashNumbers.GetNextNumber(out displaytext))
            {
                if (TheTimer != null)
                {
                    TheTimer.Dispose();
                    TheTimer = null;
                }
                //Display information
                RestructureForm(false);
                return;
            }
            this.toolStripNoIoFAttempts.Text = $"Count : {FlashNumbers.NoofAttempt} / {FlashNumbers.NoOfTimes}";
            this.lblNumber.Text = displaytext;
            // Speak a string.
            _speechSynthesizer.SpeakAsync(displaytext);

        }


        private void ProvideFlashNumberMemory(FormTypes formType)
        {
            if (FlashNumbers == null) return;
            FlashNumbers.GenerateRanges();
        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            if (!FlashNumbers.CheckAnswer(txtAnswer.Text))
                MessageBox.Show($"Your answer is incorrect, The correct answer is {FlashNumbers.CalculateResult()} \n Set of numbers shown are [{FlashNumbers.SetOfNumber()}]");
            else
                MessageBox.Show($"Wow! answer is correct, \n Set of numbers shown are [{FlashNumbers.SetOfNumber()}]");
        }

        private void btnStartAgain_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            lblNumber.Text = "***";
            txtAnswer.Text = "";
            FlashNumbers.Reset();
            RestructureForm(true);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartGame();
            btnStart.Enabled = false;
        }
    }

}
