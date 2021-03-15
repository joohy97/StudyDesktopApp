
namespace AddressInfoApp
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvAddress = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnInitial = new System.Windows.Forms.Button();
            this.TxtIdx = new System.Windows.Forms.TextBox();
            this.TxtFullName = new System.Windows.Forms.TextBox();
            this.TxtAddr = new System.Windows.Forms.TextBox();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TxtMobile = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAddress)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvAddress
            // 
            this.DgvAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAddress.Location = new System.Drawing.Point(12, 12);
            this.DgvAddress.Name = "DgvAddress";
            this.DgvAddress.RowTemplate.Height = 23;
            this.DgvAddress.Size = new System.Drawing.Size(598, 210);
            this.DgvAddress.TabIndex = 7;
            this.DgvAddress.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAddress_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtMobile);
            this.groupBox1.Controls.Add(this.BtnDelete);
            this.groupBox1.Controls.Add(this.BtnUpdate);
            this.groupBox1.Controls.Add(this.BtnInsert);
            this.groupBox1.Controls.Add(this.TxtAddr);
            this.groupBox1.Controls.Add(this.TxtFullName);
            this.groupBox1.Controls.Add(this.TxtIdx);
            this.groupBox1.Controls.Add(this.BtnInitial);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 133);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "입력창";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Idx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "핸드폰";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "주소";
            // 
            // BtnInitial
            // 
            this.BtnInitial.Location = new System.Drawing.Point(385, 24);
            this.BtnInitial.Name = "BtnInitial";
            this.BtnInitial.Size = new System.Drawing.Size(91, 42);
            this.BtnInitial.TabIndex = 3;
            this.BtnInitial.Text = "초기화";
            this.BtnInitial.UseVisualStyleBackColor = true;
            this.BtnInitial.Click += new System.EventHandler(this.BtnInitial_Click);
            // 
            // TxtIdx
            // 
            this.TxtIdx.Location = new System.Drawing.Point(71, 26);
            this.TxtIdx.Name = "TxtIdx";
            this.TxtIdx.ReadOnly = true;
            this.TxtIdx.Size = new System.Drawing.Size(100, 21);
            this.TxtIdx.TabIndex = 8;
            // 
            // TxtFullName
            // 
            this.TxtFullName.Location = new System.Drawing.Point(260, 26);
            this.TxtFullName.MaxLength = 12;
            this.TxtFullName.Name = "TxtFullName";
            this.TxtFullName.Size = new System.Drawing.Size(100, 21);
            this.TxtFullName.TabIndex = 0;
            this.TxtFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFullName_KeyPress);
            // 
            // TxtAddr
            // 
            this.TxtAddr.Location = new System.Drawing.Point(71, 94);
            this.TxtAddr.MaxLength = 200;
            this.TxtAddr.Name = "TxtAddr";
            this.TxtAddr.Size = new System.Drawing.Size(289, 21);
            this.TxtAddr.TabIndex = 2;
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(385, 77);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(91, 42);
            this.BtnInsert.TabIndex = 5;
            this.BtnInsert.Text = "추가";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(492, 24);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(91, 42);
            this.BtnUpdate.TabIndex = 4;
            this.BtnUpdate.Text = "수정";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(492, 77);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(91, 42);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "삭제";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TxtMobile
            // 
            this.TxtMobile.Location = new System.Drawing.Point(71, 60);
            this.TxtMobile.Mask = "000-9000-0000";
            this.TxtMobile.Name = "TxtMobile";
            this.TxtMobile.Size = new System.Drawing.Size(100, 21);
            this.TxtMobile.TabIndex = 1;
            this.TxtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMobile_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 373);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvAddress);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "주소록 앱";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAddress)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox TxtMobile;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.TextBox TxtAddr;
        private System.Windows.Forms.TextBox TxtFullName;
        private System.Windows.Forms.TextBox TxtIdx;
        private System.Windows.Forms.Button BtnInitial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

