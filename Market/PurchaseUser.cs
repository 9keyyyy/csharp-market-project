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
    public partial class PurchaseUser : Form
    {
        public PurchaseUser(int pid)
        {
            InitializeComponent();
            Post post = DataManager.Posts.Single((x) => x.ID == pid);
            UserList.Items.Clear();
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 40);
            foreach (var p in DataManager.Purchases)
            {
                if (DataManager.Users.Exists((x) => x.ID == p.UID && p.PID == pid))
                {
                    //MessageBox.Show(p.Name);
                    User user = DataManager.Users.Single((x) => x.ID == p.UID);
                    ListViewItem item = new ListViewItem(user.Name);
                    item.Tag = user.ID;
                    item.SubItems.Add(Convert.ToString(user.ID));
                    item.SubItems.Add(Convert.ToString(user.PW));
                    item.SubItems.Add(user.Addr);
                    UserList.Items.Add(item);
                }
            }
            UserList.SmallImageList = imgList;
        }
    }
}
