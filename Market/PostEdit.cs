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
    public partial class PostEdit : Form
    {
        int PostID;
        Post post;
        string filepath;
        Admin adminform;
        public PostEdit(int postid, Admin admin)
        {
            InitializeComponent();
            PostID = postid;
            adminform = admin;
            if (postid != -1)
            {
                post = DataManager.Posts.Single((x) => x.ID == PostID);
                EtxtTitle.Text = post.Title;
                EtxtContent.Text = post.Content;
                EtxtPrice.Text = post.Price;
                EtxtStock.Text = Convert.ToString(post.Stock);
                filepath = post.Imageurl;
                pictureBox1.Load(post.Imageurl);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else 
            {
                PbtnShow.Visible = false;
            }
        }

        private void PbtnAddpic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("사진은 [Market]-[bin]-[Debug]-[net5.0-windows]에서 선택해주세요!");
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                filepath = ofd.FileName;
                filepath = filepath.Split('\\')[filepath.Split('\\').Length - 1];
                //MessageBox.Show(filepath.Split('\\')[filepath.Split('\\').Length - 1]);
            }
            else 
            {
                if (PostID == -1) filepath = "";
            }
            if (!filepath.Equals("")) 
            {
                pictureBox1.Load(filepath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void PbtnSave_Click(object sender, EventArgs e)
        {
            if(PostID == -1)
            {
                int id;
                if (DataManager.Posts.Count == 0)
                {
                    id = 1;
                }
                else
                {
                    id = DataManager.Posts[DataManager.Posts.Count - 1].ID + 1;
                }
                DataManager.Posts.Add(new Post()
                {
                    Title = EtxtTitle.Text,
                    ID = id,
                    Content = EtxtContent.Text,
                    Stock = int.Parse(EtxtStock.Text),
                    Price = EtxtPrice.Text,
                    Imageurl = filepath
                });
                DataManager.Save();
                MessageBox.Show("상품 추가 완료!");
            }
            else
            {
                post.Title = EtxtTitle.Text;
                post.Content = EtxtContent.Text;
                post.Stock = int.Parse(EtxtStock.Text);
                post.Price = EtxtPrice.Text;
                post.Imageurl = filepath;
                DataManager.Save();
                MessageBox.Show("상품 수정 완료!");
            }
            adminform.loadPost();
            this.Close();
        }

        private void PbtnShow_Click(object sender, EventArgs e)
        {
            new PurchaseUser(PostID).ShowDialog();
        }
    }
}
