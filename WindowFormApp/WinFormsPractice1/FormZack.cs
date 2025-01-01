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
    public partial class FormZack : Form
    {
        public FormZack()
        {
            InitializeComponent();
        }

        private void btnShowPart1_Click(object sender, EventArgs e)
        {
            Form frm = new Form1();
            frm.Show();
        }

        private void btnShowForm1Dialog_Click(object sender, EventArgs e)
        {
            Form frm = new Form1();
            frm.ShowDialog();
        }

        private void btnShowMessageBox_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmMessageBox();
            frm1.ShowDialog();
        }

        private void btnCheckBoxRadioGroup_Click(object sender, EventArgs e)
        {
            Form frm3 = new frmChkRadioGroup();
            frm3.ShowDialog();
        }
    }
}
