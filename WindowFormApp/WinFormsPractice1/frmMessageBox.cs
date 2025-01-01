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
    public partial class frmMessageBox : Form
    {
        public frmMessageBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you Sure ?", "Confirmation");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you Sure ?","Confirmation", MessageBoxButtons.OKCancel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you Sure ?", "Confirmation", MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                MessageBox.Show("The operation is done!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure ?", "Confirmation", MessageBoxButtons.OKCancel,MessageBoxIcon.Stop,MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                MessageBox.Show("The operation is done!!");
            }
            else
            {
                MessageBox.Show("The operation cancelled");
            }
        }
    }
}
