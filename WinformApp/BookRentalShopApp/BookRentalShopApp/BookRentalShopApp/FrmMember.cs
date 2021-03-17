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
    public partial class FrmMember : MetroForm
    {
        public FrmMember()
        {
            InitializeComponent();
        }

        #region 전역변수
        private bool IsNew = false; //false수정 true신규
        #endregion


        #region 이벤트
        private void FrmDivCode_Load(object sender, EventArgs e)
        {
            IsNew = true;
            RefreshData();
        }

        private void FrmDivCode_Resize(object sender, EventArgs e)
        {
            DgvData.Height = this.ClientRectangle.Height - 90;
            GrbDetail.Height = this.ClientRectangle.Height - 90;
        }

        private void DgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var selData = DgvData.Rows[e.RowIndex];
                TxtIdx.Text = selData.Cells[0].Value.ToString();
                TxtNames.Text = selData.Cells[1].Value.ToString();
                CboLevels.SelectedItem = selData.Cells[2].Value.ToString();
                TxtAddr.Text = selData.Cells[3].Value.ToString();
                TxtMobile.Text = selData.Cells[4].Value.ToString();
                TxtEmail.Text = selData.Cells[5].Value.ToString();
                TxtUserID.Text = selData.Cells[6].Value.ToString();

                TxtIdx.ReadOnly = true;
                IsNew = false;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e) //삭제버튼
        {

            if (CheckValidation() == false) return;

            if (MetroMessageBox.Show(this, "삭제 하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            DeleteData();
            RefreshData();
        }

        private void BtnNew_Click(object sender, EventArgs e) //신규 버튼
        {
            ClearInputs();
        }

        private void BtnSave_Click(object sender, EventArgs e) //저장 버튼
        {
            if (CheckValidation() == false) return;

            SaveData();
            RefreshData();
        }

        #endregion


        #region 사용자메소드
        private bool CheckValidation()// fn 유효성 체크
        {
            if (string.IsNullOrEmpty(TxtNames.Text) ||
                string.IsNullOrEmpty(TxtAddr.Text) || string.IsNullOrEmpty(TxtMobile.Text) ||
                string.IsNullOrEmpty(TxtEmail.Text) || CboLevels.SelectedIndex == -1 ||
                string.IsNullOrEmpty(TxtUserID.Text) || string.IsNullOrEmpty(TxtPasswords.Text))
            {
                MetroMessageBox.Show(this, "빈 값은 처리할 수 없습니다", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else return true;
        }

        private void RefreshData() //fn 데이터 새로고침
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    var query = @"SELECT [Idx]
                                        ,[Names]
                                        ,[Levels]
                                        ,[Addr]
                                        ,[Mobile]
                                        ,[Email]
                                        ,[userID]
                                        ,[lastLoginDt]
                                        ,[loginIpAddr]
                                    FROM [dbo].[membertbl]";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "membertbl");

                    DgvData.DataSource = ds;
                    DgvData.DataMember = "membertbl";
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "예외 발생", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            TxtIdx.Text = TxtNames.Text = TxtAddr.Text = TxtEmail.Text = TxtMobile.Text = TxtPasswords.Text = TxtUserID.Text = "";
            CboLevels.SelectedIndex = -1;
            TxtIdx.ReadOnly = true;
            IsNew = true;
        }

        private void SaveData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    var query = "";

                    if (IsNew)
                    {
                        query = @"INSERT INTO [dbo].[membertbl]
                                        ([Names]
                                        ,[Levels]
                                        ,[Addr]
                                        ,[Mobile]
                                        ,[Email]
                                        ,[userID]
                                        ,[passwords])

                                    VALUES (@Names
		                                , @Addr
		                                , @Mobile
		                                , @Email
		                                , @UserID
		                                , @Passwords)";
                    }
                    else
                    {
                        query = @"UPDATE [dbo].[membertbl]
                                     SET [Names] = @Names
                                        ,[Levels] = @Names
                                        ,[Addr] = @Addr
                                        ,[Mobile] = @Mobile
                                        ,[Email] = @Email
                                        ,[userID] = @UserID
                                        ,[passwords] = @Passwords
                                    WHERE Idx = @Idx";
                        /*
                        SqlParameter pIdx = new SqlParameter("@Idx", SqlDbType.Int);
                        pIdx.Value = TxtIdx.Text;
                        cmd.Parameters.Add(pIdx);*/
                        
                    }

                    cmd.CommandText = query;

                    SqlParameter pNames = new SqlParameter("@Names", SqlDbType.NVarChar, 50);
                    pNames.Value = TxtNames.Text;
                    cmd.Parameters.Add(pNames);

                    SqlParameter pLevels = new SqlParameter("@Levels", SqlDbType.Char, 1);
                    pLevels.Value = CboLevels.SelectedItem.ToString();
                    cmd.Parameters.Add(pLevels);

                    SqlParameter pAddr = new SqlParameter("@Addr", SqlDbType.NVarChar, 100);
                    pAddr.Value = TxtAddr.Text;
                    cmd.Parameters.Add(pAddr);

                    SqlParameter pMobile = new SqlParameter("@Mobile", SqlDbType.VarChar, 13);
                    pMobile.Value = TxtMobile.Text;
                    cmd.Parameters.Add(pMobile);

                    SqlParameter pEmail = new SqlParameter("@Email", SqlDbType.VarChar, 50);
                    pEmail.Value = TxtEmail.Text;
                    cmd.Parameters.Add(pEmail);

                    SqlParameter pUserID = new SqlParameter("@UserID", SqlDbType.VarChar, 20);
                    pUserID.Value = TxtUserID.Text;
                    cmd.Parameters.Add(pUserID);

                    SqlParameter pPasswords = new SqlParameter("@Passwords", SqlDbType.VarChar, 100);
                    pPasswords.Value = TxtPasswords.Text;
                    cmd.Parameters.Add(pPasswords);

                    
                    if (IsNew == false)
                    {
                        SqlParameter pIdx = new SqlParameter("@Idx", SqlDbType.Int);
                        pIdx.Value = TxtIdx.Text;
                        cmd.Parameters.Add(pIdx);
                    }

                    var result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MetroMessageBox.Show(this, "저장 성공", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MetroMessageBox.Show(this, "저장 실패", "실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "예외 발생", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    var query = "";

                    query = "DELETE FROM [dbo].[membertbl] WHERE[Idx] = @Idx";
                    cmd.CommandText = query;

                    SqlParameter pIdx = new SqlParameter("@Idx", SqlDbType.VarChar, 8);
                    pIdx.Value = TxtIdx.Text;
                    cmd.Parameters.Add(pIdx);

                    var result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MetroMessageBox.Show(this, "삭제 성공", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MetroMessageBox.Show(this, "삭제 실패", "실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "예외 발생", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


    }
}
