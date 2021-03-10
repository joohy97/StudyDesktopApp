﻿
namespace ListViewApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RdbDetail = new System.Windows.Forms.RadioButton();
            this.RdbList = new System.Windows.Forms.RadioButton();
            this.RdbSmall = new System.Windows.Forms.RadioButton();
            this.RdbLarge = new System.Windows.Forms.RadioButton();
            this.LsvProduct = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSelected = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImgSmall = new System.Windows.Forms.ImageList(this.components);
            this.ImgLarge = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // RdbDetail
            // 
            this.RdbDetail.AutoSize = true;
            this.RdbDetail.Location = new System.Drawing.Point(79, 12);
            this.RdbDetail.Name = "RdbDetail";
            this.RdbDetail.Size = new System.Drawing.Size(59, 16);
            this.RdbDetail.TabIndex = 0;
            this.RdbDetail.TabStop = true;
            this.RdbDetail.Text = "자세히";
            this.RdbDetail.UseVisualStyleBackColor = true;
            this.RdbDetail.CheckedChanged += new System.EventHandler(this.RdbDetail_CheckedChanged);
            // 
            // RdbList
            // 
            this.RdbList.AutoSize = true;
            this.RdbList.Location = new System.Drawing.Point(167, 12);
            this.RdbList.Name = "RdbList";
            this.RdbList.Size = new System.Drawing.Size(59, 16);
            this.RdbList.TabIndex = 1;
            this.RdbList.TabStop = true;
            this.RdbList.Text = "리스트";
            this.RdbList.UseVisualStyleBackColor = true;
            this.RdbList.CheckedChanged += new System.EventHandler(this.RdbList_CheckedChanged);
            // 
            // RdbSmall
            // 
            this.RdbSmall.AutoSize = true;
            this.RdbSmall.Location = new System.Drawing.Point(255, 12);
            this.RdbSmall.Name = "RdbSmall";
            this.RdbSmall.Size = new System.Drawing.Size(87, 16);
            this.RdbSmall.TabIndex = 2;
            this.RdbSmall.TabStop = true;
            this.RdbSmall.Text = "작은 아이콘";
            this.RdbSmall.UseVisualStyleBackColor = true;
            this.RdbSmall.CheckedChanged += new System.EventHandler(this.RdbSmall_CheckedChanged);
            // 
            // RdbLarge
            // 
            this.RdbLarge.AutoSize = true;
            this.RdbLarge.Location = new System.Drawing.Point(371, 12);
            this.RdbLarge.Name = "RdbLarge";
            this.RdbLarge.Size = new System.Drawing.Size(75, 16);
            this.RdbLarge.TabIndex = 3;
            this.RdbLarge.TabStop = true;
            this.RdbLarge.Text = "큰 아이콘";
            this.RdbLarge.UseVisualStyleBackColor = true;
            this.RdbLarge.CheckedChanged += new System.EventHandler(this.RdbLarge_CheckedChanged);
            // 
            // LsvProduct
            // 
            this.LsvProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LsvProduct.FullRowSelect = true;
            this.LsvProduct.GridLines = true;
            this.LsvProduct.HideSelection = false;
            this.LsvProduct.LargeImageList = this.ImgLarge;
            this.LsvProduct.Location = new System.Drawing.Point(12, 34);
            this.LsvProduct.Name = "LsvProduct";
            this.LsvProduct.Size = new System.Drawing.Size(530, 260);
            this.LsvProduct.SmallImageList = this.ImgSmall;
            this.LsvProduct.TabIndex = 1;
            this.LsvProduct.UseCompatibleStateImageBehavior = false;
            this.LsvProduct.View = System.Windows.Forms.View.Details;
            this.LsvProduct.SelectedIndexChanged += new System.EventHandler(this.LsvProduct_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected";
            // 
            // TxtSelected
            // 
            this.TxtSelected.Location = new System.Drawing.Point(291, 308);
            this.TxtSelected.Name = "TxtSelected";
            this.TxtSelected.Size = new System.Drawing.Size(249, 21);
            this.TxtSelected.TabIndex = 3;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "제품명";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "단가";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "수량";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "금액";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 100;
            // 
            // ImgSmall
            // 
            this.ImgSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgSmall.ImageStream")));
            this.ImgSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgSmall.Images.SetKeyName(0, "controller.png");
            this.ImgSmall.Images.SetKeyName(1, "ds.png");
            this.ImgSmall.Images.SetKeyName(2, "ps4.png");
            this.ImgSmall.Images.SetKeyName(3, "remote.png");
            this.ImgSmall.Images.SetKeyName(4, "xbox.png");
            // 
            // ImgLarge
            // 
            this.ImgLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgLarge.ImageStream")));
            this.ImgLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgLarge.Images.SetKeyName(0, "controller.png");
            this.ImgLarge.Images.SetKeyName(1, "ds.png");
            this.ImgLarge.Images.SetKeyName(2, "ps4.png");
            this.ImgLarge.Images.SetKeyName(3, "remote.png");
            this.ImgLarge.Images.SetKeyName(4, "xbox.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 343);
            this.Controls.Add(this.TxtSelected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LsvProduct);
            this.Controls.Add(this.RdbLarge);
            this.Controls.Add(this.RdbSmall);
            this.Controls.Add(this.RdbList);
            this.Controls.Add(this.RdbDetail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RdbDetail;
        private System.Windows.Forms.RadioButton RdbList;
        private System.Windows.Forms.RadioButton RdbSmall;
        private System.Windows.Forms.RadioButton RdbLarge;
        private System.Windows.Forms.ListView LsvProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSelected;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ImageList ImgSmall;
        private System.Windows.Forms.ImageList ImgLarge;
    }
}

