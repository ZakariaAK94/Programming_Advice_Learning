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
    public partial class Form2 : Form
    {
        private int _SumOfNumber;
        public Form2(int ValidNumber)
        {
            InitializeComponent();
            _SumOfNumber = ValidNumber;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblForm2.Text = _SumOfNumber.ToString();
            
        }
    }
}
