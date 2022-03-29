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
    public partial class Join : Form
    {
        int isAdmin;
        User user;
        public Join(int flag, int uid)
        {
            InitializeComponent();
            isAdmin = flag;
            if (isAdmin == 1) JbtnJoin.Text = "회원추가";
            else if (isAdmin == 0) JbtnJoin.Text = "회원가입";
            else if (isAdmin == 2)
            {
                JbtnJoin.Text = "정보수정";
                user = DataManager.Users.Single((x) => x.ID == uid);
                JtxtAddr.Text = user.Addr;
                JtxtID.Text = Convert.ToString(user.ID);
                JtxtPW.Text = Convert.ToString(user.PW);
                JtxtName.Text = user.Name;
            }
        }

        private void JbtnJoin_Click(object sender, EventArgs e)
        {
            
            if (isAdmin == 2)
            {
                if (DataManager.Users.Exists((x) => x.ID == int.Parse(JtxtID.Text) && x.ID!=user.ID))
                {
                    MessageBox.Show("중복된 아이디가 존재합니다!");
                    return;
                    //this.Close();
                }
                DataManager.Users.Single((x) => x.ID == user.ID).ID = int.Parse(JtxtID.Text);
                DataManager.Users.Single((x) => x.ID == user.ID).PW = int.Parse(JtxtPW.Text);
                DataManager.Users.Single((x) => x.ID == user.ID).Addr = JtxtAddr.Text;
                DataManager.Users.Single((x) => x.ID == user.ID).Name = JtxtName.Text;
                DataManager.Save();
                MessageBox.Show("수정 완료!");
            }
            else
            {
                if (DataManager.Users.Exists((x) => x.ID == int.Parse(JtxtID.Text)))
                {
                    MessageBox.Show("중복된 아이디가 존재합니다!");
                    return;
                    //this.Close();
                }
                DataManager.Users.Add(new User()
                {
                    ID = int.Parse(JtxtID.Text),
                    PW = int.Parse(JtxtPW.Text),
                    Name = JtxtName.Text,
                    Addr = JtxtAddr.Text
                });
                DataManager.Save();
                MessageBox.Show("회원가입 되었습니다!");
            }
            this.Close();

        }
    }
}
