using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsPractice2.Properties;

namespace WinFormsPractice2
{
    public partial class frmImageTest : Form
    {
        public frmImageTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Boy;
            rbBoy.Checked = true;
            rbBoy.BackColor = Color.Yellow;
            // we can apply this method
            lblTitle.Text =  btnBoy.Tag.ToString();
            rbGirl.BackColor = frmImageTest.DefaultBackColor;
            rbPen.BackColor = frmImageTest.DefaultBackColor;
            rbBook.BackColor = frmImageTest.DefaultBackColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Girl;
            rbGirl.Checked = true;
            rbGirl.BackColor = Color.Brown;
            //we can apply this method
            lblTitle.Text = btnGirl.Text;
            rbBoy.BackColor = frmImageTest.DefaultBackColor;
            rbPen.BackColor = frmImageTest.DefaultBackColor;
            rbBook.BackColor = frmImageTest.DefaultBackColor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Pen;
            rbPen.Checked = true;
            rbPen.BackColor = Color.Violet;
            lblTitle.Text = btnPen.Text;
            rbGirl.BackColor = frmImageTest.DefaultBackColor;
            rbBoy.BackColor = frmImageTest.DefaultBackColor;
            rbBook.BackColor = frmImageTest.DefaultBackColor;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Book;
            rbBook.Checked = true;
            rbBook.BackColor = Color.AntiqueWhite;
            lblTitle.Text = btnBook.Text;
            rbBoy.BackColor = frmImageTest.DefaultBackColor;
            rbPen.BackColor = frmImageTest.DefaultBackColor;
            rbGirl.BackColor = frmImageTest.DefaultBackColor;
        }

        private void rbBoy_CheckedChanged(object sender, EventArgs e)
        {
            btnBoy.BackColor= Color.Yellow;
            //we can apply this method
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();
            lblTitle.BackColor = Color.Yellow;
            btnGirl.BackColor = frmImageTest.DefaultBackColor;   
            btnPen.BackColor = frmImageTest.DefaultBackColor;   
            btnBook.BackColor = frmImageTest.DefaultBackColor;   
        }

        private void rbGirl_CheckedChanged(object sender, EventArgs e)
        {
            btnGirl.BackColor = Color.Brown;
            lblTitle.Text = btnGirl.Text;
            lblTitle.BackColor = Color.Brown;
            btnBoy.BackColor = frmImageTest.DefaultBackColor;
            btnPen.BackColor = frmImageTest.DefaultBackColor;
            btnBook.BackColor = frmImageTest.DefaultBackColor;
        }

        private void rbPen_CheckedChanged(object sender, EventArgs e)
        {
            btnPen.BackColor = Color.Violet;
            lblTitle.Text = btnPen.Text;
            lblTitle.BackColor = Color.Violet;
            btnGirl.BackColor = frmImageTest.DefaultBackColor;
            btnBoy.BackColor = frmImageTest.DefaultBackColor;
            btnBook.BackColor = frmImageTest.DefaultBackColor;
        }

        private void rbBook_CheckedChanged(object sender, EventArgs e)
        {
            btnBook.BackColor = Color.AntiqueWhite;
            lblTitle.Text = btnBook.Text;
            lblTitle.BackColor = Color.AntiqueWhite;
            btnGirl.BackColor = frmImageTest.DefaultBackColor;
            btnBoy.BackColor = frmImageTest.DefaultBackColor;
            btnPen.BackColor = frmImageTest.DefaultBackColor;
        }

        private void frmImageTest_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Girl");
            comboBox1.Items.Add("Boy");
            comboBox1.Items.Add("Pen");
            comboBox1.Items.Add("Book");
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.ToString().Trim() == "Girl")
            {
                pictureBox1.Image = Resources.Girl;
                return;
            }
            else if (comboBox1.Text.ToString().Trim() == "Boy")
            {
                pictureBox1.Image = Resources.Boy;
                return;
            }
            else if (comboBox1.Text.ToString().Trim() == "Book")
            {
                pictureBox1.Image = Resources.Book;
                return;
            }
            else if (comboBox1.Text.ToString().Trim() == "Pen")
            {
                pictureBox1.Image = Resources.Pen;
                return;
            }

            switch (comboBox1.SelectedItem.ToString().ToLower())
            {
                case "boy":
                    pictureBox1.Image = Resources.Boy;
                    lblTitle.Text = "Boy";
                    break;
                case "girl":
                    pictureBox1.Image = Resources.Girl;
                    lblTitle.Text = "Girl";
                    break;
                case "book":
                    pictureBox1.Image = Resources.Book;
                    lblTitle.Text = "Book";
                    break;
                case "pen":
                    pictureBox1.Image = Resources.Pen;
                    lblTitle.Text = "Pen";
                    break;
            }

        }
    }
}
