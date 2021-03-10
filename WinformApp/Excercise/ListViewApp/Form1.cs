using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewItem ItemSwitch = new ListViewItem("Nintendo Switch", 0);
            ItemSwitch.SubItems.Add("600,000");
            ItemSwitch.SubItems.Add("10");
            ItemSwitch.SubItems.Add("6,000,000");

            ListViewItem ItemDs = new ListViewItem("Nintendo DS", 1);
            ItemDs.SubItems.Add("300,000");
            ItemDs.SubItems.Add("50");
            ItemDs.SubItems.Add("15,000,000");

            ListViewItem ItemPs = new ListViewItem("PlayStation 4", 2);
            ItemPs.SubItems.Add("400,000");
            ItemPs.SubItems.Add("10");
            ItemPs.SubItems.Add("4,000,000");

            ListViewItem ItemWii = new ListViewItem("Nintendo Wii", 3);
            ItemWii.SubItems.Add("200,000");
            ItemWii.SubItems.Add("30");
            ItemWii.SubItems.Add("6,000,000");

            ListViewItem ItemXbox = new ListViewItem("XBox", 4);
            ItemXbox.SubItems.Add("700,000");
            ItemXbox.SubItems.Add("20");
            ItemXbox.SubItems.Add("14,000,000");


            LsvProduct.Items.AddRange(new ListViewItem[] { ItemSwitch, ItemDs, ItemPs, ItemWii, ItemXbox });
        
        }

        private void RdbDetail_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbDetail.Checked) LsvProduct.View = View.Details;
        }

        private void RdbList_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbList.Checked) LsvProduct.View = View.List;
        }

        private void RdbSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbSmall.Checked) LsvProduct.View = View.SmallIcon;
        }

        private void RdbLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbLarge.Checked) LsvProduct.View = View.LargeIcon;
        }

        private void LsvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtSelected.Text = string.Empty;

            var selected = LsvProduct.SelectedItems;

            foreach (ListViewItem item in selected)
            {
                for (int i = 0; i < 4; i++)
                {
                    TxtSelected.Text = item.SubItems[i].Text + " ";
                }
            }
        }
    }
}
