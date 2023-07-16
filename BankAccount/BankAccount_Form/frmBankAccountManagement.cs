using BankAccount_Library.Models;
using BankAccount_Library.Repository;
using System.Data;

namespace BankAccount_Form
{
    public partial class frmBankAccountManagement : Form
    {
        private IAccountType _accountType;
        private IBankAccount _bankAccount;
        private string[] arrAccountType;
        private BindingSource _source;
        private BankAccount _bankAcc = new BankAccount();
        public frmBankAccountManagement()
        {
            InitializeComponent();
            _accountType = new AccountTypeImpl();
            _bankAccount = new BankAccountImpl();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _loadList(string search = "")
        {
            var bankAccList = _bankAccount.GetAllBankAccount()
                .Select(bk => new
                {
                    AccountID = bk.AccountId,
                    AccountName = bk.AccountName,
                    OpenDate = bk.OpenDate,
                    BranchName = bk.BranchName,
                    TypeName = bk.Type.TypeName
                });
            if (!string.IsNullOrEmpty(search))
            {
                bankAccList = bankAccList.
                    Where(bk => bk.BranchName.Contains(search, StringComparison.OrdinalIgnoreCase)).ToArray();
            }
            _source = new BindingSource();
            _source.DataSource = bankAccList;

            txtAccId.DataBindings.Clear();
            txtAccName.DataBindings.Clear();
            txtBranch.DataBindings.Clear();
            dtpOpenDate.DataBindings.Clear();
            cboTypeName.DataBindings.Clear();

            if (_source.DataSource != null)
            {
                txtAccId.DataBindings.Add("text", _source, "accountid");
                txtAccName.DataBindings.Add("text", _source, "accountname");
                dtpOpenDate.DataBindings.Add("text", _source, "opendate");
                txtBranch.DataBindings.Add("text", _source, "branchname");

                cboTypeName.DataBindings.Add("text", _source, "typename");
                cboTypeName.DataSource = arrAccountType;
            }

            dgvList.DataSource = null;
            dgvList.DataSource = _source;
            if (bankAccList.Count() == 0)
            {
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }

        private void frmBankAccountManagement_Load(object sender, EventArgs e)
        {
            arrAccountType = _accountType.GetAllAccountType()
                .Select(t => t.TypeName).ToArray();
            _loadList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string? search = txtSearch.Text;
            _loadList(search);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this account", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var account = _bankAccount.GetAllBankAccount().ToList()[dgvList.CurrentRow.Index];
                _bankAccount.Remove(account);
                _loadList();
                MessageBox.Show("Delete successfully", "Notification");
                return;
            }
            else
            {
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var currentAccId = dgvList.CurrentRow.Cells[0].Value;

            var accountid = txtAccId.Text;
            var accountname = txtAccName.Text;
            var opendate = dtpOpenDate.Value;
            var branchname = txtBranch.Text;
            var typeid = _accountType.GetAllAccountType()
                .Where(a => a.TypeName.Equals(cboTypeName.Text))
                .Select(a => a.TypeId).FirstOrDefault();
            if (!accountid.Equals(currentAccId.ToString(), StringComparison.Ordinal))
            {
                MessageBox.Show("You can not change Account ID", "Notification");
                txtAccId.Text = currentAccId.ToString();
                return;
            }
            else if (string.IsNullOrEmpty(accountid) || string.IsNullOrEmpty(accountname) || string.IsNullOrEmpty(branchname))
            {
                MessageBox.Show("Please input all information", "Notification");
                return;
            }
            else
            {
                if (branchname.Length < 5 || !branchname.Split(' ').All(s => char.IsUpper(s[0])))
                {
                    MessageBox.Show("Branch name must be longer than 5 characters and each word start with capital letter", "Notification");
                    return;
                }
                else
                {
                    _bankAcc.AccountId = accountid;
                    _bankAcc.AccountName = accountname;
                    _bankAcc.OpenDate = opendate;
                    _bankAcc.BranchName = branchname;
                    _bankAcc.TypeId = typeid;
                    _bankAccount.Update(_bankAcc);
                    _loadList();
                    MessageBox.Show("Update successfully", "Notification");
                    return;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var accountid = txtAccId.Text;
            var accountname = txtAccName.Text;
            var opendate = dtpOpenDate.Value;
            var branchname = txtBranch.Text;
            var typeid = _accountType.GetAllAccountType()
                .Where(a => a.TypeName.Equals(cboTypeName.Text))
                .Select(a => a.TypeId).FirstOrDefault();
            if (string.IsNullOrEmpty(accountid) || string.IsNullOrEmpty(accountname) || string.IsNullOrEmpty(branchname))
            {
                MessageBox.Show("Please input all information", "Notification");
                return;
            }
            else
            {
                if (branchname.Length < 5 || !branchname.Split(' ').All(s => char.IsUpper(s[0])))
                {
                    MessageBox.Show("Branch name must be longer than 5 characters and each word start with capital letter", "Notification");
                    return;
                }
                else
                {
                    _bankAcc.AccountId = accountid;
                    _bankAcc.AccountName = accountname;
                    _bankAcc.OpenDate = opendate;
                    _bankAcc.BranchName = branchname;
                    _bankAcc.TypeId = typeid;
                    var result = _bankAccount.Add(_bankAcc);
                    if (result)
                    {
                        _loadList();
                        MessageBox.Show("Add successfully", "Notification");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Add failed (check if Account ID is duplicate)", "Notification");
                        return;
                    }

                }
            }
        }
    }
}
