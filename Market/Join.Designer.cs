
namespace Market
{
    partial class Join
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.JtxtID = new System.Windows.Forms.TextBox();
            this.JtxtPW = new System.Windows.Forms.TextBox();
            this.JtxtName = new System.Windows.Forms.TextBox();
            this.JtxtAddr = new System.Windows.Forms.TextBox();
            this.JbtnJoin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(59, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(59, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "비밀번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(59, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "이름";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(59, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "주소";
            // 
            // JtxtID
            // 
            this.JtxtID.Location = new System.Drawing.Point(156, 47);
            this.JtxtID.Name = "JtxtID";
            this.JtxtID.Size = new System.Drawing.Size(166, 27);
            this.JtxtID.TabIndex = 4;
            // 
            // JtxtPW
            // 
            this.JtxtPW.Location = new System.Drawing.Point(156, 96);
            this.JtxtPW.Name = "JtxtPW";
            this.JtxtPW.Size = new System.Drawing.Size(166, 27);
            this.JtxtPW.TabIndex = 5;
            // 
            // JtxtName
            // 
            this.JtxtName.Location = new System.Drawing.Point(156, 147);
            this.JtxtName.Name = "JtxtName";
            this.JtxtName.Size = new System.Drawing.Size(166, 27);
            this.JtxtName.TabIndex = 6;
            // 
            // JtxtAddr
            // 
            this.JtxtAddr.Location = new System.Drawing.Point(156, 201);
            this.JtxtAddr.Name = "JtxtAddr";
            this.JtxtAddr.Size = new System.Drawing.Size(166, 27);
            this.JtxtAddr.TabIndex = 7;
            // 
            // JbtnJoin
            // 
            this.JbtnJoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.JbtnJoin.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.JbtnJoin.Location = new System.Drawing.Point(156, 267);
            this.JbtnJoin.Name = "JbtnJoin";
            this.JbtnJoin.Size = new System.Drawing.Size(94, 29);
            this.JbtnJoin.TabIndex = 8;
            this.JbtnJoin.Text = "회원가입";
            this.JbtnJoin.UseVisualStyleBackColor = false;
            this.JbtnJoin.Click += new System.EventHandler(this.JbtnJoin_Click);
            // 
            // Join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(416, 348);
            this.Controls.Add(this.JbtnJoin);
            this.Controls.Add(this.JtxtAddr);
            this.Controls.Add(this.JtxtName);
            this.Controls.Add(this.JtxtPW);
            this.Controls.Add(this.JtxtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Join";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Join";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox JtxtID;
        private System.Windows.Forms.TextBox JtxtPW;
        private System.Windows.Forms.TextBox JtxtName;
        private System.Windows.Forms.TextBox JtxtAddr;
        private System.Windows.Forms.Button JbtnJoin;
    }
}