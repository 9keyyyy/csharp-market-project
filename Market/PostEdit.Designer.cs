
namespace Market
{
    partial class PostEdit
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
            this.PbtnShow = new System.Windows.Forms.Button();
            this.PbtnSave = new System.Windows.Forms.Button();
            this.PbtnAddpic = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EtxtTitle = new System.Windows.Forms.TextBox();
            this.EtxtPrice = new System.Windows.Forms.TextBox();
            this.EtxtContent = new System.Windows.Forms.TextBox();
            this.EtxtStock = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PbtnShow
            // 
            this.PbtnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PbtnShow.Location = new System.Drawing.Point(273, 272);
            this.PbtnShow.Name = "PbtnShow";
            this.PbtnShow.Size = new System.Drawing.Size(229, 29);
            this.PbtnShow.TabIndex = 21;
            this.PbtnShow.Text = "구매 목록 보기";
            this.PbtnShow.UseVisualStyleBackColor = false;
            this.PbtnShow.Click += new System.EventHandler(this.PbtnShow_Click);
            // 
            // PbtnSave
            // 
            this.PbtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PbtnSave.Location = new System.Drawing.Point(383, 237);
            this.PbtnSave.Name = "PbtnSave";
            this.PbtnSave.Size = new System.Drawing.Size(119, 29);
            this.PbtnSave.TabIndex = 19;
            this.PbtnSave.Text = "저장하기";
            this.PbtnSave.UseVisualStyleBackColor = false;
            this.PbtnSave.Click += new System.EventHandler(this.PbtnSave_Click);
            // 
            // PbtnAddpic
            // 
            this.PbtnAddpic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PbtnAddpic.Location = new System.Drawing.Point(273, 237);
            this.PbtnAddpic.Name = "PbtnAddpic";
            this.PbtnAddpic.Size = new System.Drawing.Size(94, 29);
            this.PbtnAddpic.TabIndex = 18;
            this.PbtnAddpic.Text = "사진추가";
            this.PbtnAddpic.UseVisualStyleBackColor = false;
            this.PbtnAddpic.Click += new System.EventHandler(this.PbtnAddpic_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "재고       :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "상세내용 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "가격       :";
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProductName.Location = new System.Drawing.Point(254, 60);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(88, 20);
            this.ProductName.TabIndex = 12;
            this.ProductName.Text = "상품 이름 : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(26, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 272);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // EtxtTitle
            // 
            this.EtxtTitle.Location = new System.Drawing.Point(337, 57);
            this.EtxtTitle.Name = "EtxtTitle";
            this.EtxtTitle.Size = new System.Drawing.Size(178, 27);
            this.EtxtTitle.TabIndex = 22;
            // 
            // EtxtPrice
            // 
            this.EtxtPrice.Location = new System.Drawing.Point(337, 99);
            this.EtxtPrice.Name = "EtxtPrice";
            this.EtxtPrice.Size = new System.Drawing.Size(178, 27);
            this.EtxtPrice.TabIndex = 23;
            // 
            // EtxtContent
            // 
            this.EtxtContent.Location = new System.Drawing.Point(337, 139);
            this.EtxtContent.Name = "EtxtContent";
            this.EtxtContent.Size = new System.Drawing.Size(178, 27);
            this.EtxtContent.TabIndex = 24;
            // 
            // EtxtStock
            // 
            this.EtxtStock.Location = new System.Drawing.Point(337, 182);
            this.EtxtStock.Name = "EtxtStock";
            this.EtxtStock.Size = new System.Drawing.Size(178, 27);
            this.EtxtStock.TabIndex = 25;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PostEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(549, 336);
            this.Controls.Add(this.EtxtStock);
            this.Controls.Add(this.EtxtContent);
            this.Controls.Add(this.EtxtPrice);
            this.Controls.Add(this.EtxtTitle);
            this.Controls.Add(this.PbtnShow);
            this.Controls.Add(this.PbtnSave);
            this.Controls.Add(this.PbtnAddpic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "PostEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PostEdit";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PbtnShow;
        private System.Windows.Forms.Button PbtnSave;
        private System.Windows.Forms.Button PbtnAddpic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox EtxtTitle;
        private System.Windows.Forms.TextBox EtxtPrice;
        private System.Windows.Forms.TextBox EtxtContent;
        private System.Windows.Forms.TextBox EtxtStock;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}