﻿
namespace RestaurantSelApp
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
            this.LblResult = new System.Windows.Forms.Label();
            this.CboRes = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "좋아하는 식당 리스트";
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(33, 153);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(105, 12);
            this.LblResult.TabIndex = 0;
            this.LblResult.Text = "이번 주 모임장소 :";
            // 
            // CboRes
            // 
            this.CboRes.FormattingEnabled = true;
            this.CboRes.Location = new System.Drawing.Point(35, 51);
            this.CboRes.Name = "CboRes";
            this.CboRes.Size = new System.Drawing.Size(190, 20);
            this.CboRes.TabIndex = 1;
            this.CboRes.SelectedIndexChanged += new System.EventHandler(this.CboRes_SelectedIndexChanged);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(259, 48);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "추가";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(259, 86);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(75, 23);
            this.BtnDel.TabIndex = 2;
            this.BtnDel.Text = "삭제";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 212);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.CboRes);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.ComboBox CboRes;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDel;
    }
}
