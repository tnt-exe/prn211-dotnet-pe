namespace BankAccount_Form
{
    partial class frmBankAccountManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvList = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            txtAccId = new TextBox();
            txtAccName = new TextBox();
            txtBranch = new TextBox();
            dtpOpenDate = new DateTimePicker();
            cboTypeName = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvList
            // 
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(34, 293);
            dgvList.Name = "dgvList";
            dgvList.RowTemplate.Height = 25;
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvList.Size = new Size(979, 296);
            dgvList.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(156, 34);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 40);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(308, 34);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(95, 40);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(591, 34);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 40);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(731, 34);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(95, 40);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 44);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 6;
            label1.Text = "Account ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 89);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 7;
            label2.Text = "Account Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 134);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 8;
            label3.Text = "Open Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(530, 41);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 9;
            label4.Text = "Branch Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(544, 86);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 11;
            label6.Text = "Type Name";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(549, 242);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(232, 40);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search by Branch Name";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(209, 249);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(311, 27);
            txtSearch.TabIndex = 13;
            // 
            // txtAccId
            // 
            txtAccId.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAccId.Location = new Point(138, 41);
            txtAccId.Name = "txtAccId";
            txtAccId.Size = new Size(311, 27);
            txtAccId.TabIndex = 14;
            // 
            // txtAccName
            // 
            txtAccName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAccName.Location = new Point(138, 86);
            txtAccName.Name = "txtAccName";
            txtAccName.Size = new Size(311, 27);
            txtAccName.TabIndex = 15;
            // 
            // txtBranch
            // 
            txtBranch.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBranch.Location = new Point(634, 37);
            txtBranch.Name = "txtBranch";
            txtBranch.Size = new Size(311, 27);
            txtBranch.TabIndex = 16;
            // 
            // dtpOpenDate
            // 
            dtpOpenDate.CalendarFont = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtpOpenDate.Location = new Point(138, 134);
            dtpOpenDate.Name = "dtpOpenDate";
            dtpOpenDate.Size = new Size(311, 23);
            dtpOpenDate.TabIndex = 17;
            // 
            // cboTypeName
            // 
            cboTypeName.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTypeName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cboTypeName.FormattingEnabled = true;
            cboTypeName.Location = new Point(634, 86);
            cboTypeName.Name = "cboTypeName";
            cboTypeName.Size = new Size(311, 28);
            cboTypeName.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cboTypeName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtpOpenDate);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtBranch);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtAccName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtAccId);
            groupBox1.Location = new Point(34, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(979, 185);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnClose);
            groupBox2.Location = new Point(34, 595);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(979, 100);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            // 
            // frmBankAccountManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 734);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(dgvList);
            MaximizeBox = false;
            Name = "frmBankAccountManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bank Account Management";
            Load += frmBankAccountManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvList;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Button btnSearch;
        private TextBox txtSearch;
        private TextBox txtAccId;
        private TextBox txtAccName;
        private TextBox txtBranch;
        private DateTimePicker dtpOpenDate;
        private ComboBox cboTypeName;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}