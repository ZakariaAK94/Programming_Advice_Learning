using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPractice7
{
    public partial class frmTrackBar : Form
    {
        public frmTrackBar()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblTrackBar.Font = new Font(lblTrackBar.Font.FontFamily, trackBar1.Value);
            pb1Image.Size = new Size(trackBar1.Value,trackBar1.Value);
            lblTrackBar.Text = trackBar1.Value.ToString();
            //if(colorDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    lblTrackBar.BackColor = colorDialog1.Color;
            //}
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pb1Image.Size = new Size((int)numericUpDown1.Value,(int)numericUpDown1.Value);
            lblTrackBar.Font = new Font("Mistral", (int)numericUpDown1.Value);
        }
    }
}
