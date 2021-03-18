using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRentalShopApp
{
    public partial class FrmRental : MetroForm
    {
        public FrmRental()
        {
            InitializeComponent();
        }

        #region 전역변수
        private bool IsNew = false; //false수정 true신규

        private int selMemberIdx = 0;
        private string selMemberName = "";

        private int selBookIdx = 0;
        private string selBookName = "";
        #endregion


        #region 이벤트
        private void FrmDivCode_Load(object sender, EventArgs e)
        {
            IsNew = true;
            InitCboData();
            RefreshData();

            DtpRentalDate.CustomFormat = "yyyy-MM-dd";
            DtpRentalDate.Format = DateTimePickerFormat.Custom;
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
                BtnSeachBook.Enabled = BtnSearchMember.Enabled = false;
                DtpRentalDate.Enabled = false;

            }

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
            if (string.IsNullOrEmpty(TxtmemberName.Text) ||
                string.IsNullOrEmpty(TxtbookName.Text) ||
                CboRentalState.SelectedIndex == -1 ||
                DtpRentalDate.Value == null)
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
                var temp = new Dictionary<string, string>();
                temp.Add("R", "대여중");
                temp.Add("T", "반납");

                CboRentalState.DataSource = new BindingSource(temp, null);
                CboRentalState.DisplayMember = "Value";
                CboRentalState.ValueMember = "Key";
                CboRentalState.SelectedIndex = -1;
                
            }
            catch
            {}

        }

        private void AssignToControls(DataGridViewRow selData)
        {
            TxtIdx.Text = selData.Cells[0].Value.ToString();
            selMemberIdx = (int)selData.Cells[1].Value;
            Debug.WriteLine($">>>> selMemberIdx : {selMemberIdx}");
            TxtmemberName.Text = selData.Cells[2].Value.ToString();
            selBookIdx = (int)selData.Cells[3].Value;
            TxtbookName.Text = selData.Cells[4].Value.ToString();
            DtpRentalDate.Value = (DateTime)selData.Cells[5].Value;
            TxtReturnDate.Text = selData.Cells[6].Value == null ? "" : selData.Cells[6].Value.ToString();
            CboRentalState.SelectedValue = selData.Cells[7].Value;

            TxtIdx.ReadOnly = true;
        }

        private void RefreshData() //fn 데이터 새로고침
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    var query = @"SELECT r.Idx
                                        ,r.memberIdx
                                        ,m.Names as memberName
	                                    ,r.bookIdx
	                                    ,b.Names as bookName
                                        ,r.rentalDate
                                        ,r.returnDate
	                                    ,r.rentalState
                                        ,case r.rentalState 
			                                        when 'R' then '대여중'
			                                        when 'T' then '반납'
			                                        else '상태없음' end
			                                        as StateDesc
                                    FROM dbo.rentaltbl as r
                                    INNER JOIN dbo.membertbl as m
                                    ON r.memberIdx = m.Idx
                                    INNER JOIN dbo.bookstbl as b
                                    ON r.bookIdx = b.Idx";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "rentaltbl");

                    DgvData.DataSource = ds;
                    DgvData.DataMember = "rentaltbl";
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "예외 발생", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            DgvData.Columns[1].Visible = false;
            DgvData.Columns[3].Visible = false;
            DgvData.Columns[7].Visible = false;

            DgvData.Columns[3].Width = 200;
        }

        private void ClearInputs()
        {
            //TxtIdx.Text = TxtmemberName.Text = TxtbookName.Text = TxtISBN.Text = TxtDescriptions.Text = TxtPrice.Text = "";
            //CboDivision.SelectedIndex = -1;
            DtpRentalDate.Value = DateTime.Now;
            TxtIdx.ReadOnly = true;
            IsNew = true;
            selMemberIdx = 0;
            selMemberName = "";
            selBookIdx = 0;
            selBookName = "";
            BtnSeachBook.Enabled = BtnSearchMember.Enabled = true;
            DtpRentalDate.Enabled = true;
            CboRentalState.SelectedIndex = -1;
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
                        query = @"INSERT INTO [dbo].[rentaltbl]
                                                    ([memberIdx]
                                                    ,[bookIdx]
                                                    ,[rentalDate]
                                                    ,[rentalState])
                                                VALUES
                                                    (@memberIdx
                                                    ,@bookIdx
                                                    ,@rentalDate
                                                    ,@rentalState)";
                    }
                    else
                    {
                        query = @"UPDATE [dbo].[rentaltbl]
                                    SET [returnDate] = GETDATE()
                                        ,[rentalState] = 'R'
                                    WHERE Idx = @idx";
                        
                    }

                    cmd.CommandText = query;

                    
                    SqlParameter pmemberIdx = new SqlParameter("@memberIdx", SqlDbType.Int);
                    pmemberIdx.Value = selMemberIdx;
                    cmd.Parameters.Add(pmemberIdx);

                    SqlParameter pbookIdx = new SqlParameter("@bookIdx", SqlDbType.Int);
                    pbookIdx.Value = selBookIdx;
                    cmd.Parameters.Add(pbookIdx);

                    SqlParameter prentalDate = new SqlParameter("@rentalDate", SqlDbType.Date);
                    prentalDate.Value = DtpRentalDate.Value;
                    cmd.Parameters.Add(prentalDate);

                    SqlParameter prentalState = new SqlParameter("@rentalState", SqlDbType.Char, 1);
                    prentalState.Value = CboRentalState.SelectedValue;
                    cmd.Parameters.Add(prentalState);



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

        #endregion

        private void BtnSearchMember_Click(object sender, EventArgs e)
        {
            FrmMemberPopup frm = new FrmMemberPopup();
            //frm.Parent = this;
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(frm.selIdx + " " + frm.selName);
                selMemberIdx = frm.selIdx;
                TxtmemberName.Text = selMemberName = frm.selName;
            }
        }

        private void BtnSeachBook_Click(object sender, EventArgs e)
        {
            FrmBooksPopup frm = new FrmBooksPopup();
            //frm.Parent = this;
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(frm.selIdx + " " + frm.selName);
                selBookIdx = frm.selIdx;
                TxtbookName.Text = selBookName = frm.selName;
            }
        }
    }
}
