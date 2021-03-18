
namespace BookRentalShopApp
{
    partial class FrmRental
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRental));
            this.GrbDetail = new System.Windows.Forms.GroupBox();
            this.CboRentalState = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.BtnSeachBook = new System.Windows.Forms.Button();
            this.BtnSearchMember = new System.Windows.Forms.Button();
            this.DtpRentalDate = new MetroFramework.Controls.MetroDateTime();
            this.TxtbookName = new MetroFramework.Controls.MetroTextBox();
            this.Label = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnNew = new MetroFramework.Controls.MetroButton();
            this.TxtmemberName = new MetroFramework.Controls.MetroTextBox();
            this.TxtIdx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.TxtReturnDate = new MetroFramework.Controls.MetroTextBox();
            this.GrbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbDetail
            // 
            this.GrbDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrbDetail.Controls.Add(this.TxtReturnDate);
            this.GrbDetail.Controls.Add(this.CboRentalState);
            this.GrbDetail.Controls.Add(this.metroLabel5);
            this.GrbDetail.Controls.Add(this.metroLabel4);
            this.GrbDetail.Controls.Add(this.BtnSeachBook);
            this.GrbDetail.Controls.Add(this.BtnSearchMember);
            this.GrbDetail.Controls.Add(this.DtpRentalDate);
            this.GrbDetail.Controls.Add(this.TxtbookName);
            this.GrbDetail.Controls.Add(this.Label);
            this.GrbDetail.Controls.Add(this.metroLabel3);
            this.GrbDetail.Controls.Add(this.BtnSave);
            this.GrbDetail.Controls.Add(this.BtnNew);
            this.GrbDetail.Controls.Add(this.TxtmemberName);
            this.GrbDetail.Controls.Add(this.TxtIdx);
            this.GrbDetail.Controls.Add(this.metroLabel2);
            this.GrbDetail.Controls.Add(this.metroLabel1);
            this.GrbDetail.Location = new System.Drawing.Point(378, 63);
            this.GrbDetail.Name = "GrbDetail";
            this.GrbDetail.Size = new System.Drawing.Size(335, 432);
            this.GrbDetail.TabIndex = 0;
            this.GrbDetail.TabStop = false;
            this.GrbDetail.Text = "상세";
            // 
            // CboRentalState
            // 
            this.CboRentalState.FormattingEnabled = true;
            this.CboRentalState.ItemHeight = 23;
            this.CboRentalState.Location = new System.Drawing.Point(91, 197);
            this.CboRentalState.Name = "CboRentalState";
            this.CboRentalState.PromptText = "대여상태";
            this.CboRentalState.Size = new System.Drawing.Size(214, 29);
            this.CboRentalState.TabIndex = 10;
            this.CboRentalState.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(20, 202);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(65, 19);
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = "대여상태";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(34, 167);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(51, 19);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "반납일";
            // 
            // BtnSeachBook
            // 
            this.BtnSeachBook.Image = ((System.Drawing.Image)(resources.GetObject("BtnSeachBook.Image")));
            this.BtnSeachBook.Location = new System.Drawing.Point(273, 98);
            this.BtnSeachBook.Name = "BtnSeachBook";
            this.BtnSeachBook.Size = new System.Drawing.Size(32, 23);
            this.BtnSeachBook.TabIndex = 7;
            this.BtnSeachBook.UseVisualStyleBackColor = true;
            this.BtnSeachBook.Click += new System.EventHandler(this.BtnSeachBook_Click);
            // 
            // BtnSearchMember
            // 
            this.BtnSearchMember.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearchMember.Image")));
            this.BtnSearchMember.Location = new System.Drawing.Point(273, 69);
            this.BtnSearchMember.Name = "BtnSearchMember";
            this.BtnSearchMember.Size = new System.Drawing.Size(32, 23);
            this.BtnSearchMember.TabIndex = 5;
            this.BtnSearchMember.UseVisualStyleBackColor = true;
            this.BtnSearchMember.Click += new System.EventHandler(this.BtnSearchMember_Click);
            // 
            // DtpRentalDate
            // 
            this.DtpRentalDate.CustomFormat = "yyyy-MM-dd";
            this.DtpRentalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpRentalDate.Location = new System.Drawing.Point(91, 127);
            this.DtpRentalDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtpRentalDate.Name = "DtpRentalDate";
            this.DtpRentalDate.Size = new System.Drawing.Size(214, 29);
            this.DtpRentalDate.TabIndex = 8;
            // 
            // TxtbookName
            // 
            // 
            // 
            // 
            this.TxtbookName.CustomButton.Image = null;
            this.TxtbookName.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.TxtbookName.CustomButton.Name = "";
            this.TxtbookName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtbookName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtbookName.CustomButton.TabIndex = 1;
            this.TxtbookName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtbookName.CustomButton.UseSelectable = true;
            this.TxtbookName.CustomButton.Visible = false;
            this.TxtbookName.Lines = new string[0];
            this.TxtbookName.Location = new System.Drawing.Point(91, 98);
            this.TxtbookName.MaxLength = 32767;
            this.TxtbookName.Name = "TxtbookName";
            this.TxtbookName.PasswordChar = '\0';
            this.TxtbookName.PromptText = "도서명";
            this.TxtbookName.ReadOnly = true;
            this.TxtbookName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtbookName.SelectedText = "";
            this.TxtbookName.SelectionLength = 0;
            this.TxtbookName.SelectionStart = 0;
            this.TxtbookName.ShortcutsEnabled = true;
            this.TxtbookName.Size = new System.Drawing.Size(176, 23);
            this.TxtbookName.TabIndex = 6;
            this.TxtbookName.UseSelectable = true;
            this.TxtbookName.WaterMark = "도서명";
            this.TxtbookName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtbookName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(34, 132);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(51, 19);
            this.Label.TabIndex = 12;
            this.Label.Text = "대여일";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(34, 102);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "도서명";
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(245, 382);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(74, 35);
            this.BtnSave.TabIndex = 13;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNew.Location = new System.Drawing.Point(165, 382);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(74, 35);
            this.BtnNew.TabIndex = 12;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseSelectable = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // TxtmemberName
            // 
            // 
            // 
            // 
            this.TxtmemberName.CustomButton.Image = null;
            this.TxtmemberName.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.TxtmemberName.CustomButton.Name = "";
            this.TxtmemberName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtmemberName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtmemberName.CustomButton.TabIndex = 1;
            this.TxtmemberName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtmemberName.CustomButton.UseSelectable = true;
            this.TxtmemberName.CustomButton.Visible = false;
            this.TxtmemberName.Lines = new string[0];
            this.TxtmemberName.Location = new System.Drawing.Point(91, 69);
            this.TxtmemberName.MaxLength = 32767;
            this.TxtmemberName.Name = "TxtmemberName";
            this.TxtmemberName.PasswordChar = '\0';
            this.TxtmemberName.PromptText = "대여회원";
            this.TxtmemberName.ReadOnly = true;
            this.TxtmemberName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtmemberName.SelectedText = "";
            this.TxtmemberName.SelectionLength = 0;
            this.TxtmemberName.SelectionStart = 0;
            this.TxtmemberName.ShortcutsEnabled = true;
            this.TxtmemberName.Size = new System.Drawing.Size(176, 23);
            this.TxtmemberName.TabIndex = 4;
            this.TxtmemberName.UseSelectable = true;
            this.TxtmemberName.WaterMark = "대여회원";
            this.TxtmemberName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtmemberName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtIdx
            // 
            // 
            // 
            // 
            this.TxtIdx.CustomButton.Image = null;
            this.TxtIdx.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.TxtIdx.CustomButton.Name = "";
            this.TxtIdx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtIdx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtIdx.CustomButton.TabIndex = 1;
            this.TxtIdx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtIdx.CustomButton.UseSelectable = true;
            this.TxtIdx.CustomButton.Visible = false;
            this.TxtIdx.Lines = new string[0];
            this.TxtIdx.Location = new System.Drawing.Point(91, 39);
            this.TxtIdx.MaxLength = 32767;
            this.TxtIdx.Name = "TxtIdx";
            this.TxtIdx.PasswordChar = '\0';
            this.TxtIdx.PromptText = "순번";
            this.TxtIdx.ReadOnly = true;
            this.TxtIdx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtIdx.SelectedText = "";
            this.TxtIdx.SelectionLength = 0;
            this.TxtIdx.SelectionStart = 0;
            this.TxtIdx.ShortcutsEnabled = true;
            this.TxtIdx.Size = new System.Drawing.Size(214, 23);
            this.TxtIdx.TabIndex = 3;
            this.TxtIdx.UseSelectable = true;
            this.TxtIdx.WaterMark = "순번";
            this.TxtIdx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtIdx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(20, 69);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "대여회원";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(48, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "순번";
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Location = new System.Drawing.Point(23, 63);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowTemplate.Height = 23;
            this.DgvData.Size = new System.Drawing.Size(349, 432);
            this.DgvData.TabIndex = 1;
            this.DgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellContentClick);
            // 
            // TxtReturnDate
            // 
            // 
            // 
            // 
            this.TxtReturnDate.CustomButton.Image = null;
            this.TxtReturnDate.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.TxtReturnDate.CustomButton.Name = "";
            this.TxtReturnDate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtReturnDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtReturnDate.CustomButton.TabIndex = 1;
            this.TxtReturnDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtReturnDate.CustomButton.UseSelectable = true;
            this.TxtReturnDate.CustomButton.Visible = false;
            this.TxtReturnDate.Lines = new string[0];
            this.TxtReturnDate.Location = new System.Drawing.Point(91, 163);
            this.TxtReturnDate.MaxLength = 32767;
            this.TxtReturnDate.Name = "TxtReturnDate";
            this.TxtReturnDate.PasswordChar = '\0';
            this.TxtReturnDate.PromptText = "반납일";
            this.TxtReturnDate.ReadOnly = true;
            this.TxtReturnDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtReturnDate.SelectedText = "";
            this.TxtReturnDate.SelectionLength = 0;
            this.TxtReturnDate.SelectionStart = 0;
            this.TxtReturnDate.ShortcutsEnabled = true;
            this.TxtReturnDate.Size = new System.Drawing.Size(214, 23);
            this.TxtReturnDate.TabIndex = 21;
            this.TxtReturnDate.UseSelectable = true;
            this.TxtReturnDate.WaterMark = "반납일";
            this.TxtReturnDate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtReturnDate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 518);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.GrbDetail);
            this.Name = "FrmRental";
            this.Text = "대여 관리";
            this.Load += new System.EventHandler(this.FrmDivCode_Load);
            this.Resize += new System.EventHandler(this.FrmDivCode_Resize);
            this.GrbDetail.ResumeLayout(false);
            this.GrbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbDetail;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnNew;
        private MetroFramework.Controls.MetroTextBox TxtmemberName;
        private MetroFramework.Controls.MetroTextBox TxtIdx;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridView DgvData;
        private MetroFramework.Controls.MetroLabel Label;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox TxtbookName;
        private MetroFramework.Controls.MetroDateTime DtpRentalDate;
        private System.Windows.Forms.Button BtnSearchMember;
        private System.Windows.Forms.Button BtnSeachBook;
        private MetroFramework.Controls.MetroComboBox CboRentalState;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox TxtReturnDate;
    }
}