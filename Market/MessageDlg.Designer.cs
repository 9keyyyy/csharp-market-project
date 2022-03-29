
namespace Market
{
    partial class MessageDlg
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MBtxtContent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MBtxtTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MBtxtSender = new System.Windows.Forms.Label();
            this.MBbtnReply = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MBtxtTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MBtxtPtitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox1.Controls.Add(this.MBtxtContent);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(29, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "내용";
            // 
            // MBtxtContent
            // 
            this.MBtxtContent.AutoSize = true;
            this.MBtxtContent.Location = new System.Drawing.Point(21, 37);
            this.MBtxtContent.Name = "MBtxtContent";
            this.MBtxtContent.Size = new System.Drawing.Size(51, 20);
            this.MBtxtContent.TabIndex = 0;
            this.MBtxtContent.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "메시지 제목 : ";
            // 
            // MBtxtTitle
            // 
            this.MBtxtTitle.AutoSize = true;
            this.MBtxtTitle.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MBtxtTitle.Location = new System.Drawing.Point(127, 63);
            this.MBtxtTitle.Name = "MBtxtTitle";
            this.MBtxtTitle.Size = new System.Drawing.Size(51, 20);
            this.MBtxtTitle.TabIndex = 2;
            this.MBtxtTitle.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "보낸 사람 :";
            // 
            // MBtxtSender
            // 
            this.MBtxtSender.AutoSize = true;
            this.MBtxtSender.Location = new System.Drawing.Point(113, 92);
            this.MBtxtSender.Name = "MBtxtSender";
            this.MBtxtSender.Size = new System.Drawing.Size(51, 20);
            this.MBtxtSender.TabIndex = 4;
            this.MBtxtSender.Text = "label3";
            // 
            // MBbtnReply
            // 
            this.MBbtnReply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.MBbtnReply.Location = new System.Drawing.Point(189, 411);
            this.MBbtnReply.Name = "MBbtnReply";
            this.MBbtnReply.Size = new System.Drawing.Size(94, 29);
            this.MBbtnReply.TabIndex = 5;
            this.MBbtnReply.Text = "답장하기";
            this.MBbtnReply.UseVisualStyleBackColor = false;
            this.MBbtnReply.Click += new System.EventHandler(this.MBbtnReply_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "보낸 시간 : ";
            // 
            // MBtxtTime
            // 
            this.MBtxtTime.AutoSize = true;
            this.MBtxtTime.Location = new System.Drawing.Point(113, 122);
            this.MBtxtTime.Name = "MBtxtTime";
            this.MBtxtTime.Size = new System.Drawing.Size(51, 20);
            this.MBtxtTime.TabIndex = 7;
            this.MBtxtTime.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "상품글 제목 :";

            // 
            // MBtxtPtitle
            // 
            this.MBtxtPtitle.AutoSize = true;
            this.MBtxtPtitle.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MBtxtPtitle.Location = new System.Drawing.Point(125, 26);
            this.MBtxtPtitle.Name = "MBtxtPtitle";
            this.MBtxtPtitle.Size = new System.Drawing.Size(69, 28);
            this.MBtxtPtitle.TabIndex = 9;
            this.MBtxtPtitle.Text = "label2";
            // 
            // MessageDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(483, 469);
            this.Controls.Add(this.MBtxtPtitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MBtxtTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MBbtnReply);
            this.Controls.Add(this.MBtxtSender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MBtxtTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "MessageDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label MBtxtContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MBtxtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MBtxtSender;
        private System.Windows.Forms.Button MBbtnReply;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MBtxtTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label MBtxtPtitle;
    }
}