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
    public partial class crtlSimpleCalc : UserControl
    {
        public crtlSimpleCalc()
        {
            InitializeComponent();
        }

        public float Result // property
        {
            get
            {
                return (float)Convert.ToDouble(lblResult.Text); // get method
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            lblResult.Text = (int.Parse(txtBox1.Text)+int.Parse(txtBox2.Text)).ToString();

        }
    }
}
