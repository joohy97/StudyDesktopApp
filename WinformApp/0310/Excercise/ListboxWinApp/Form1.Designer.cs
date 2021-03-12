
namespace ListboxWinApp
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
            this.Lsb1 = new System.Windows.Forms.ListBox();
            this.Lsb2 = new System.Windows.Forms.ListBox();
            this.Lsb3 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtInd1 = new System.Windows.Forms.TextBox();
            this.TxtItem1 = new System.Windows.Forms.TextBox();
            this.TxtInd2 = new System.Windows.Forms.TextBox();
            this.TxtItem2 = new System.Windows.Forms.TextBox();
            this.TxtInd3 = new System.Windows.Forms.TextBox();
            this.TxtItem3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnInit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lsb1
            // 
            this.Lsb1.FormattingEnabled = true;
            this.Lsb1.ItemHeight = 12;
            this.Lsb1.Items.AddRange(new object[] {
            "미국",
            "러시아",
            "중국",
            "영국",
            "독일",
            "프랑스",
            "일본",
            "이스라엘",
            "사우디아라비아",
            "UAE",
            "한국",
            "필리핀"});
            this.Lsb1.Location = new System.Drawing.Point(116, 43);
            this.Lsb1.Name = "Lsb1";
            this.Lsb1.Size = new System.Drawing.Size(145, 220);
            this.Lsb1.TabIndex = 0;
            this.Lsb1.SelectedIndexChanged += new System.EventHandler(this.Lsb1_SelectedIndexChanged);
            // 
            // Lsb2
            // 
            this.Lsb2.FormattingEnabled = true;
            this.Lsb2.ItemHeight = 12;
            this.Lsb2.Location = new System.Drawing.Point(284, 43);
            this.Lsb2.Name = "Lsb2";
            this.Lsb2.Size = new System.Drawing.Size(145, 220);
            this.Lsb2.TabIndex = 0;
            this.Lsb2.SelectedIndexChanged += new System.EventHandler(this.Lsb2_SelectedIndexChanged);
            // 
            // Lsb3
            // 
            this.Lsb3.FormattingEnabled = true;
            this.Lsb3.ItemHeight = 12;
            this.Lsb3.Location = new System.Drawing.Point(452, 43);
            this.Lsb3.Name = "Lsb3";
            this.Lsb3.Size = new System.Drawing.Size(145, 220);
            this.Lsb3.TabIndex = 0;
            this.Lsb3.SelectedIndexChanged += new System.EventHandler(this.Lsb3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "GDP 순위";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "살기 좋은 도시";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "행복한 나라";
            // 
            // TxtInd1
            // 
            this.TxtInd1.Location = new System.Drawing.Point(116, 280);
            this.TxtInd1.Name = "TxtInd1";
            this.TxtInd1.Size = new System.Drawing.Size(145, 21);
            this.TxtInd1.TabIndex = 2;
            // 
            // TxtItem1
            // 
            this.TxtItem1.Location = new System.Drawing.Point(116, 307);
            this.TxtItem1.Name = "TxtItem1";
            this.TxtItem1.Size = new System.Drawing.Size(145, 21);
            this.TxtItem1.TabIndex = 2;
            // 
            // TxtInd2
            // 
            this.TxtInd2.Location = new System.Drawing.Point(284, 280);
            this.TxtInd2.Name = "TxtInd2";
            this.TxtInd2.Size = new System.Drawing.Size(145, 21);
            this.TxtInd2.TabIndex = 2;
            // 
            // TxtItem2
            // 
            this.TxtItem2.Location = new System.Drawing.Point(284, 307);
            this.TxtItem2.Name = "TxtItem2";
            this.TxtItem2.Size = new System.Drawing.Size(145, 21);
            this.TxtItem2.TabIndex = 2;
            // 
            // TxtInd3
            // 
            this.TxtInd3.Location = new System.Drawing.Point(452, 280);
            this.TxtInd3.Name = "TxtInd3";
            this.TxtInd3.Size = new System.Drawing.Size(145, 21);
            this.TxtInd3.TabIndex = 2;
            // 
            // TxtItem3
            // 
            this.TxtItem3.Location = new System.Drawing.Point(452, 307);
            this.TxtItem3.Name = "TxtItem3";
            this.TxtItem3.Size = new System.Drawing.Size(145, 21);
            this.TxtItem3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Selected Index :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Selected Item :";
            // 
            // BtnInit
            // 
            this.BtnInit.Location = new System.Drawing.Point(22, 240);
            this.BtnInit.Name = "BtnInit";
            this.BtnInit.Size = new System.Drawing.Size(75, 23);
            this.BtnInit.TabIndex = 5;
            this.BtnInit.Text = "초기화";
            this.BtnInit.UseVisualStyleBackColor = true;
            this.BtnInit.Click += new System.EventHandler(this.BtnInit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 359);
            this.Controls.Add(this.BtnInit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtItem3);
            this.Controls.Add(this.TxtInd3);
            this.Controls.Add(this.TxtItem2);
            this.Controls.Add(this.TxtInd2);
            this.Controls.Add(this.TxtItem1);
            this.Controls.Add(this.TxtInd1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lsb3);
            this.Controls.Add(this.Lsb2);
            this.Controls.Add(this.Lsb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lsb1;
        private System.Windows.Forms.ListBox Lsb2;
        private System.Windows.Forms.ListBox Lsb3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtInd1;
        private System.Windows.Forms.TextBox TxtItem1;
        private System.Windows.Forms.TextBox TxtInd2;
        private System.Windows.Forms.TextBox TxtItem2;
        private System.Windows.Forms.TextBox TxtInd3;
        private System.Windows.Forms.TextBox TxtItem3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnInit;
    }
}

