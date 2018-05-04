using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iPlanner
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (IsLogin())
            {
                iPlannerMain keluar = new iPlannerMain();
                keluar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("UserName atau Password Anda Salah!!");
            }
        }

        //private void TextBox_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        Login.PerformClick();
        //        // these last two lines will stop the beep sound
        //        e.SuppressKeyPress = true;
        //        e.Handled = true;
        //    }
        //}

        private bool IsLogin()
        {
            loginCheck sudahLogin = new loginCheck();
             string userId = userName.Text;
             string userPass = passWord.Text;
             string user = sudahLogin.UserNama();
             string pass = sudahLogin.UserPassword();
            if (userPass == pass && userId == user)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
}
