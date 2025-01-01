using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPractice4
{
    public partial class frmDialogs : Form
    {
        public frmDialogs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (colorDialog1.ShowDialog()== DialogResult.OK)
            {
                txtBox1.BackColor = colorDialog1.Color; 
                this.BackColor = colorDialog1.Color;
               
            }
        }

        private void btnChangeForeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBox1.ForeColor = colorDialog1.Color;
                this.ForeColor = colorDialog1.Color;
            }
        }

        private void frmDialogs_Load(object sender, EventArgs e)
        {
            btnChangeBackColor.Focus();
        }

        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;           
            fontDialog1.ShowEffects = true;
            fontDialog1.ShowApply = true;
            fontDialog1.ShowHelp = true;
            fontDialog1.Font = txtBox1.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBox1.Font = fontDialog1.Font;
                txtBox1.ForeColor = fontDialog1.Color;
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            txtBox1.Font = fontDialog1.Font;
            txtBox1.ForeColor = fontDialog1.Color;
        }

        private void btnSaveFileDialog_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"Desktop";
            saveFileDialog1.Title = "My First File";
            saveFileDialog1.DefaultExt = "txt";
           // saveFileDialog1.Filter = "txt files (*.txt)|*.txt | All files(*.*)|*.*";
            saveFileDialog1.Filter = "All files(*.*)|*.* | txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                MessageBox.Show(saveFileDialog1.FileName);
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"Desktop";
            openFileDialog1.Title = "My first open file";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files(*.txt)|*.txt | All files(*.*)|*.*";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName);
            }
        }

        private void btnOpenFileDialogMulti_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog1.FileNames)
                {
                    MessageBox.Show(file);
                }
            }
        }

        private void btnFolderBrowserDialog_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowNewFolderButton = true;
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(folderBrowserDialog1.SelectedPath);
            }
        }
    }
}
