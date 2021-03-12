using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotePadApp
{
    public partial class Form1 : Form
    {
        public bool isModify { get; set; } //flag
        private const string firstFileName = "noName.txt"; //initial file name
        private string currFileName = firstFileName;



        public Form1()
        {
            InitializeComponent();
        }

        private void MnuNewFile_Click(object sender, EventArgs e)
        {
            //작업중인 파일이 있으면 저장처리
            BeforeClose();

            TxtMain.Text = "";
            this.Text = $"{currFileName} - 내 메모장";
            isModify = false;
            currFileName = firstFileName;
        }

        private void BeforeClose()
        {
            if (isModify)
            {
                DialogResult answer = MessageBox.Show("저장하시겠습니까?", "저장확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    if (currFileName == firstFileName)
                    {
                        if (DlgSaveText.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter sw = File.CreateText(DlgSaveText.FileName);
                            sw.WriteLine(TxtMain.Text);
                            sw.Close();
                        }
                        else
                        {
                            StreamWriter sw = File.CreateText(currFileName);
                            sw.WriteLine(TxtMain.Text);
                            sw.Close();
                        }
                    }
                }               
            }
        }

        private void MnuOpenFile_Click(object sender, EventArgs e)
        {
            BeforeClose();
            DlgOpenText.ShowDialog();
            currFileName = DlgOpenText.FileName;
            this.Text = $"{currFileName} - 내 메모장";

            try
            {
                StreamReader sr = File.OpenText(currFileName);
                TxtMain.Text = sr.ReadToEnd();
                isModify = false;
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MnuSaveFile_Click(object sender, EventArgs e)
        {
            if (currFileName == firstFileName)
            {
                if (DlgSaveText.ShowDialog() == DialogResult.OK)
                    currFileName = DlgSaveText.FileName;
            }

            StreamWriter sw = File.CreateText(currFileName);
            sw.WriteLine(TxtMain.Text);

            isModify = false;
            sw.Close();

            this.Text = $"{currFileName} - 내 메모장";
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            BeforeClose();
            Environment.Exit(0);
        }

        private void MnuCopy_Click(object sender, EventArgs e)
        {
            var contents = ActiveControl as RichTextBox;
            if (contents != null)
            {
                Clipboard.SetDataObject(contents.SelectedText);
                MessageBox.Show(contents.SelectedText);
            }
        }

        private void MnuPaste_Click(object sender, EventArgs e)
        {
            var contents = ActiveControl as RichTextBox;
            if (contents != null)
            {
                IDataObject data = Clipboard.GetDataObject();
                contents.SelectedText = data.GetData(DataFormats.Text).ToString();
                isModify = true;
            }
        }

        private void MnuAbout_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("메모장 v1.0입니다");
            var form = new AboutThis();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DlgSaveText.Filter = DlgOpenText.Filter = 
                "Text file (*.txt)|*.txt|Log file (*.log)|*.log|Readme file (*.md)|*.md";
            this.Text = $"{currFileName} - 내 메모장";
            isModify = false;
        }

        private void TxtMain_TextChanged(object sender, EventArgs e)
        {
            isModify = true;
            this.Text = '*' + $"{currFileName} - 내 메모장";
        }
    }
}
