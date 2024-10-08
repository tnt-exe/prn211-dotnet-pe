﻿using CustomerAccount_Library.Repository;

namespace CustomerAccount_Form
{
    public partial class frmLogin : Form
    {
        private IUser _userControl = new UserImpl();
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
            var user = _userControl.Login(txtUserId.Text, txtPassword.Text);
            if (user != null)
            {
                if (user.UserRole == 1)
                {
                    frmAccountManagement frmAccountManagement = new frmAccountManagement();
                    this.Hide();
                    frmAccountManagement.ShowDialog();
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
                txtUserId.Focus();
                return;
            }
        }
    }
}
