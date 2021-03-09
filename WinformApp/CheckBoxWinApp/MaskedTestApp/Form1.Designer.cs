
namespace MaskedTestApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDate = new System.Windows.Forms.MaskedTextBox();
            this.TxtAddnum = new System.Windows.Forms.MaskedTextBox();
            this.TxtEmail = new System.Windows.Forms.MaskedTextBox();
            this.TxtAddr = new System.Windows.Forms.MaskedTextBox();
            this.TxtID = new System.Windows.Forms.MaskedTextBox();
            this.TxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "입사일";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "우편번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "주소";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "휴대폰번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "주민번호";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "이메일";
            // 
            // TxtDate
            // 
            this.TxtDate.Location = new System.Drawing.Point(93, 37);
            this.TxtDate.Mask = "0000-00-00";
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(172, 21);
            this.TxtDate.TabIndex = 6;
            this.TxtDate.ValidatingType = typeof(System.DateTime);
            // 
            // TxtAddnum
            // 
            this.TxtAddnum.Location = new System.Drawing.Point(93, 72);
            this.TxtAddnum.Name = "TxtAddnum";
            this.TxtAddnum.Size = new System.Drawing.Size(172, 21);
            this.TxtAddnum.TabIndex = 7;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(93, 212);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(172, 21);
            this.TxtEmail.TabIndex = 10;
            // 
            // TxtAddr
            // 
            this.TxtAddr.Location = new System.Drawing.Point(93, 107);
            this.TxtAddr.Name = "TxtAddr";
            this.TxtAddr.Size = new System.Drawing.Size(172, 21);
            this.TxtAddr.TabIndex = 11;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(93, 177);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(172, 21);
            this.TxtID.TabIndex = 12;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(93, 142);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(172, 21);
            this.TxtPhone.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 55);
            this.button1.TabIndex = 14;
            this.button1.Text = "등록";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 318);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.TxtAddr);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtAddnum);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox TxtDate;
        private System.Windows.Forms.MaskedTextBox TxtAddnum;
        private System.Windows.Forms.MaskedTextBox TxtEmail;
        private System.Windows.Forms.MaskedTextBox TxtAddr;
        private System.Windows.Forms.MaskedTextBox TxtID;
        private System.Windows.Forms.MaskedTextBox TxtPhone;
        private System.Windows.Forms.Button button1;
    }
}

