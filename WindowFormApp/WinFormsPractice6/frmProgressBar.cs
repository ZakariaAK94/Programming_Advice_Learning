using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace WinFormsPractice6
{
    public partial class frmProgressBar : Form
    {
        public frmProgressBar()
        {
            InitializeComponent();
        }

        private void btnIncreaseProgressBar_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;   

            for(int i=0; i < 10; i++)
            {
                if(progressBar1.Value< progressBar1.Maximum)
                {
                   Thread.Sleep(500);
                    progressBar1.Value += 10;
                    label1.Text = (((float)(progressBar1.Value / progressBar1.Maximum)) * 100) + "%";
                    progressBar1.Refresh();
                    label1.Refresh();
                }
                else
                {
                    btnIncreaseProgressBar.Enabled = false;
                }
            }
        }

        private void btnResetProgressBar_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            label1.Text = "0%";
        }
    }
}
