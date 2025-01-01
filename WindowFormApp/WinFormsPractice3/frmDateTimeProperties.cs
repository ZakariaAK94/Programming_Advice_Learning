using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject1
{
    public partial class frmDateTimeProperties : Form
    {
        public frmDateTimeProperties()
        {
            InitializeComponent();
        }

        private int Counter=0;

        private void btnShortDateString_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToShortDateString());
        }

        private void btnLongDateString_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToLongDateString());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Text + Environment.NewLine; // is like \n in C++
            label1.Text += dateTimePicker1.Value.ToString("dd-MMM-yyyy") + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("dddd-MMM-yyyy") + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("MM-dd-yyyy") + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("dd/MMM/yy") + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("dddd, dd-MMM-yyyy") + Environment.NewLine;
        }

        private void btnSelectRange_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionRange.ToString());
        }

        private void btnSelectStartRange_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionStart.ToShortDateString());
        }

        private void btnSelectEndRange_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionEnd.ToShortDateString());
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Counter++;
            label2.Text = Counter.ToString();
        }

        private void btnShowIcon_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
            notifyIcon1.BalloonTipText = "this is a message";
            notifyIcon1.BalloonTipTitle = "This is a Title";
            notifyIcon1.ShowBalloonTip(1000);

        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            MessageBox.Show("I will be the best programmer in the world!!");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Counter = 0;
        }
    }
}
