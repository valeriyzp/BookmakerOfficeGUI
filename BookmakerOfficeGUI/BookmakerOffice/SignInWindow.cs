using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BetSystem;

namespace BookmakerOffice
{
    public partial class SignInWindow : Form
    {
        public SignInWindow()
        {
            InitializeComponent();
        }

        public void clear_information()
        {
            tb_Login.Text = "";
            tb_Password.Text = "";
        }

        private void ll_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clear_information();
            SignUpWindow window = new SignUpWindow();
            window.ShowDialog();
        }

        private void b_SignIn_Click(object sender, EventArgs e)
        {
            IUserInterface User = new SystemManagment();
            IAdminInterface Admin = new SystemManagment();
            if(User.sign_in(tb_Login.Text, tb_Password.Text))
            {
                clear_information();
                UserWindow window = new UserWindow(User);
                window.ShowDialog();
            }
            else if(Admin.sign_in_admin(tb_Login.Text, tb_Password.Text))
            {
                clear_information();
                AdminWindow window = new AdminWindow(Admin);
                window.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect login or password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
