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
    public partial class MessageDlg : Form
    {
        Message msg;
        public MessageDlg(int mid)
        {
            InitializeComponent();
            //MessageBox.Show(Convert.ToString(mid));
            msg = DataManager.Messages.Single((x) => x.ID == mid);
            MBtxtTitle.Text = msg.Title;
            MBtxtPtitle.Text = DataManager.Posts.Single((x) => x.ID == msg.PID).Title;
            MBtxtSender.Text = DataManager.Users.Single((x) => msg.SenderID == x.ID).Name;
            MBtxtContent.Text = msg.Content;
            MBtxtTime.Text = msg.Time;
        }

        private void MBbtnReply_Click(object sender, EventArgs e)
        {
            new MessageSend(msg.PID, msg.ReceiverID, msg.SenderID).ShowDialog();
        }


    }
}
