using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPractice1
{
    public partial class frmChkRadioGroup : Form
    {
        public frmChkRadioGroup()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           btnSubmit.Enabled = chkConfirmationRules.Checked;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(chkConfirmationRules.Checked.ToString());
        }

        private void btnHideGrBox_Click(object sender, EventArgs e)
        {
            gbCrust.Visible = false;
        }

        private void btnShowChoice_Click(object sender, EventArgs e)
        {
            if(rdLarge.Checked)
            {
                MessageBox.Show("Your choice is " + rdLarge.Text);
            }else if(rdSmall.Checked)
            {
                MessageBox.Show("Your choice is " + rdSmall.Text);
            }else
            {
                MessageBox.Show("Your choice is " + rdMedium.Text);
            }

           
        }

        private void rdSmall_CheckedChanged(object sender, EventArgs e)
        {
            btnShowChoice.Enabled = true;
        }

        private void rdMedium_CheckedChanged(object sender, EventArgs e)
        {
            btnShowChoice.Enabled = true;
        }

        private void rdLarge_CheckedChanged(object sender, EventArgs e)
        {
            btnShowChoice.Enabled = true;
        }
    }
}
