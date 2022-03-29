
namespace Market
{
    partial class Login
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.strID = new System.Windows.Forms.Label();
            this.strPW = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLogin.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(117, 154);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 29);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnJoin.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnJoin.Location = new System.Drawing.Point(242, 154);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(94, 29);
            this.btnJoin.TabIndex = 1;
            this.btnJoin.Text = "회원가입";
            this.btnJoin.UseVisualStyleBackColor = false;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(165, 101);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(219, 27);
            this.txtPW.TabIndex = 3;
            // 
            // strID
            // 
            this.strID.AutoSize = true;
            this.strID.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.strID.Location = new System.Drawing.Point(72, 55);
            this.strID.Name = "strID";
            this.strID.Size = new System.Drawing.Size(54, 20);
            this.strID.TabIndex = 4;
            this.strID.Text = "아이디";
            // 
            // strPW
            // 
            this.strPW.AutoSize = true;
            this.strPW.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.strPW.Location = new System.Drawing.Point(72, 105);
            this.strPW.Name = "strPW";
            this.strPW.Size = new System.Drawing.Size(69, 20);
            this.strPW.TabIndex = 5;
            this.strPW.Text = "비밀번호";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(165, 48);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(219, 27);
            this.txtID.TabIndex = 2;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAdmin.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdmin.Location = new System.Drawing.Point(117, 199);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(219, 29);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "Go Admin Page";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(465, 251);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.strPW);
            this.Controls.Add(this.strID);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnLogin);
            this.Location = new System.Drawing.Point(600, 400);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label strPW;
        private System.Windows.Forms.Label strID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnAdmin;
    }
}