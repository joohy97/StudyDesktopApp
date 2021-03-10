using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSelApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CboRes.Items.AddRange(new string[]
            {
                "히노아지", "스시야마", "퍼지네이블", "새마을식당", "홍콩반점", "롤링파스타"
            });
        }

        private void CboRes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selitem = sender as ComboBox;
            LblResult.Text = "이번 주 모임장소 : " + selitem.SelectedItem;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (CboRes.Text != "")
            {
                CboRes.Items.Add(CboRes.Text);
               
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (CboRes.SelectedIndex > -1)
            {
                CboRes.Items.Remove(CboRes.SelectedItem);
            }
        }
    }
}
