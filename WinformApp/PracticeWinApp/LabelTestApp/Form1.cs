using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblAutoSize.Text = LblManualSize.Text = string.Empty;
        }

        private void BtnPushText_Click(object sender, EventArgs e)
        {
            string sample1 = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Consequatur qui eum rem assumenda quia, ut repudiandae deleniti laborum nemo veniam optio quisquam earum aperiam esse soluta eligendi unde dolore impedit.";
            string sample2 = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Culpa, minus doloribus doloremque perferendis in nihil, nemo eos ipsa similique eaque veritatis corrupti aperiam fugiat omnis? Voluptatem voluptatibus vitae quisquam dicta!";

            LblAutoSize.Text = sample1;
            LblManualSize.Text = sample2;
                
        }
    }
}
