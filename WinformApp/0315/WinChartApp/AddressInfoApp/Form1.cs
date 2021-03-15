using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressInfoApp
{
    public partial class Form1 : Form
    {
        string connString = "Data Source=127.0.0.1;Initial Catalog=PMS;Persist Security Info=True;" +
                            "User ID=sa;Password=mssql_p@ssw0rd!";
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInitial_Click(object sender, EventArgs e) //초기화
        {
            ClearInput();
        }

        private void BtnInsert_Click(object sender, EventArgs e) //추가
        {
            int.TryParse(TxtIdx.Text, out int result);
            if (result > 0)
            {
                MessageBox.Show("기존 값은 입력할 수 없습니다");
                ClearInput();
                return;
            }

            if (string.IsNullOrEmpty(TxtFullName.Text) || string.IsNullOrEmpty(TxtMobile.Text))
            {
                MessageBox.Show("값을 입력하세요");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = $"INSERT INTO dbo.Address (FullName, Mobile, Addr, RegId, RegDate) " +
                               $"                 Values ( '{TxtFullName.Text}', '{TxtMobile.Text.Replace("-", "")}', '{TxtAddr.Text}', 'admin', GETDATE() );";

                SqlCommand cmd = new SqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("입력 성공");
                }
                else
                {
                    MessageBox.Show("입력 실패");
                }
            }
            RefreshData();
            ClearInput();
        }

        private void BtnUpdate_Click(object sender, EventArgs e) //수정
        {
            int.TryParse(TxtIdx.Text, out int result);
            if (result == 0)
            {
                MessageBox.Show("데이터를 선택하세요");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = $"UPDATE Address SET " +
                               $"FullName = '{TxtFullName.Text}', " +
                               $"Mobile = '{TxtMobile.Text.Replace("-", "")}', " +
                               $"Addr = '{TxtAddr.Text}', " +
                               $"ModId = 'admin', " +
                               $"ModDate = GETDATE() " +
                               $"WHERE Idx = {result};";

                SqlCommand cmd = new SqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("수정했습니다");
                else
                    MessageBox.Show("수정하지 못했습니다");
            }
            RefreshData();
            ClearInput();
        }

        private void BtnDelete_Click(object sender, EventArgs e) //삭제
        {
            int.TryParse(TxtIdx.Text, out int result);
            if (result == 0)
            {
                MessageBox.Show("데이터를 선택하세요");
                return;
            }
            
            using (SqlConnection conn = new SqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = $"DELETE FROM Address WHERE idx = {result}";

                SqlCommand cmd = new SqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("삭제했습니다");
                else
                    MessageBox.Show("삭제하지 못했습니다");
            }
            RefreshData();
            ClearInput();
        }

        private void TxtFullName_KeyPress(object sender, KeyPressEventArgs e) //이름 입력
        {
            if (e.KeyChar == 13) //Enter
            {
                TxtMobile.Focus();
            }
        }

        private void TxtMobile_KeyPress(object sender, KeyPressEventArgs e) //번호 입력
        {
            if (e.KeyChar == 13) //Enter
            {
                TxtAddr.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }

                    string query = $"SELECT Idx " +
                                   $"     , FullName " +
                                   $"     , Mobile " +
                                   $"     , Addr " +
                                   $"  FROM dbo.Address";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    DgvAddress.DataSource = ds.Tables[0];

            }
        }

        private void ClearInput()
        {
            TxtIdx.Text = TxtFullName.Text = TxtMobile.Text = TxtAddr.Text = "";
        }

        private void DgvAddress_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selData = DgvAddress.Rows[e.RowIndex].Cells;

            TxtIdx.Text = selData[0].Value.ToString();
            TxtFullName.Text = selData[1].Value.ToString();
            TxtMobile.Text = selData[2].Value.ToString();
            TxtAddr.Text = selData[3].Value.ToString();
        }
    }
}
