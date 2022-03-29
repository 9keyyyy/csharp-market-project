
namespace Market
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabpage = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.btnAll = new System.Windows.Forms.Button();
            this.PostList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabLike = new System.Windows.Forms.TabPage();
            this.LikeList = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.tabMessage = new System.Windows.Forms.TabPage();
            this.MessageList = new System.Windows.Forms.ListView();
            this.sender = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.date = new System.Windows.Forms.ColumnHeader();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PurchaseList = new System.Windows.Forms.ListView();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UtxtID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UbtnEdit = new System.Windows.Forms.Button();
            this.UtxtAddr = new System.Windows.Forms.TextBox();
            this.UtxtName = new System.Windows.Forms.TextBox();
            this.UtxtPW = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.tabpage.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabLike.SuspendLayout();
            this.tabMessage.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabpage
            // 
            this.tabpage.Controls.Add(this.tabHome);
            this.tabpage.Controls.Add(this.tabLike);
            this.tabpage.Controls.Add(this.tabMessage);
            this.tabpage.Controls.Add(this.tabInfo);
            this.tabpage.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabpage.Location = new System.Drawing.Point(12, 12);
            this.tabpage.Name = "tabpage";
            this.tabpage.SelectedIndex = 0;
            this.tabpage.Size = new System.Drawing.Size(534, 585);
            this.tabpage.TabIndex = 0;
            this.tabpage.SelectedIndexChanged += new System.EventHandler(this.tabpage_SelectedIndexChanged);
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.PapayaWhip;
            this.tabHome.Controls.Add(this.btnAll);
            this.tabHome.Controls.Add(this.PostList);
            this.tabHome.Controls.Add(this.btnsearch);
            this.tabHome.Controls.Add(this.txtSearch);
            this.tabHome.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabHome.Location = new System.Drawing.Point(4, 29);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(526, 552);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "홈";
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAll.Location = new System.Drawing.Point(409, 519);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(94, 29);
            this.btnAll.TabIndex = 1;
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
            this.PostList.Location = new System.Drawing.Point(24, 63);
            this.PostList.Name = "PostList";
            this.PostList.Size = new System.Drawing.Size(479, 452);
            this.PostList.TabIndex = 5;
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
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnsearch.Location = new System.Drawing.Point(395, 15);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(108, 29);
            this.btnsearch.TabIndex = 4;
            this.btnsearch.Text = "검색";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(24, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(365, 27);
            this.txtSearch.TabIndex = 3;
            // 
            // tabLike
            // 
            this.tabLike.BackColor = System.Drawing.Color.PapayaWhip;
            this.tabLike.Controls.Add(this.LikeList);
            this.tabLike.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabLike.Location = new System.Drawing.Point(4, 29);
            this.tabLike.Name = "tabLike";
            this.tabLike.Padding = new System.Windows.Forms.Padding(3);
            this.tabLike.Size = new System.Drawing.Size(526, 552);
            this.tabLike.TabIndex = 1;
            this.tabLike.Text = "관심상품";
            // 
            // LikeList
            // 
            this.LikeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.LikeList.FullRowSelect = true;
            this.LikeList.GridLines = true;
            this.LikeList.HideSelection = false;
            this.LikeList.Location = new System.Drawing.Point(23, 16);
            this.LikeList.Name = "LikeList";
            this.LikeList.Size = new System.Drawing.Size(481, 493);
            this.LikeList.TabIndex = 6;
            this.LikeList.UseCompatibleStateImageBehavior = false;
            this.LikeList.View = System.Windows.Forms.View.Details;
            this.LikeList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LikeList_MouseDoubleClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "상품사진";
            this.columnHeader4.Width = 85;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "상품명";
            this.columnHeader5.Width = 250;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "상품가격";
            this.columnHeader6.Width = 120;
            // 
            // tabMessage
            // 
            this.tabMessage.BackColor = System.Drawing.Color.PapayaWhip;
            this.tabMessage.Controls.Add(this.MessageList);
            this.tabMessage.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabMessage.Location = new System.Drawing.Point(4, 29);
            this.tabMessage.Name = "tabMessage";
            this.tabMessage.Padding = new System.Windows.Forms.Padding(3);
            this.tabMessage.Size = new System.Drawing.Size(526, 552);
            this.tabMessage.TabIndex = 2;
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
            this.MessageList.Location = new System.Drawing.Point(18, 22);
            this.MessageList.Name = "MessageList";
            this.MessageList.Size = new System.Drawing.Size(489, 512);
            this.MessageList.TabIndex = 0;
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
            // tabInfo
            // 
            this.tabInfo.BackColor = System.Drawing.Color.PapayaWhip;
            this.tabInfo.Controls.Add(this.groupBox2);
            this.tabInfo.Controls.Add(this.groupBox1);
            this.tabInfo.Location = new System.Drawing.Point(4, 29);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(526, 552);
            this.tabInfo.TabIndex = 3;
            this.tabInfo.Text = "내정보";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.PurchaseList);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(27, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 315);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "구매목록";
            // 
            // PurchaseList
            // 
            this.PurchaseList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.PurchaseList.FullRowSelect = true;
            this.PurchaseList.GridLines = true;
            this.PurchaseList.HideSelection = false;
            this.PurchaseList.Location = new System.Drawing.Point(4, 26);
            this.PurchaseList.Name = "PurchaseList";
            this.PurchaseList.Size = new System.Drawing.Size(456, 283);
            this.PurchaseList.TabIndex = 1;
            this.PurchaseList.UseCompatibleStateImageBehavior = false;
            this.PurchaseList.View = System.Windows.Forms.View.Details;
            this.PurchaseList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PurchaseList_MouseDoubleClick);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "상품사진";
            this.columnHeader8.Width = 85;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "상품명";
            this.columnHeader9.Width = 250;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "상품가격";
            this.columnHeader10.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.UtxtID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.UbtnEdit);
            this.groupBox1.Controls.Add(this.UtxtAddr);
            this.groupBox1.Controls.Add(this.UtxtName);
            this.groupBox1.Controls.Add(this.UtxtPW);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(27, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "회원정보";
            // 
            // UtxtID
            // 
            this.UtxtID.AutoSize = true;
            this.UtxtID.Location = new System.Drawing.Point(167, 33);
            this.UtxtID.Name = "UtxtID";
            this.UtxtID.Size = new System.Drawing.Size(27, 20);
            this.UtxtID.TabIndex = 8;
            this.UtxtID.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "아이디    :";
            // 
            // UbtnEdit
            // 
            this.UbtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.UbtnEdit.Location = new System.Drawing.Point(187, 174);
            this.UbtnEdit.Name = "UbtnEdit";
            this.UbtnEdit.Size = new System.Drawing.Size(94, 29);
            this.UbtnEdit.TabIndex = 6;
            this.UbtnEdit.Text = "수정하기";
            this.UbtnEdit.UseVisualStyleBackColor = false;
            this.UbtnEdit.Click += new System.EventHandler(this.UbtnEdit_Click);
            // 
            // UtxtAddr
            // 
            this.UtxtAddr.Location = new System.Drawing.Point(167, 137);
            this.UtxtAddr.Name = "UtxtAddr";
            this.UtxtAddr.Size = new System.Drawing.Size(191, 27);
            this.UtxtAddr.TabIndex = 5;
            // 
            // UtxtName
            // 
            this.UtxtName.Location = new System.Drawing.Point(167, 101);
            this.UtxtName.Name = "UtxtName";
            this.UtxtName.Size = new System.Drawing.Size(191, 27);
            this.UtxtName.TabIndex = 4;
            // 
            // UtxtPW
            // 
            this.UtxtPW.Location = new System.Drawing.Point(167, 65);
            this.UtxtPW.Name = "UtxtPW";
            this.UtxtPW.Size = new System.Drawing.Size(191, 27);
            this.UtxtPW.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "주소       :";
 
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름       :";

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "비밀번호 :";

            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(30, 30);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(555, 600);
            this.Controls.Add(this.tabpage);
            this.Location = new System.Drawing.Point(200, 200);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Market";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.tabpage.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.tabLike.ResumeLayout(false);
            this.tabMessage.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabpage;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabLike;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabPage tabMessage;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.ListView PostList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView LikeList;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.ListView MessageList;
        private System.Windows.Forms.ColumnHeader sender;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UtxtName;
        private System.Windows.Forms.TextBox UtxtPW;
        private System.Windows.Forms.TextBox UtxtAddr;
        private System.Windows.Forms.Button UbtnEdit;
        private System.Windows.Forms.ListView PurchaseList;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.Label UtxtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

