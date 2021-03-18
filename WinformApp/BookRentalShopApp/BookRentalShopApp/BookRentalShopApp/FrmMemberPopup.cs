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
    public partial class FrmMemberPopup : MetroForm
    {
        public FrmMemberPopup()
        {
            InitializeComponent();
        }

        #region 전역변수
        public int selIdx { get; set; }

        public string selName { get; set; }



        #endregion


        #region 이벤트
        private void FrmDivCode_Load(object sender, EventArgs e)
        {
            RefreshData();
        }



        #endregion


        #region 사용자메소드


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

            DgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
        }




        #endregion

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if ( DgvData.SelectedRows.Count == 0)
            {
                MetroMessageBox.Show(this, "데이터를 선택하세요", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            selIdx = (int)DgvData.SelectedRows[0].Cells[0].Value;
            selName = DgvData.SelectedRows[0].Cells[1].Value.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();




        }
    }
}
