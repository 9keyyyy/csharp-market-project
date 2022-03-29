
namespace Market
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ColumnHeader columnHeader6;
            this.admintab = new System.Windows.Forms.TabControl();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.btnAddPost = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.PostList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.tabMessage = new System.Windows.Forms.TabPage();
            this.MessageList = new System.Windows.Forms.ListView();
            this.sender = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.date = new System.Windows.Forms.ColumnHeader();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.AbtnAddUser = new System.Windows.Forms.Button();
            this.UserList = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.admintab.SuspendLayout();
            this.tabProduct.SuspendLayout();
            this.tabMessage.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "비번";
            columnHeader6.Width = 140;
            // 
            // admintab
            // 
            this.admintab.Controls.Add(this.tabProduct);
            this.admintab.Controls.Add(this.tabMessage);
            this.admintab.Controls.Add(this.tabUser);
            this.admintab.Location = new System.Drawing.Point(12, 12);
            this.admintab.Name = "admintab";
            this.admintab.SelectedIndex = 0;
            this.admintab.Size = new System.Drawing.Size(531, 585);
            this.admintab.TabIndex = 0;
            this.admintab.SelectedIndexChanged += new System.EventHandler(this.admintab_SelectedIndexChanged);
            // 
            // tabProduct
            // 
            this.tabProduct.BackColor = System.Drawing.Color.PapayaWhip;
            this.tabProduct.Controls.Add(this.btnAddPost);
            this.tabProduct.Controls.Add(this.btnAll);
            this.tabProduct.Controls.Add(this.PostList);
            this.tabProduct.Controls.Add(this.txtSearch);
            this.tabProduct.Controls.Add(this.btnsearch);
            this.tabProduct.Location = new System.Drawing.Point(4, 29);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduct.Size = new System.Drawing.Size(523, 552);
            this.tabProduct.TabIndex = 0;
            this.tabProduct.Text = "상품 관리";
            // 
            // btnAddPost
            // 
            this.btnAddPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddPost.Location = new System.Drawing.Point(22, 516);
            this.btnAddPost.Name = "btnAddPost";
            this.btnAddPost.Size = new System.Drawing.Size(127, 29);
            this.btnAddPost.TabIndex = 10;
            this.btnAddPost.Text = "상품 추가하기";
            this.btnAddPost.UseVisualStyleBackColor = false;
            this.btnAddPost.Click += new System.EventHandler(this.btnAddPost_Click);
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAll.Location = new System.Drawing.Point(407, 516);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(94, 29);
            this.btnAll.TabIndex = 6;
            this.btnAll.Text = "전체보기";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // PostList
            // 
            this.PostList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.PostList.FullRowSelect = true;
            this.PostList.GridLines = true;
            this.PostList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.PostList.HideSelection = false;
            this.PostList.Location = new System.Drawing.Point(22, 60);
            this.PostList.Name = "PostList";
            this.PostList.Size = new System.Drawing.Size(479, 452);
            this.PostList.TabIndex = 9;
            this.PostList.UseCompatibleStateImageBehavior = false;
            this.PostList.View = System.Windows.Forms.View.Details;
            this.PostList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PostList_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "상품사진";
            this.columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "상품명";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "상품가격";
            this.columnHeader3.Width = 120;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(22, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(365, 27);
            this.txtSearch.TabIndex = 7;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnsearch.Location = new System.Drawing.Point(393, 12);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(108, 29);
            this.btnsearch.TabIndex = 8;
            this.btnsearch.Text = "검색";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // tabMessage
            // 
            this.tabMessage.BackColor = System.Drawing.Color.PapayaWhip;
            this.tabMessage.Controls.Add(this.MessageList);
            this.tabMessage.Location = new System.Drawing.Point(4, 29);
            this.tabMessage.Name = "tabMessage";
            this.tabMessage.Padding = new System.Windows.Forms.Padding(3);
            this.tabMessage.Size = new System.Drawing.Size(523, 552);
            this.tabMessage.TabIndex = 1;
            this.tabMessage.Text = "쪽지함";
            // 
            // MessageList
            // 
            this.MessageList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sender,
            this.columnHeader7,
            this.date});
            this.MessageList.FullRowSelect = true;
            this.MessageList.GridLines = true;
            this.MessageList.HideSelection = false;
            this.MessageList.Location = new System.Drawing.Point(15, 19);
            this.MessageList.Name = "MessageList";
            this.MessageList.Size = new System.Drawing.Size(489, 512);
            this.MessageList.TabIndex = 1;
            this.MessageList.UseCompatibleStateImageBehavior = false;
            this.MessageList.View = System.Windows.Forms.View.Details;
            this.MessageList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MessageList_MouseDoubleClick);
            // 
            // sender
            // 
            this.sender.Text = "보낸사람";
            this.sender.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "제목";
            this.columnHeader7.Width = 250;
            // 
            // date
            // 
            this.date.Text = "날짜";
            this.date.Width = 145;
            // 
            // tabUser
            // 
            this.tabUser.BackColor = System.Drawing.Color.PapayaWhip;
            this.tabUser.Controls.Add(this.AbtnAddUser);
            this.tabUser.Controls.Add(this.UserList);
            this.tabUser.Location = new System.Drawing.Point(4, 29);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(523, 552);
            this.tabUser.TabIndex = 2;
            this.tabUser.Text = "회원 관리";
            // 
            // AbtnAddUser
            // 
            this.AbtnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.AbtnAddUser.Location = new System.Drawing.Point(412, 515);
            this.AbtnAddUser.Name = "AbtnAddUser";
            this.AbtnAddUser.Size = new System.Drawing.Size(94, 29);
            this.AbtnAddUser.TabIndex = 3;
            this.AbtnAddUser.Text = "회원추가";
            this.AbtnAddUser.UseVisualStyleBackColor = false;
            this.AbtnAddUser.Click += new System.EventHandler(this.AbtnAddUser_Click);
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
            this.UserList.Location = new System.Drawing.Point(17, 20);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(489, 489);
            this.UserList.TabIndex = 2;
            this.UserList.UseCompatibleStateImageBehavior = false;
            this.UserList.View = System.Windows.Forms.View.Details;
            this.UserList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UserList_MouseDoubleClick);
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
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(555, 600);
            this.Controls.Add(this.admintab);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.admintab.ResumeLayout(false);
            this.tabProduct.ResumeLayout(false);
            this.tabProduct.PerformLayout();
            this.tabMessage.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl admintab;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.TabPage tabMessage;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.ListView PostList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.Button btnAddPost;
        private System.Windows.Forms.ListView MessageList;
        private System.Windows.Forms.ColumnHeader sender;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ListView UserList;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button AbtnAddUser;
    }
}