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
    public partial class MessageSend : Form
    {
        Post post;
        int SID, RID;
        public MessageSend(int postID, int SenderID, int ReceiverID)
        {
            InitializeComponent();
            post = DataManager.Posts.Single((x) => x.ID == postID);
            SID = SenderID;
            RID = ReceiverID;
            MtxtProduct.Text = post.Title;
            MtxtReceiver.Text = DataManager.Users.Single((x) => x.ID == ReceiverID).Name;

        }

        private void MbtnSend_Click(object sender, EventArgs e)
        {

            int id;
            if (DataManager.Messages.Count == 0)
            {
                id = 1;
            }
            else
            {
                id = DataManager.Messages[DataManager.Messages.Count - 1].ID + 1;
            }
            DataManager.Messages.Add(new Message()
            {
                ID = id,
                SenderID = SID,
                ReceiverID = RID,
                PID = post.ID,
                Title = MtxtTitle.Text,
                Content = MtxtContent.Text,
                Time = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
            });
            DataManager.Save();
            MessageBox.Show("메시지 전송 완료!");
            this.Close();
        }
    }
}
