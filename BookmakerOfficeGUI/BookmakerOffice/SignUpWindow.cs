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
    public partial class SignUpWindow : Form
    {
        public SignUpWindow()
        {
            InitializeComponent();
        }

        private void B_SignUp_Click(object sender, EventArgs e)
        {
            if(tb_Login.Text == "")
            {
                MessageBox.Show("Please, enter login", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(tb_Password.Text == "" || tb_ConfirmPassword.Text == "")
            {
                MessageBox.Show("Please, enter you password", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(tb_Password.Text != tb_ConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(tb_Login.Text != "" && tb_Password.Text == tb_ConfirmPassword.Text && tb_Password.Text != "")
            {
                IUserInterface obj = new SystemManagment();
                if(obj.sign_up(tb_Login.Text, tb_Password.Text))
                {
                    MessageBox.Show("Account successfully registered", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Account with this login already exists", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
