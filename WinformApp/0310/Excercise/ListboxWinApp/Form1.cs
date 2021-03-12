using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListboxWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //GDP 국가 초기화
            //디자인모드에서 항목편집

            //살기좋은 도시 초기화
            Lsb2.Items.Add("오스트리아, 빈");
            Lsb2.Items.Add("호주, 멜버른");
            Lsb2.Items.Add("일본, 오사카");
            Lsb2.Items.Add("캐나다, 캘거리");
            Lsb2.Items.Add("호주, 시드니");
            Lsb2.Items.Add("캐나다, 밴쿠버");
            Lsb2.Items.Add("일본, 도쿄");
            Lsb2.Items.Add("캐나다, 토론토");
            Lsb2.Items.Add("덴마크, 코펜하겐");
            Lsb2.Items.Add("호주, 애들레이드");

            //행복한 나라 초기화
            List<String> lstGDP = new List<String> { "미국", "러시아", "중국", "영국",
        "독일", "프랑스", "일본", "이스라엘", "사우디아라비아", "UAE", "한국", "필리핀" };
            Lsb3.DataSource = lstGDP;


        }

        private void Lsb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(sender.ToString());
            var selITem = sender as ListBox;
            TxtInd1.Text = selITem.SelectedIndex.ToString();
            TxtItem1.Text = selITem.SelectedItem.ToString();
    
        }

        private void Lsb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selITem = sender as ListBox;
            TxtInd2.Text = selITem.SelectedIndex.ToString();
            TxtItem2.Text = selITem.SelectedItem.ToString();
        }

        private void Lsb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selITem = sender as ListBox;
            TxtInd3.Text = selITem.SelectedIndex.ToString();
            TxtItem3.Text = selITem.SelectedItem == null ? string.Empty : selITem.SelectedItem.ToString();
        }

        private void BtnInit_Click(object sender, EventArgs e)
        {
            Lsb1.SelectedIndex = Lsb2.SelectedIndex = Lsb3.SelectedIndex = -1;
        }
    }
}
