using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market
{
    

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            btnAll.Visible = false;

            PostList.Items.Clear();
            imageList1.ImageSize = new Size(80, 80);
            int i = 0;
            foreach (var p in DataManager.Posts) {
                imageList1.Images.Add(Image.FromFile(p.Imageurl));
                ListViewItem item = new ListViewItem("", i++);
                item.Tag = p.ID;
                item.SubItems.Add(p.Title);
                item.SubItems.Add(p.Price);
                PostList.Items.Add(item);
            }
            PostList.SmallImageList = imageList1;


            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 60);
            foreach (var p in DataManager.Messages)
            {
                //MessageBox.Show(Convert.ToString(p.ReceiverID), Convert.ToString(DataManager.LoginUser.ID));
                if(DataManager.Users.Exists((x) => x.ID == DataManager.LoginUser.ID && p.ReceiverID == x.ID))
                {
                    ListViewItem item = new ListViewItem(DataManager.Users.Single((x) => x.ID == p.SenderID).Name);
                    item.Tag = p.ID;
                    item.SubItems.Add(p.Title);
                    item.SubItems.Add(p.Time);
                    MessageList.Items.Add(item);
                }
            }
            MessageList.SmallImageList = imgList;

        }


        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            btnAll.Visible = true;
            PostList.Items.Clear();
            imageList1.Images.Clear();
            imageList1.ImageSize = new Size(80, 80);
            int i = 0;
            foreach (var p in DataManager.Posts)
            {
                //MessageBox.Show(Convert.ToString(p.Title.Contains(txtSearch.Text)));
                if (p.Title.Contains(txtSearch.Text)) {
                    imageList1.Images.Add(Image.FromFile(p.Imageurl));
                    ListViewItem item = new ListViewItem("", i++);
                    item.Tag = p.ID;
                    item.SubItems.Add(p.Title);
                    item.SubItems.Add(p.Price);
                    PostList.Items.Add(item);
                }
            }
            PostList.SmallImageList = imageList1;
        }

        private void PostList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (PostList.SelectedItems.Count == 1) {
                ListView.SelectedListViewItemCollection selected = PostList.SelectedItems;
                ListViewItem postitem = selected[0];
                //MessageBox.Show(postitem.Tag.ToString());
                new PostDlg((int)postitem.Tag, this).ShowDialog();
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            PostList.Items.Clear();
            imageList1.Images.Clear();
            imageList1.ImageSize = new Size(80, 80);
            int i = 0;
            foreach (var p in DataManager.Posts)
            {
                imageList1.Images.Add(Image.FromFile(p.Imageurl));
                ListViewItem item = new ListViewItem("", i++);
                item.Tag = p.ID;
                item.SubItems.Add(p.Title);
                item.SubItems.Add(p.Price);
                PostList.Items.Add(item);
            }
            PostList.SmallImageList = imageList1;
            btnAll.Visible = false;
        }
        public void loadLike() 
        {
            LikeList.Items.Clear();
            imageList2.Images.Clear();
            imageList2.ImageSize = new Size(80, 80);
            int i = 0;
            foreach (var p in DataManager.Posts)
            {
                if (DataManager.Likes.Exists((x) => x.UID == DataManager.LoginUser.ID && x.PID == p.ID))
                {
                    imageList2.Images.Add(Image.FromFile(p.Imageurl));
                    ListViewItem item = new ListViewItem("", i++);
                    item.Tag = p.ID;
                    item.SubItems.Add(p.Title);
                    item.SubItems.Add(p.Price);
                    LikeList.Items.Add(item);
                }

            }
            LikeList.SmallImageList = imageList2;
        }
        private void tabpage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabpage.SelectedTab == tabLike)
            {
                loadLike();
            }
            if(tabpage.SelectedTab == tabInfo)
            {
                UtxtID.Text = Convert.ToString(DataManager.LoginUser.ID);
                UtxtPW.Text = Convert.ToString(DataManager.LoginUser.ID);
                UtxtName.Text = DataManager.LoginUser.Name;
                UtxtAddr.Text = DataManager.LoginUser.Addr;

                PurchaseList.Items.Clear();
                imageList3.Images.Clear();
                imageList3.ImageSize = new Size(80, 80);
                int j = 0;
                foreach (var p in DataManager.Posts)
                {
                    if (DataManager.Purchases.Exists((x) => x.PID == p.ID && x.UID == DataManager.LoginUser.ID))
                    {
                        imageList3.Images.Add(Image.FromFile(p.Imageurl));
                        ListViewItem item = new ListViewItem("", j++);
                        item.Tag = p.ID;
                        item.SubItems.Add(p.Title);
                        item.SubItems.Add(p.Price);
                        PurchaseList.Items.Add(item);
                    }
                }
                PurchaseList.SmallImageList = imageList3;
            }
        }


        private void LikeList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (LikeList.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection selected = LikeList.SelectedItems;
                ListViewItem postitem = selected[0];
                //MessageBox.Show(postitem.Tag.ToString());
                new PostDlg((int)postitem.Tag, this).ShowDialog();
            }
        }


        private void MessageList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (MessageList.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection selected = MessageList.SelectedItems;
                ListViewItem msgitem = selected[0];
                //MessageBox.Show(postitem.Tag.ToString());
                new MessageDlg((int)msgitem.Tag).ShowDialog();
            }
        }

        private void PurchaseList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (PurchaseList.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection selected = PurchaseList.SelectedItems;
                ListViewItem postitem = selected[0];
                //MessageBox.Show(postitem.Tag.ToString());
                new PostDlg((int)postitem.Tag, this).ShowDialog();
            }
        }

        private void UbtnEdit_Click(object sender, EventArgs e)
        {
            DataManager.Users.Single((x) => x.ID == DataManager.LoginUser.ID).PW = int.Parse(UtxtPW.Text);
            DataManager.Users.Single((x) => x.ID == DataManager.LoginUser.ID).Addr = UtxtAddr.Text;
            DataManager.Users.Single((x) => x.ID == DataManager.LoginUser.ID).Name = UtxtName.Text;
            DataManager.Save();
            MessageBox.Show("회원 정보 수정 완료!");
        }


    }
}
