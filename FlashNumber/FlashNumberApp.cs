using FlashNumber.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashNumber
{
    public partial class FlashNumberApp : Form
    {
        public FlashNumberApp()
        {
            InitializeComponent();
        }

        private  void InvokeFlashForm(FormTypes formTypes)
        {
            IFlashNumbers flashNumbers = FlashNumberBusinessFactory.GetFlashNumbersObject(formTypes);
            if(flashNumbers == null)
            {
                MessageBox.Show("Feature not available");
                return;
            }

            if (flashNumbers.ShowConfigurationDialog)
            {
                FlashNumbersConfiguration flashNumberConfiguation = new FlashNumbersConfiguration();
                flashNumberConfiguation.FlashNumberObject = flashNumbers;
                if (flashNumberConfiguation.ShowDialog() != DialogResult.OK) return;
                flashNumbers.NoOfDigits = flashNumberConfiguation.NoOfDigit;
                flashNumbers.NoOfTimes = flashNumberConfiguation.NoOfSum;
                flashNumbers.Intervals = flashNumberConfiguation.Interval;
            }

            FlashNumberDisplay flashNumberDisplay = new FlashNumberDisplay();
            flashNumberDisplay.FlashNumbers = flashNumbers;
            flashNumberDisplay.ShowDialog();
        }

       
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright: Ankit Agarwal, Developed By Alok Gupta");
        }


        private void btnAddition_Click(object sender, EventArgs e)
        {
            InvokeFlashForm(FormTypes.Addition);
        }

        private void btnAddSub_Click(object sender, EventArgs e)
        {
            InvokeFlashForm(FormTypes.AdditionSubration);
        }

        private void btnDecimalAddSub_Click(object sender, EventArgs e)
        {
            InvokeFlashForm(FormTypes.DecimalAddSub);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            InvokeFlashForm(FormTypes.Multiply);
        }

        private void btnLongMultiply_Click(object sender, EventArgs e)
        {
            InvokeFlashForm(FormTypes.LongMultiply);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            InvokeFlashForm(FormTypes.Division);
        }
    }
}
