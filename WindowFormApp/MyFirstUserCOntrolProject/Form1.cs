using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstUserCOntrolProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResult2.Text = ((int)Convert.ToInt32(crtlSimpleCalc1.Result) + int.Parse(txtBox3.Text)).ToString();
        }

        private void btnShowForm2_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(lblResult2.Text, out int Sum2))
            {
                // Parsing successful, use integerValue
                Form2 frm2 = new Form2(Sum2);
                frm2.Show();
            }
            else
            {
                // Parsing failed
                Console.WriteLine("Invalid number format");
            }
        }
    }


}
