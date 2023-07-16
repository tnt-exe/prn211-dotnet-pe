using CustomerAccount_Library.Models;
using CustomerAccount_Library.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerAccount_Form
{
    public partial class frmAccountManagement : Form
    {
        private ICustomer _customerControl;
        private ICustomerAccount _customerAccount;
        private BindingSource _source;
        private string[] arrCustomerName;
        private CustomerAccount _cusAccount { get; set; } = new CustomerAccount();
        public frmAccountManagement()
        {
            InitializeComponent();
            _customerAccount = new CustomerAccountImpl();
            _customerControl = new CustomerImpl();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to delete this item", "Confirmation", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                var account = _customerAccount.GetAllAccount().ToList()[dgvList.CurrentRow.Index];
                _customerAccount.Remove(account);
                _loadAccountList();
                MessageBox.Show("Delete successfully", "Notification");
                return;
            }
            else
            {
                return;
            }
        }
        private void _loadAccountList(string search = "")
        {
            var accountList = _customerAccount.GetAllAccount()
                .Select(a => new //annonymous entity
                {
                    AccountId = a.AccountId,
                    AccountName = a.AccountName,
                    RegionName = a.RegionName,
                    CustomerName = a.Customer?.CustomerName,
                    CustomerId = a.CustomerId,
                    OpenDate = a.OpenDate
                });
            if (!string.IsNullOrEmpty(search))
            {
                accountList = accountList
                    .Where(a => a.RegionName.Contains(search, StringComparison.OrdinalIgnoreCase)).ToArray();
            }
            //new binding source and assign the list to
            _source = new BindingSource();
            _source.DataSource = accountList;
            //clear exist data bindings
            txtAccountId.DataBindings.Clear();
            txtAccountName.DataBindings.Clear();
            txtRegionName.DataBindings.Clear();
            cboCustomerName.DataBindings.Clear();
            dtpOpenDate.DataBindings.Clear();
            //add new data bindings
            txtAccountId.DataBindings.Add("text", _source, "accountid");
            txtAccountName.DataBindings.Add("text", _source, "accountname");
            txtRegionName.DataBindings.Add("text", _source, "regionname");
            dtpOpenDate.DataBindings.Add("text", _source, "opendate");
            cboCustomerName.DataBindings.Add("text", _source, "customername");
            cboCustomerName.DataSource = arrCustomerName;
            //add data source to grid view
            dgvList.DataSource = null;
            dgvList.DataSource = _source;

            if (accountList.Count() == 0)
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
        private void frmAccountManagement_Load(object sender, EventArgs e)
        {
            arrCustomerName = _customerControl.GetAllCustomer()
                .Select(c => c.CustomerName).ToArray();
            _loadAccountList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string? search = txtSearch.Text;
            _loadAccountList(search);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //var accountid_Current = dgvList.CurrentRow.Cells[0].Value;
            var accountid = txtAccountId.Text;
            var accountname = txtAccountName.Text;
            var opendate = dtpOpenDate.Value;
            var regionname = txtRegionName.Text;
            var customerid = _customerControl.GetAllCustomer()
                .Where(c => c.CustomerName.Equals(cboCustomerName.Text))
                .Select(c => c.CustomerId).FirstOrDefault();
            if (string.IsNullOrEmpty(accountname) || string.IsNullOrEmpty(accountid) || string.IsNullOrEmpty(regionname))
            {
                MessageBox.Show("Please input all information", "Notification");
                return;
            }
            else
            {
                if (regionname.Length < 10)
                {
                    MessageBox.Show("Region Name must have more than 10 characters", "Notification");
                    txtRegionName.Focus();
                    return;
                }
                else if (!regionname.Split(' ').All(s => char.IsUpper(s[0])))
                {
                    MessageBox.Show("Region Name must have letter that start with a capital", "Notification");
                    txtRegionName.Focus();
                    return;
                }
                else
                {
                    _cusAccount.RegionName = regionname;
                    _cusAccount.AccountName = accountname;
                    _cusAccount.AccountId = accountid;
                    _cusAccount.OpenDate = opendate;
                    _cusAccount.CustomerId = customerid;

                    var result = _customerAccount.Add(_cusAccount);
                    _loadAccountList();
                    if (result)
                    {
                        MessageBox.Show("Add successfully", "Notification");
                    }
                    else
                    {
                        MessageBox.Show("Add failed (check if duplicate Account ID)", "Notification");
                        return;
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var accountid_Current = dgvList.CurrentRow.Cells[0].Value;
            var accountid = txtAccountId.Text;
            var accountname = txtAccountName.Text;
            var opendate = dtpOpenDate.Value;
            var regionname = txtRegionName.Text;
            var customerid = _customerControl.GetAllCustomer()
                .Where(c => c.CustomerName.Equals(cboCustomerName.Text))
                .Select(c => c.CustomerId).FirstOrDefault();
            if (!accountid.Equals(accountid_Current))
            {
                MessageBox.Show("You can not change Account ID", "Notification");
                txtAccountId.Text = accountid_Current.ToString();
                return;
            }
            if (string.IsNullOrEmpty(accountname) || string.IsNullOrEmpty(accountid) || string.IsNullOrEmpty(regionname))
            {
                MessageBox.Show("Please input all information", "Notification");
                return;
            }
            else
            {
                if (regionname.Length < 10)
                {
                    MessageBox.Show("Region Name must have more than 10 characters", "Notification");
                    txtRegionName.Focus();
                    return;
                }
                else if (!regionname.Split(' ').All(s => char.IsUpper(s[0])))
                {
                    MessageBox.Show("Region Name must have letter that start with a capital", "Notification");
                    txtRegionName.Focus();
                    return;
                }
                else
                {
                    _cusAccount.RegionName = regionname;
                    _cusAccount.AccountName = accountname;
                    _cusAccount.AccountId = accountid;
                    _cusAccount.OpenDate = opendate;
                    _cusAccount.CustomerId = customerid;

                    var result = _customerAccount.Update(_cusAccount);
                    _loadAccountList();
                    if (result)
                    {
                        MessageBox.Show("Update successfully", "Notification");
                    }
                    else
                    {
                        MessageBox.Show("Update failed", "Notification");
                        return;
                    }
                }
            }
        }
    }
}
