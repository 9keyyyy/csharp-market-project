
namespace Market
{
    partial class MessageSend
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
            this.MtxtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MtxtContent = new System.Windows.Forms.TextBox();
            this.MtxtProduct = new System.Windows.Forms.Label();
            this.MbtnSend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MtxtReceiver = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MtxtTitle
            // 
            this.MtxtTitle.Location = new System.Drawing.Point(93, 85);
            this.MtxtTitle.Name = "MtxtTitle";
            this.MtxtTitle.Size = new System.Drawing.Size(417, 27);
            this.MtxtTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "제목 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "내용";
            // 
            // MtxtContent
            // 
            this.MtxtContent.Location = new System.Drawing.Point(37, 145);
            this.MtxtContent.Multiline = true;
            this.MtxtContent.Name = "MtxtContent";
            this.MtxtContent.Size = new System.Drawing.Size(473, 199);
            this.MtxtContent.TabIndex = 3;
            // 
            // MtxtProduct
            // 
            this.MtxtProduct.AutoSize = true;
            this.MtxtProduct.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MtxtProduct.Location = new System.Drawing.Point(37, 17);
            this.MtxtProduct.Name = "MtxtProduct";
            this.MtxtProduct.Size = new System.Drawing.Size(52, 28);
            this.MtxtProduct.TabIndex = 4;
            this.MtxtProduct.Text = "상품";
            // 
            // MbtnSend
            // 
            this.MbtnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.MbtnSend.Location = new System.Drawing.Point(219, 361);
            this.MbtnSend.Name = "MbtnSend";
            this.MbtnSend.Size = new System.Drawing.Size(94, 29);
            this.MbtnSend.TabIndex = 5;
            this.MbtnSend.Text = "보내기";
            this.MbtnSend.UseVisualStyleBackColor = false;
            this.MbtnSend.Click += new System.EventHandler(this.MbtnSend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "받는 사람 :";
            // 
            // MtxtReceiver
            // 
            this.MtxtReceiver.AutoSize = true;
            this.MtxtReceiver.Location = new System.Drawing.Point(122, 55);
            this.MtxtReceiver.Name = "MtxtReceiver";
            this.MtxtReceiver.Size = new System.Drawing.Size(18, 20);
            this.MtxtReceiver.TabIndex = 7;
            this.MtxtReceiver.Text = "0";
            // 
            // MessageSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(556, 411);
            this.Controls.Add(this.MtxtReceiver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MbtnSend);
            this.Controls.Add(this.MtxtProduct);
            this.Controls.Add(this.MtxtContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MtxtTitle);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "MessageSend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageSend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MtxtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MtxtContent;
        private System.Windows.Forms.Label MtxtProduct;
        private System.Windows.Forms.Button MbtnSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MtxtReceiver;
    }
}