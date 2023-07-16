namespace PaperJournal_Form
{
    partial class frmLogin
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
            label1 = new Label();
            txtEmail = new TextBox();
            btnLogin = new Button();
            label2 = new Label();
            txtPass = new TextBox();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 68);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Account Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(160, 65);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(263, 27);
            txtEmail.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(160, 188);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(98, 40);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 119);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(160, 119);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(263, 27);
            txtPass.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(325, 188);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(98, 40);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(516, 290);
            Controls.Add(btnClose);
            Controls.Add(txtPass);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private Button btnLogin;
        private Label label2;
        private TextBox txtPass;
        private Button btnClose;
    }
}