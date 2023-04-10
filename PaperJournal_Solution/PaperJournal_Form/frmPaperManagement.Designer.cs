namespace PaperJournal_Form
{
    partial class frmPaperManagement
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
            groupBox1 = new GroupBox();
            dtpSubmitDate = new DateTimePicker();
            label6 = new Label();
            txtAuthor = new TextBox();
            label5 = new Label();
            txtAbstract = new TextBox();
            label4 = new Label();
            cboJounal = new ComboBox();
            txtPaperTitle = new TextBox();
            txtPaperId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnDelete = new Button();
            btnClose = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvList
            // 
            dgvList.AllowUserToAddRows = false;
            dgvList.AllowUserToDeleteRows = false;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(36, 294);
            dgvList.Name = "dgvList";
            dgvList.ReadOnly = true;
            dgvList.RowTemplate.Height = 25;
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvList.Size = new Size(1031, 319);
            dgvList.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpSubmitDate);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtAuthor);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtAbstract);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cboJounal);
            groupBox1.Controls.Add(txtPaperTitle);
            groupBox1.Controls.Add(txtPaperId);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(36, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1031, 184);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // dtpSubmitDate
            // 
            dtpSubmitDate.Location = new Point(685, 122);
            dtpSubmitDate.Name = "dtpSubmitDate";
            dtpSubmitDate.Size = new Size(293, 27);
            dtpSubmitDate.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(565, 125);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 10;
            label6.Text = "Submitted Date";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(685, 84);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(293, 27);
            txtAuthor.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(615, 91);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 8;
            label5.Text = "Author";
            // 
            // txtAbstract
            // 
            txtAbstract.Location = new Point(685, 44);
            txtAbstract.Name = "txtAbstract";
            txtAbstract.Size = new Size(293, 27);
            txtAbstract.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(615, 48);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 6;
            label4.Text = "Abstract";
            // 
            // cboJounal
            // 
            cboJounal.DropDownStyle = ComboBoxStyle.DropDownList;
            cboJounal.FormattingEnabled = true;
            cboJounal.Location = new Point(134, 122);
            cboJounal.Name = "cboJounal";
            cboJounal.Size = new Size(293, 28);
            cboJounal.TabIndex = 5;
            // 
            // txtPaperTitle
            // 
            txtPaperTitle.Location = new Point(134, 84);
            txtPaperTitle.Name = "txtPaperTitle";
            txtPaperTitle.Size = new Size(293, 27);
            txtPaperTitle.TabIndex = 4;
            // 
            // txtPaperId
            // 
            txtPaperId.Location = new Point(134, 48);
            txtPaperId.Name = "txtPaperId";
            txtPaperId.Size = new Size(293, 27);
            txtPaperId.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 125);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 2;
            label3.Text = "Journal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 87);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Paper Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 51);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Paper ID";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnClose);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Location = new Point(36, 619);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1031, 105);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(695, 44);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(105, 27);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(873, 44);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(105, 27);
            btnClose.TabIndex = 16;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(222, 44);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(105, 27);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(43, 44);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 27);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(258, 243);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(397, 27);
            txtSearch.TabIndex = 12;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(683, 243);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(236, 27);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search by Author or Paper Title";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // frmPaperManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 755);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvList);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmPaperManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Paper Management";
            Load += frmPaperManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvList;
        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txtAbstract;
        private Label label4;
        private ComboBox cboJounal;
        private TextBox txtPaperTitle;
        private TextBox txtPaperId;
        private Label label6;
        private TextBox txtAuthor;
        private DateTimePicker dtpSubmitDate;
        private Button btnDelete;
        private Button btnClose;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}