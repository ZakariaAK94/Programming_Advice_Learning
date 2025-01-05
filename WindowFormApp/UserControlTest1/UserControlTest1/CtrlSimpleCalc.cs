using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlTest1
{
    public partial class CtrlSimpleCalc : UserControl
    {
        public event Action<int> OnCalculationComplete;

        protected virtual void CalculationComplete(int Result)
        {
            Action<int> handler = OnCalculationComplete;
            if(handler != null)
            {
                handler(Result);
            }
        }
        public CtrlSimpleCalc()
        {
            InitializeComponent();
        }
        
        public float Result 
        {
            get
            {
                //return int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
                return (float)Convert.ToDouble(label2.Text);    
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();
            if (OnCalculationComplete != null)
                CalculationComplete(int.Parse(textBox1.Text) + int.Parse(textBox2.Text));
        }
    }
}
