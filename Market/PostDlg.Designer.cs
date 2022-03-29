
namespace Market
{
    partial class PostDlg
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PtxtPrice = new System.Windows.Forms.Label();
            this.PtxtContent = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PbtnPurchase = new System.Windows.Forms.Button();
            this.PbtnAsk = new System.Windows.Forms.Button();
            this.PtxtStock = new System.Windows.Forms.Label();
            this.PbtnLike = new System.Windows.Forms.Button();
            this.ProductName = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ProductName.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 272);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "가격 :";
            // 
            // PtxtPrice
            // 
            this.PtxtPrice.AutoSize = true;
            this.PtxtPrice.Location = new System.Drawing.Point(77, 37);
            this.PtxtPrice.Name = "PtxtPrice";
            this.PtxtPrice.Size = new System.Drawing.Size(18, 20);
            this.PtxtPrice.TabIndex = 3;
            this.PtxtPrice.Text = "0";
            // 
            // PtxtContent
            // 
            this.PtxtContent.Location = new System.Drawing.Point(24, 97);
            this.PtxtContent.Name = "PtxtContent";
            this.PtxtContent.Size = new System.Drawing.Size(190, 45);
            this.PtxtContent.TabIndex = 4;
            this.PtxtContent.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "상세내용 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "재고 :";
            // 
            // PbtnPurchase
            // 
            this.PbtnPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PbtnPurchase.Location = new System.Drawing.Point(285, 237);
            this.PbtnPurchase.Name = "PbtnPurchase";
            this.PbtnPurchase.Size = new System.Drawing.Size(94, 29);
            this.PbtnPurchase.TabIndex = 7;
            this.PbtnPurchase.Text = "구매하기";
            this.PbtnPurchase.UseVisualStyleBackColor = false;
            this.PbtnPurchase.Click += new System.EventHandler(this.PbtnPurchase_Click);
            // 
            // PbtnAsk
            // 
            this.PbtnAsk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PbtnAsk.Location = new System.Drawing.Point(395, 237);
            this.PbtnAsk.Name = "PbtnAsk";
            this.PbtnAsk.Size = new System.Drawing.Size(119, 29);
            this.PbtnAsk.TabIndex = 8;
            this.PbtnAsk.Text = "상품 문의하기";
            this.PbtnAsk.UseVisualStyleBackColor = false;
            this.PbtnAsk.Click += new System.EventHandler(this.PbtnAsk_Click);
            // 
            // PtxtStock
            // 
            this.PtxtStock.AutoSize = true;
            this.PtxtStock.Location = new System.Drawing.Point(77, 151);
            this.PtxtStock.Name = "PtxtStock";
            this.PtxtStock.Size = new System.Drawing.Size(18, 20);
            this.PtxtStock.TabIndex = 9;
            this.PtxtStock.Text = "0";
            // 
            // PbtnLike
            // 
            this.PbtnLike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PbtnLike.Location = new System.Drawing.Point(285, 272);
            this.PbtnLike.Name = "PbtnLike";
            this.PbtnLike.Size = new System.Drawing.Size(229, 29);
            this.PbtnLike.TabIndex = 10;
            this.PbtnLike.Text = "관심 목록 추가하기";
            this.PbtnLike.UseVisualStyleBackColor = false;
            this.PbtnLike.Click += new System.EventHandler(this.PbtnLike_Click);
            // 
            // ProductName
            // 
            this.ProductName.BackColor = System.Drawing.Color.PapayaWhip;
            this.ProductName.Controls.Add(this.label5);
            this.ProductName.Controls.Add(this.PtxtStock);
            this.ProductName.Controls.Add(this.label2);
            this.ProductName.Controls.Add(this.PtxtPrice);
            this.ProductName.Controls.Add(this.PtxtContent);
            this.ProductName.Controls.Add(this.label6);
            this.ProductName.Location = new System.Drawing.Point(283, 29);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(231, 188);
            this.ProductName.TabIndex = 11;
            this.ProductName.TabStop = false;
            this.ProductName.Text = "groupBox1";
            // 
            // PostDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(549, 336);
            this.Controls.Add(this.PbtnLike);
            this.Controls.Add(this.PbtnAsk);
            this.Controls.Add(this.PbtnPurchase);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ProductName);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "PostDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PostDlg";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ProductName.ResumeLayout(false);
            this.ProductName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PtxtPrice;
        private System.Windows.Forms.Label PtxtContent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button PbtnPurchase;
        private System.Windows.Forms.Button PbtnAsk;
        private System.Windows.Forms.Label PtxtStock;
        private System.Windows.Forms.Button PbtnLike;
        private System.Windows.Forms.GroupBox ProductName;
    }
}