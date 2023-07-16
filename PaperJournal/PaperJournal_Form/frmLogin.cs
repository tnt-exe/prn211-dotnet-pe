using PaperJournal_Library.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperJournal_Form
{
    public partial class frmLogin : Form
    {
        private IAccount _account;
        public frmLogin()
        {
            InitializeComponent();
            _account = new AccountImpl();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Email is empty", "Notification");
                txtEmail.Focus();
                return;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("Password is empty", "Notification");
                txtPass.Focus();
                return;
            }
            var user = _account.GetAllAccount().FirstOrDefault(u => u.AccountEmail.Equals(txtEmail.Text, StringComparison.Ordinal) &&
                u.AccountPassword.Equals(txtPass.Text, StringComparison.Ordinal));
            if (user != null)
            {
                if (user.AccountRole == 0)
                {
                    frmPaperManagement frmPaperManagement = new frmPaperManagement();
                    this.Hide();
                    frmPaperManagement.ShowDialog();
                }
                else
                {
                    MessageBox.Show("You dont have permission to access this", "Notification");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Incorrect Email or Password", "Notification");
                return;
            }
        }
    }
}
