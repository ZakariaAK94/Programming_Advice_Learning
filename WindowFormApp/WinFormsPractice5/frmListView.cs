using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPractice5
{
    public partial class frmListView : Form
    {
        private Random random = new Random();
        public frmListView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("ID number or Name is missing", "Missing Information",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                return;
            }
            ListViewItem item = new ListViewItem(txtID.Text.Trim(),rbMale.Checked ?  0 :  1);
            
            item.SubItems.Add(txtFirstName.Text.Trim());
            item.SubItems.Add(txtLastName.Text.Trim());            
            item.SubItems.Add(cmbAge.SelectedItem.ToString());
            item.SubItems.Add(cmbJobTitle.SelectedItem.ToString());
            item.SubItems.Add(txtSalary.Text.Trim());            
           
            listView1.Items.Add(item);

            txtID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();  
            txtSalary.Clear();  
            cmbAge.Items.Clear();  
            cmbJobTitle.Items.Clear();  
            txtID.Focus();  

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }else
            {
                MessageBox.Show("The list is empty");
            }
            btnRemove.Enabled = false;
        }

        private void btnFillRandom_Click(object sender, EventArgs e)
        {
            int CuurentRecords = listView1.Items.Count + 1;
            for (int i= CuurentRecords; i <= CuurentRecords+ 10; i++)
            {
                ListViewItem item = new ListViewItem(i.ToString());
                if (i%2==0)
                    item.ImageIndex = 0;
                else
                    item.ImageIndex = 1;
                int randomNumberJob = random.Next(1,10); 
                int randomNumberAge = random.Next(10,70); 
                item.SubItems.Add("Person" + i);               
                item.SubItems.Add("Person" + i*10);
                item.SubItems.Add(cmbAge.Items[randomNumberAge].ToString());
                item.SubItems.Add(cmbJobTitle.Items[randomNumberJob].ToString());
                item.SubItems.Add((i*1500).ToString());
                listView1.Items.Add(item);              
            }
        }

        private void rbLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void rbSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void rbDetails_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void rbList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void rbTile_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = true;
        }
    }
}
