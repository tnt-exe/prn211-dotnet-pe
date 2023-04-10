using PaperJournal_Library.Models;
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
    public partial class frmPaperManagement : Form
    {
        private IPaper _paper;
        private IJournalInfo _journalInfo;
        private BindingSource _source;
        private string[] arrJournalName;
        private Paper _paperObj { get; set; } = new Paper();
        public frmPaperManagement()
        {
            InitializeComponent();
            _paper = new PaperImpl();
            _journalInfo = new JournalInfoImpl();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void _loadList(string search = "")
        {
            var paperList = _paper.GetAllPaper().Select(p => new
            {
                PaperID = p.PaperId,
                PaperTitle = p.PaperTitle,
                Authors = p.Authors,
                Abstract = p.Abstract,
                SubmittedDate = p.SubmittedDate,
                Journal = p.Journal.JournalName
            });
            if (!string.IsNullOrEmpty(search))
            {
                paperList = paperList.Where(p => p.Authors.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    p.PaperTitle.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            _source = new BindingSource();
            _source.DataSource = paperList;

            txtPaperId.DataBindings.Clear();
            txtPaperTitle.DataBindings.Clear();
            txtAuthor.DataBindings.Clear();
            txtAbstract.DataBindings.Clear();
            dtpSubmitDate.DataBindings.Clear();
            cboJounal.DataBindings.Clear();

            txtPaperId.DataBindings.Add("text", _source, "paperid");
            txtPaperTitle.DataBindings.Add("text", _source, "papertitle");
            txtAuthor.DataBindings.Add("text", _source, "authors");
            txtAbstract.DataBindings.Add("text", _source, "abstract");
            dtpSubmitDate.DataBindings.Add("text", _source, "submitteddate");
            cboJounal.DataBindings.Add("text", _source, "journal");
            cboJounal.DataSource = arrJournalName;

            dgvList.DataSource = null;
            dgvList.DataSource = _source;
            if (paperList.Count() == 0)
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

        private void frmPaperManagement_Load(object sender, EventArgs e)
        {
            arrJournalName = _journalInfo.GetAllJournal().Select(j => j.JournalName).ToArray();
            _loadList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string? search = txtSearch.Text;
            _loadList(search);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Delete? You sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                var paper = _paper.GetAllPaper().ToList()[dgvList.CurrentRow.Index];
                _paper.Delete(paper);
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
            var currentId = dgvList.CurrentRow.Cells[0].Value;

            var paperid = txtPaperId.Text;
            var papertitle = txtPaperTitle.Text;
            var author = txtAuthor.Text;
            var abstracts = txtAbstract.Text;
            var submitdate = dtpSubmitDate.Value;
            var journalid = _journalInfo.GetAllJournal().Where(j => j.JournalName.Equals(cboJounal.Text, StringComparison.Ordinal))
                .Select(j => j.JournalId).FirstOrDefault();

            if (!paperid.Equals(currentId.ToString(), StringComparison.Ordinal))
            {
                MessageBox.Show("You can not change Paper ID", "Notification");
                txtPaperId.Text = currentId.ToString();
                return;
            }
            if (string.IsNullOrEmpty(paperid) || string.IsNullOrEmpty(papertitle) || string.IsNullOrEmpty(author)
                || string.IsNullOrEmpty(abstracts))
            {
                MessageBox.Show("Please input all information", "Notification");
                return;
            }
            else
            {
                if (abstracts.Length < 5 || abstracts.Length > 50)
                {
                    MessageBox.Show("Abstract only in range 5-50 characters", "Notification");
                    txtAbstract.Focus();
                    return;
                }
                if (papertitle.Length < 2 || papertitle.Length > 20)
                {
                    MessageBox.Show("Paper Title only in range 5-50 characters", "Notification");
                    txtPaperTitle.Focus();
                    return;
                }
                if (!papertitle.Split(' ').All(c => char.IsUpper(c[0])))
                {
                    MessageBox.Show("The first letter of each word in Paper Title must be capital letter", "Notification");
                    txtPaperTitle.Focus();
                    return;
                }
                _paperObj.PaperId = paperid;
                _paperObj.PaperTitle = papertitle;
                _paperObj.Authors = author;
                _paperObj.Abstract = abstracts;
                _paperObj.SubmittedDate = submitdate;
                _paperObj.JournalId = journalid;
                var result = _paper.Update(_paperObj);
                if (result)
                {
                    _loadList();
                    MessageBox.Show($"Update Paper with ID {paperid} successfully", "Notification");
                    return;
                }
                else
                {
                    MessageBox.Show("Update failed", "Notification");
                    return;
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var paperid = txtPaperId.Text;
            var papertitle = txtPaperTitle.Text;
            var author = txtAuthor.Text;
            var abstracts = txtAbstract.Text;
            var submitdate = dtpSubmitDate.Value;
            var journalid = _journalInfo.GetAllJournal().Where(j => j.JournalName.Equals(cboJounal.Text, StringComparison.Ordinal))
                .Select(j => j.JournalId).FirstOrDefault();
            if (string.IsNullOrEmpty(paperid) || string.IsNullOrEmpty(papertitle) || string.IsNullOrEmpty(author)
                || string.IsNullOrEmpty(abstracts))
            {
                MessageBox.Show("Please input all information", "Notification");
                return;
            }
            else
            {
                if (abstracts.Length < 5 || abstracts.Length > 50)
                {
                    MessageBox.Show("Abstract only in range 5-50 characters", "Notification");
                    txtAbstract.Focus();
                    return;
                }
                if (papertitle.Length < 2 || papertitle.Length > 20)
                {
                    MessageBox.Show("Paper Title only in range 5-50 characters", "Notification");
                    txtPaperTitle.Focus();
                    return;
                }
                if (!papertitle.Split(' ').All(c => char.IsUpper(c[0])))
                {
                    MessageBox.Show("The first letter of each word in Paper Title must be capital letter", "Notification");
                    txtPaperTitle.Focus();
                    return;
                }
                _paperObj.PaperId = paperid;
                _paperObj.PaperTitle = papertitle;
                _paperObj.Authors = author;
                _paperObj.Abstract = abstracts;
                _paperObj.SubmittedDate = submitdate;
                _paperObj.JournalId = journalid;
                var result = _paper.Add(_paperObj);
                if (result)
                {
                    _loadList();
                    MessageBox.Show($"Add new Paper with ID {paperid} successfully", "Notification");
                    return;
                }
                else
                {
                    MessageBox.Show("Add failed (Make sure Paper ID is not duplicate", "Notification");
                    txtPaperId.Focus();
                    return;
                }
            }
        }
    }
}
