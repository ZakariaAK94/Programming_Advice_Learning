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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisabletxtBox2_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
        }
        private void btnEnabletxtBox2_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void btnChangeColorToGreen_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;
            textBox2.ForeColor = Color.Green;
        }

        private void btnChangeColorToBlack_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
            textBox2.ForeColor = Color.Black;
        }

        private void Mouse_Enter(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text;
            textBox2.Text = "";
        }


        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            label1.Text = textBox1.Text;
        }

        private void btnHideTextBox1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }

        private void btnShowTextBox1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangeFormTitle_Click(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;
        }
    }
}
