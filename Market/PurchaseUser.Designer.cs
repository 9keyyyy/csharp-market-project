
namespace Market
{
    partial class PurchaseUser
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
            System.Windows.Forms.ColumnHeader columnHeader6;
            this.UserList = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "비번";
            columnHeader6.Width = 140;
            // 
            // UserList
            // 
            this.UserList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            columnHeader6,
            this.columnHeader8});
            this.UserList.FullRowSelect = true;
            this.UserList.GridLines = true;
            this.UserList.HideSelection = false;
            this.UserList.Location = new System.Drawing.Point(12, 12);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(489, 348);
            this.UserList.TabIndex = 3;
            this.UserList.UseCompatibleStateImageBehavior = false;
            this.UserList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "이름";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "아이디";
            this.columnHeader5.Width = 140;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "주소";
            this.columnHeader8.Width = 120;
            // 
            // PurchaseUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(517, 375);
            this.Controls.Add(this.UserList);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "PurchaseUser";
            this.Text = "PurchaseUser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView UserList;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}