using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelWishApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LsbWish.Items.AddRange(new string[] {
                "오스트리아, 빈", "호주, 멜버른", "일본, 오사카", "캐나다, 캘거리", "호주, 시드니", "캐나다, 밴쿠버", "일본, 도쿄"
            });
            LsbResult.SelectionMode = SelectionMode.MultiExtended;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            foreach (var item in LsbWish.CheckedItems)
            {
                LsbResult.Items.Add(item);
            }
        }

        private void BtnAddAll_Click(object sender, EventArgs e)
        {
            LsbResult.Items.Clear();
            foreach (var item in LsbWish.Items)
            {
                LsbResult.Items.Add(item);
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            List<string> listremove = new List<string>();

            foreach (string item in LsbResult.SelectedItems)
            {
                listremove.Add(item);
            }

            foreach (var city in listremove)
            {
                LsbResult.Items.Remove(city);
            }
        }

        private void BtnRemoveAll_Click(object sender, EventArgs e)
        {
            LsbResult.Items.Clear();
        }
    }
}
