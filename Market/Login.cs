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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //System.Diagnostics.Process.GetCurrentProcess().Kill();
            //Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtPW.Text == "")
            {
                MessageBox.Show("아이디와 비밀번호를 모두 입력해주세요!");
                return;
            }
            if (DataManager.Users.Exists((x) => x.ID == int.Parse(txtID.Text) && x.PW == int.Parse(txtPW.Text)))
            {
                MessageBox.Show("로그인되었습니다!");
                DataManager.LoginUser = DataManager.Users.Single((x) => x.ID == int.Parse(txtID.Text));
            
                new Main().ShowDialog();
                //this.Close();
            }
            else {
                MessageBox.Show("ID/PW를 확인해주세요!");
            }

        }


        private void btnJoin_Click(object sender, EventArgs e)
        {
            new Join(0, -1).ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            new Admin().ShowDialog();
        }
    }
}
