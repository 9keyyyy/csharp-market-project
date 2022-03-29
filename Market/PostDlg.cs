using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace Market
{
    public partial class PostDlg : Form
    {
        Post post;
        Main mainform;
        public PostDlg(int postID, Main main)
        {
            InitializeComponent();
            post = DataManager.Posts.Single((x) => x.ID == postID);
            ProductName.Text = post.Title;
            PtxtContent.Text = post.Content;
            PtxtPrice.Text = post.Price;
            PtxtStock.Text = Convert.ToString(post.Stock);
            pictureBox1.Load(post.Imageurl);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            mainform = main;
            if (DataManager.Likes.Exists((x) => x.UID == DataManager.LoginUser.ID && x.PID == post.ID))
            {
                PbtnLike.Text = "관심 목록 삭제하기";
            }
        }

        private void PbtnPurchase_Click(object sender, EventArgs e)
        {
            if (DataManager.Posts.Single((x) => x == post).Stock == 0) { 
                MessageBox.Show("재고가 부족합니다!");
                return;
            }
            int id;
            if (DataManager.Purchases.Count == 0)
            {
                id = 1;
            }
            else
            {
               id = DataManager.Purchases[DataManager.Purchases.Count - 1].ID + 1;
            }
            DataManager.Purchases.Add(new Purchase()
            {
                ID = id,
                UID = DataManager.LoginUser.ID,
                PID = post.ID

            });
            DataManager.Posts.Single((x) => x == post).Stock--;
            DataManager.Save();
            PtxtStock.Text = Convert.ToString(DataManager.Posts.Single((x) => x == post).Stock);
            MessageBox.Show(DataManager.LoginUser.Name+ "님, 구매 완료되었습니다!");

        }

        private void PbtnAsk_Click(object sender, EventArgs e)
        {
            new MessageSend(post.ID, DataManager.LoginUser.ID, 0).ShowDialog();
        }

        private void PbtnLike_Click(object sender, EventArgs e)
        {
            if (DataManager.Likes.Exists((x) => x.UID == DataManager.LoginUser.ID && x.PID == post.ID))
            {
                DataManager.Likes.Remove(DataManager.Likes.Single((x) => x.UID == DataManager.LoginUser.ID && x.PID == post.ID));           

                DataManager.Save();
                PbtnLike.Text = "관심 목록 추가하기";
                MessageBox.Show("관심목록 삭제 완료!");
            }
            else
            {
                int id;
                if (DataManager.Likes.Count == 0)
                {
                    id = 1;
                }
                else
                {
                    id = DataManager.Likes[DataManager.Likes.Count - 1].ID + 1;
                }
                DataManager.Likes.Add(new Like()
                {
                    ID = id,
                    UID = DataManager.LoginUser.ID,
                    PID = post.ID

                });
                DataManager.Save();
                PbtnLike.Text = "관심 목록 삭제하기";
                MessageBox.Show("관심목록 추가 완료!");
            }
            mainform.loadLike();
        }
    }
}
