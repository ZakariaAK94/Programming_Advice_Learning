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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Result = "The result for calc1 is " + ctrlSimpleCalc1.Result.ToString() +
                             " for calc2 is " + ctrlSimpleCalc2.Result.ToString() +
                             " for calc3 is " + ctrlSimpleCalc3.Result.ToString();
            MessageBox.Show(Result);
        }

        private void ctrlSimpleCalc1_OnCalculationComplete(int obj)
        {
            int Result = obj;

            MessageBox.Show("Calculation 1 is completed, the result is " + Result.ToString(), "Notification", MessageBoxButtons.OK);
        }

        private void ctrlSimpleCalc3_OnCalculationComplete(int obj)
        {
            int Result = obj;

            MessageBox.Show("Calculation 3 is completed, the result is " + Result.ToString(), "Notification", MessageBoxButtons.OK);

        }

        private void ctrlSimpleCalc2_OnCalculationComplete(int obj)
        {
            int Result = obj;

            MessageBox.Show("Calculation 2 is completed, the result is " + Result.ToString(), "Notification", MessageBoxButtons.OK);


        }
    }
}
