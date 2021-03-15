using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WinChartApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "중간고사 성적2";

            chart1.Titles.Add("중간고사 성적");
            chart1.Series.Add("Series2");
            chart1.Series["Series1"].LegendText = "수학";
            chart1.Series["Series2"].LegendText = "영어";

            chart1.ChartAreas.Add("ChartAreas2");
            chart1.Series["Series2"].ChartArea = "ChartAreas2";

            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                chart1.Series[0].Points.AddXY(i, rand.Next(10, 100));
                chart1.Series[1].Points.AddXY(i, rand.Next(10, 100));
            }

            chart1.Series[0].ChartType = SeriesChartType.Column;
            chart1.Series[1].ChartType = SeriesChartType.Line;

            BtnSplit.Enabled = false;
        }

        private void BtnMerge_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas.RemoveAt(chart1.ChartAreas.IndexOf("ChartAreas2"));
            chart1.Series["Series2"].ChartArea = "ChartArea1";

            BtnMerge.Enabled = false;
            BtnSplit.Enabled = true;
        }

        private void BtnSplit_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas.Add("ChartAreas2");
            chart1.Series[1].ChartArea = "ChartAreas2";

            BtnMerge.Enabled = true;
            BtnSplit.Enabled = false;
        }
    }
}
