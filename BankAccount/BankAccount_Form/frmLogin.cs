using BankAccount_Library.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccount_Form
{
    public partial class frmLogin : Form
    {
        private IUser _user = new UserImpl();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text == "")
            {
                MessageBox.Show("User ID is empty", "Notification");
                txtUserId.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Password is empty", "Notification");
                txtPassword.Focus();
                return;
            }
            var user = _user.Login(txtUserId.Text, txtPassword.Text);
            if (user != null)
            {
                if (user.UserRole == 1)
                {
                    frmBankAccountManagement frmBankAccountManagement = new frmBankAccountManagement();
                    this.Hide();
                    frmBankAccountManagement.ShowDialog();
                }
                else
                {
                    MessageBox.Show("You dont have permission to access this", "Notification");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Incorrect User ID or Password", "Notification");
                return;
            }
        }
    }
}
