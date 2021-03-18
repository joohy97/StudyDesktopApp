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
    public partial class FrmBooks : MetroForm
    {
        public FrmBooks()
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
            InitCboData();
            RefreshData();

            DtpReleaseDate.CustomFormat = "yyyy-MM-dd";
            DtpReleaseDate.Format = DateTimePickerFormat.Custom;
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
                AssignToControls(selData);
                
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
            if (string.IsNullOrEmpty(TxtAuthor.Text) ||
                string.IsNullOrEmpty(TxtNames.Text) ||
                CboDivision.SelectedIndex == -1 ||
                DtpReleaseDate.Value == null)
            {
                MetroMessageBox.Show(this, "빈 값은 처리할 수 없습니다", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else return true;
        }

        private void InitCboData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    var query = "SELECT division, names FROM dbo.divtbl";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    var temp = new Dictionary<string, string>();
                    while (reader.Read())
                    {
                        temp.Add(reader[0].ToString(), reader[1].ToString());
                    }
                    CboDivision.DataSource = new BindingSource(temp, "divtbl");
                    CboDivision.DisplayMember = "Value";
                    CboDivision.ValueMember = "Key";
                    CboDivision.SelectedIndex = -1;
                }
            }
            catch
            {}

        }

        private void AssignToControls(DataGridViewRow selData)
        {
            TxtIdx.Text = selData.Cells[0].Value.ToString();
            TxtAuthor.Text = selData.Cells[1].Value.ToString();
            CboDivision.SelectedValue = selData.Cells[2].Value.ToString();

            TxtNames.Text = selData.Cells[4].Value.ToString();
            DtpReleaseDate.Value = (DateTime)selData.Cells[5].Value;
            TxtISBN.Text = selData.Cells[6].Value.ToString();

            TxtPrice.Text = selData.Cells[7].Value.ToString();
            TxtDescriptions.Text = selData.Cells[8].Value.ToString();

            TxtIdx.ReadOnly = true;
        }

        private void RefreshData() //fn 데이터 새로고침
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    var query = @"SELECT b.[Idx]
                                        ,b.[Author]
                                        ,d.[division]
                                        ,d.[Names] as DivName
                                        
                                        ,b.[Names]                                       
                                        ,b.[ReleaseDate]
                                        ,b.[ISBN]
                                        ,b.[Price]
                                        ,b.[Descriptions]
                                    FROM [dbo].[bookstbl] as b
                                    INNER JOIN dbo.divtbl as d
	                                ON	d.Division = b.Division";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "bookstbl");

                    DgvData.DataSource = ds;
                    DgvData.DataMember = "bookstbl";
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "예외 발생", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            DgvData.Columns[2].Visible = false;
            DgvData.Columns[8].Visible = false;

            DgvData.Columns[4].Width = 200;
            DgvData.Columns[4].HeaderText = "도서명";

        }

        private void ClearInputs()
        {
            TxtIdx.Text = TxtAuthor.Text = TxtNames.Text = TxtISBN.Text = TxtDescriptions.Text = TxtPrice.Text = "";
            CboDivision.SelectedIndex = -1;
            DtpReleaseDate.Value = DateTime.Now;
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
                        query = @"INSERT INTO [dbo].[bookstbl]
                                                ([Author]
                                                ,[Division]
                                                ,[Names]
                                                ,[ReleaseDate]
                                                ,[ISBN]
                                                ,[Price]
                                                ,[Descriptions])
                                            VALUES
                                                (@Author
                                                ,@Division
                                                ,@Names
                                                ,@ReleaseDate 
                                                ,@ISBN
                                                ,@Price 
                                                ,@Descriptions)";
                    }
                    else
                    {
                        query = @"UPDATE [dbo].[bookstbl]
                                     SET [Author] = @Author
                                        ,[Division] = @Division
                                        ,[Names] = @Names
                                        ,[ReleaseDate] = @ReleaseDate
                                        ,[ISBN] = @ISBN
                                        ,[Price] = @Price
                                        ,[Descriptions] = @Descriptions
                                   WHERE Idx = @Idx";
                        /*
                        SqlParameter pIdx = new SqlParameter("@Idx", SqlDbType.Int);
                        pIdx.Value = TxtIdx.Text;
                        cmd.Parameters.Add(pIdx);*/
                        
                    }

                    cmd.CommandText = query;
                    SqlParameter pAuthor = new SqlParameter("@Author", SqlDbType.NVarChar, 50);
                    pAuthor.Value = TxtAuthor.Text;
                    cmd.Parameters.Add(pAuthor);

                    SqlParameter pDivision = new SqlParameter("@Division", SqlDbType.VarChar, 8);
                    pDivision.Value = CboDivision.SelectedValue;
                    cmd.Parameters.Add(pDivision);

                    SqlParameter pNames = new SqlParameter("@Names", SqlDbType.NVarChar, 100);
                    pNames.Value = TxtNames.Text;
                    cmd.Parameters.Add(pNames);

                    SqlParameter pReleaseDate = new SqlParameter("@ReleaseDate", SqlDbType.Date);
                    pReleaseDate.Value = DtpReleaseDate.Value;
                    cmd.Parameters.Add(pReleaseDate);

                    SqlParameter pISBN = new SqlParameter("@ISBN", SqlDbType.VarChar, 200);
                    pISBN.Value = TxtISBN.Text;
                    cmd.Parameters.Add(pISBN);

                    SqlParameter pPrice = new SqlParameter("@Price", SqlDbType.Decimal);
                    pPrice.Value = TxtPrice.Text;
                    cmd.Parameters.Add(pPrice);

                    SqlParameter pDescriptions = new SqlParameter("@Descriptions", SqlDbType.NVarChar);
                    pDescriptions.Value = TxtDescriptions.Text;
                    cmd.Parameters.Add(pDescriptions);


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

                    query = "DELETE FROM [dbo].[bookstbl] WHERE[Idx] = @Idx";
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
