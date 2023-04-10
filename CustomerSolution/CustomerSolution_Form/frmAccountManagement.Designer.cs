namespace CustomerSolution_Form
{
    partial class frmAccountManagement
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
            groupBox1 = new GroupBox();
            dtpOpenDate = new DateTimePicker();
            cboCustomerName = new ComboBox();
            txtRegionName = new TextBox();
            txtAccountName = new TextBox();
            txtAccountId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvList = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            groupBox2 = new GroupBox();
            btnDelete = new Button();
            btnClose = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpOpenDate);
            groupBox1.Controls.Add(cboCustomerName);
            groupBox1.Controls.Add(txtRegionName);
            groupBox1.Controls.Add(txtAccountName);
            groupBox1.Controls.Add(txtAccountId);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(33, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(886, 140);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data";
            // 
            // dtpOpenDate
            // 
            dtpOpenDate.Location = new Point(170, 96);
            dtpOpenDate.Name = "dtpOpenDate";
            dtpOpenDate.Size = new Size(245, 23);
            dtpOpenDate.TabIndex = 9;
            // 
            // cboCustomerName
            // 
            cboCustomerName.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCustomerName.FormattingEnabled = true;
            cboCustomerName.Location = new Point(576, 66);
            cboCustomerName.Name = "cboCustomerName";
            cboCustomerName.Size = new Size(245, 23);
            cboCustomerName.TabIndex = 8;
            // 
            // txtRegionName
            // 
            txtRegionName.Location = new Point(576, 37);
            txtRegionName.Name = "txtRegionName";
            txtRegionName.Size = new Size(245, 23);
            txtRegionName.TabIndex = 7;
            // 
            // txtAccountName
            // 
            txtAccountName.Location = new Point(170, 65);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(245, 23);
            txtAccountName.TabIndex = 6;
            // 
            // txtAccountId
            // 
            txtAccountId.Location = new Point(170, 36);
            txtAccountId.Name = "txtAccountId";
            txtAccountId.Size = new Size(245, 23);
            txtAccountId.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(455, 67);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 4;
            label5.Text = "Customer Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(455, 36);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 3;
            label4.Text = "Region Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(58, 96);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 2;
            label3.Text = "Open Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(58, 67);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Account Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(58, 36);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Account ID";
            // 
            // dgvList
            // 
            dgvList.AllowUserToAddRows = false;
            dgvList.AllowUserToDeleteRows = false;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(33, 260);
            dgvList.Name = "dgvList";
            dgvList.ReadOnly = true;
            dgvList.RowTemplate.Height = 25;
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvList.Size = new Size(886, 300);
            dgvList.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(203, 204);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(325, 23);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(557, 197);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(236, 33);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search by Region Name";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnClose);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Location = new Point(33, 582);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(886, 95);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(501, 36);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 33);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(691, 36);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(130, 33);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(251, 36);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 33);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(47, 36);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 33);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmAccountManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 711);
            Controls.Add(groupBox2);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvList);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "frmAccountManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAccountManagement";
            Load += frmAccountManagement_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvList;
        private DateTimePicker dtpOpenDate;
        private ComboBox cboCustomerName;
        private TextBox txtRegionName;
        private TextBox txtAccountName;
        private TextBox txtAccountId;
        private TextBox txtSearch;
        private Button btnSearch;
        private GroupBox groupBox2;
        private Button btnDelete;
        private Button btnClose;
        private Button btnUpdate;
        private Button btnAdd;
    }
}