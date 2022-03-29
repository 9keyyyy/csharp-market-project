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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            btnAll.Visible = false;

            loadPost();

            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 60);
            foreach (var p in DataManager.Messages)
            {
                //MessageBox.Show(Convert.ToString(p.ReceiverID), Convert.ToString(DataManager.LoginUser.ID));
                if (DataManager.Users.Exists((x) => p.ReceiverID == 0 && x.ID == 0))
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

        private void admintab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(admintab.SelectedTab == tabUser)
            {
                loadUser();
            }
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
                if (p.Title.Contains(txtSearch.Text))
                {
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
            if (PostList.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection selected = PostList.SelectedItems;
                ListViewItem postitem = selected[0];
                //MessageBox.Show(postitem.Tag.ToString());
                new PostEdit((int)postitem.Tag, this).ShowDialog();
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
        public void loadPost()
        {
            PostList.Items.Clear();
            imageList1.Images.Clear();
            imageList1.ImageSize = new Size(80, 80);
            int i = 0;
            foreach (var p in DataManager.Posts)
            {
                //MessageBox.Show(Convert.ToString(p.Title.Contains(txtSearch.Text)));
                if (p.Title.Contains(txtSearch.Text))
                {
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
        public void loadUser()
        {

            UserList.Items.Clear();
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 50);
            foreach (var p in DataManager.Users)
            {
                if (p.ID != 0) { 
                    ListViewItem item = new ListViewItem(p.Name);
                    item.Tag = p.ID;
                    item.SubItems.Add(Convert.ToString(p.ID));
                    item.SubItems.Add(Convert.ToString(p.PW));
                    item.SubItems.Add(p.Addr);
                    UserList.Items.Add(item);
                }
            }
            UserList.SmallImageList = imgList;
        }
        private void btnAddPost_Click(object sender, EventArgs e)
        {
            new PostEdit(-1, this).ShowDialog();
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

        private void AbtnAddUser_Click(object sender, EventArgs e)
        {
            new Join(1, -1).ShowDialog();
            loadUser();
        }

        private void UserList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (UserList.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection selected = UserList.SelectedItems;
                ListViewItem useritem = selected[0];
                //MessageBox.Show(postitem.Tag.ToString());
                new Join(2, (int)useritem.Tag).ShowDialog();
            }
            loadUser();
        }
    }
}
