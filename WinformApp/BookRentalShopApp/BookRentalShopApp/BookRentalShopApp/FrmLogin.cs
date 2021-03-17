using MetroFramework;
using MetroFramework.Forms;
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

namespace BookRentalShopApp
{
    public partial class FrmLogin : MetroForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            
        }
        
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.Activate();
            TxtUserId.Focus();
        }

        
        private void BtnLogin_Click(object sender, EventArgs e) //로그인
        {
            string strUserId = "";
            //MessageBox.Show("로그인");
            if (string.IsNullOrEmpty(TxtUserId.Text) || string.IsNullOrEmpty(TxtPassword.Text))
            {
                MetroMessageBox.Show(this,"아이디/패스워드를 입력하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString)) //SqlConnection 연결
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    var query = "SELECT userID FROM memberTbl " +
                                " WHERE userID = @userID " +
                                "   AND passwords = @passwords " +
                                "   AND levels = 'S'";
                    
                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlParameter pUserID = new SqlParameter("@userID", SqlDbType.VarChar, 20); //SQL Injection 방지
                    pUserID.Value = TxtUserId.Text;
                    cmd.Parameters.Add(pUserID);

                    SqlParameter pPasswords = new SqlParameter("@passwords", SqlDbType.VarChar, 20); //SQL Injection 방지
                    pPasswords.Value = TxtPassword.Text;
                    cmd.Parameters.Add(pPasswords);

                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    strUserId = reader["userID"] != null ? reader["userID"].ToString() : "";
                    reader.Close();
                    //MessageBox.Show(strUserId);

                    if (string.IsNullOrEmpty(strUserId))
                    {
                        MetroMessageBox.Show(this, "접속실패", "로그인실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var updateQuery = $"UPDATE membertbl SET lastLoginDt = GETDATE(), loginIpAddr = '{Helper.Common.GetLocalIp()}' " +
                                          $" WHERE userId = '{strUserId}'";
                        cmd.CommandText = updateQuery;
                        cmd.ExecuteNonQuery();
                        MetroMessageBox.Show(this, "접속성공", "로그인성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "예외발생", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e) //취소
        {
            Environment.Exit(0); //완전 종료
        }

        private void TxtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) TxtPassword.Focus();
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) BtnLogin_Click(sender, e);
        }

        
    }
}
