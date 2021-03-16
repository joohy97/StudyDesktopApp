using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IoTSenserMonApp
{
    public partial class Form1 : Form
    {
        private double xCount = 200;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var port in SerialPort.GetPortNames())
            {
                CboSerialPort.Items.Add(port);
            }
            CboSerialPort.Text = "Select Port";


            BtnDisplay.BackColor = Color.BlueViolet;
            BtnDisplay.ForeColor = Color.White;
            BtnDisplay.Text = "";
            BtnDisplay.Font = new Font("맑은 고딕", 16, FontStyle.Bold);

            LblConnectTime.Text = "Connection Time : ";
            TxtSensorNum.TextAlign = HorizontalAlignment.Center;
            BtnConnect.Enabled = false;
            BtnDisconnect.Enabled = false;

            InitChartStyle();
        }

        private void InitChartStyle()
        {
            ChtPhotoResistors.ChartAreas[0].BackColor = Color.Black;
            ChtPhotoResistors.ChartAreas[0].AxisX.Minimum = 0;
            ChtPhotoResistors.ChartAreas[0].AxisX.Maximum = xCount;
            ChtPhotoResistors.ChartAreas[0].AxisX.Interval = xCount / 4;
            ChtPhotoResistors.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            ChtPhotoResistors.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            ChtPhotoResistors.ChartAreas[0].AxisY.Minimum = 0;
            ChtPhotoResistors.ChartAreas[0].AxisY.Maximum = 1024;
            ChtPhotoResistors.ChartAreas[0].AxisY.Interval = xCount;
            ChtPhotoResistors.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
            ChtPhotoResistors.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            ChtPhotoResistors.ChartAreas[0].CursorX.AutoScroll = true;

            ChtPhotoResistors.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            ChtPhotoResistors.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
            ChtPhotoResistors.ChartAreas[0].AxisX.ScrollBar.ButtonColor = Color.LightSteelBlue;

            ChtPhotoResistors.Series.Clear();
            ChtPhotoResistors.Series.Add("PhotoCell");
            ChtPhotoResistors.Series["PhotoCell"].ChartType = SeriesChartType.Line;
            ChtPhotoResistors.Series["PhotoCell"].Color = Color.LightGreen;
            ChtPhotoResistors.Series["PhotoCell"].BorderWidth = 3;

            if (ChtPhotoResistors.Legends.Count > 0)
            {
                for (int i = 0; i < ChtPhotoResistors.Legends.Count; i++)
                {
                    ChtPhotoResistors.Legends.RemoveAt(i);
                }
            }
        }

        private void BtnConnect_Click(object sender, EventArgs e) //버튼 연결
        {
            //todo : 실제 작업 시 작성
        }

        private void BtnDisconnect_Click(object sender, EventArgs e) //버튼 연결끊기
        {
            //todo : 실제 작업 시 작성
        }

        private Timer timerSimul = new Timer();
        private Random randPhoto = new Random();
        private bool IsSimul = false;
        private List<SensorData> sensors = new List<SensorData>();

        private void MnuBeginSimul_Click(object sender, EventArgs e) //시뮬 시작
        {
            IsSimul = true;
            timerSimul.Enabled = true;
            timerSimul.Interval = 1000;
            timerSimul.Tick += timerSimul_Tick;
            timerSimul.Start();
        }

        private void timerSimul_Tick(object sender, EventArgs e)
        {
            int value = randPhoto.Next(1, 1023);
            ShowSensorValue(value.ToString());
        }

        private void ShowSensorValue(string value)
        {
            int.TryParse(value, out int v);

            var currentTime = DateTime.Now;
            SensorData data = new SensorData(currentTime, v,IsSimul);
            sensors.Add(data);

            TxtSensorNum.Text = $"{sensors.Count}";
            PrbPhotoResistor.Value = v;
            var item = $"{currentTime.ToString("yyyy-MM-dd HH:mm:ss")}\t{v}";
            LsbPhotoResistors.Items.Add(item);
            LsbPhotoResistors.SelectedIndex = LsbPhotoResistors.Items.Count - 1; //스크롤\

            ChtPhotoResistors.Series[0].Points.Add(v);
        }

        private void MnuEndSimul_Click(object sender, EventArgs e) //시뮬 끝
        {
            IsSimul = false;
            timerSimul.Stop();
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            if (IsSimul)
            {
                MessageBox.Show("시뮬레이션을 멈추고 종료하세요", "종료", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Environment.Exit(0);
        }
    }
}
