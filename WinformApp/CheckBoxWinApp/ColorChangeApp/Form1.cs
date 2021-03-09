using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorChangeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /*
        private void TrbRed_Scroll(object sender, EventArgs e)
        {
            TxtRed.Text = TrbRed.Value.ToString();
            PnlResult.BackColor = Color.FromArgb(TrbRed.Value, TrbGreen.Value, TrbBlue.Value);
        }

        private void TrbGreen_Scroll(object sender, EventArgs e)
        {
            TxtGreen.Text = TrbGreen.Value.ToString();
            PnlResult.BackColor = Color.FromArgb(TrbRed.Value, TrbGreen.Value, TrbBlue.Value);
        }

        private void TrbBlue_Scroll(object sender, EventArgs e)
        {
            TxtBlue.Text = TrbBlue.Value.ToString();
            PnlResult.BackColor = Color.FromArgb(TrbRed.Value, TrbGreen.Value, TrbBlue.Value);
        }
        */

        //트랙바의 이벤트에서 Trackbar_Scroll을 선택하면 하나의 메서드로 3개의 스크롤에 적용시킬 수 있음
        private void Trackbar_Scroll(object sender, EventArgs e)
        {
            TxtRed.Text = TrbRed.Value.ToString();
            TxtGreen.Text = TrbGreen.Value.ToString();
            TxtBlue.Text = TrbBlue.Value.ToString();

            PnlResult.BackColor = Color.FromArgb(TrbRed.Value, TrbGreen.Value, TrbBlue.Value);
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }
    }
}
