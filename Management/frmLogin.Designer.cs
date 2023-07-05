namespace Management
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            txtUsername = new TextBox();
            label1 = new Label();
            txtPassword = new TextBox();
            txtTitle = new Label();
            btnSignIn = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(73, 75, 244);
            label2.Location = new Point(248, 238);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 0;
            label2.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.AutoCompleteCustomSource.AddRange(new string[] { "admin" });
            txtUsername.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtUsername.BackColor = Color.FromArgb(209, 224, 255);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsername.Location = new Point(248, 182);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(305, 30);
            txtUsername.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(73, 75, 244);
            label1.Location = new Point(248, 160);
            label1.Name = "label1";
            label1.Size = new Size(87, 19);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.AutoCompleteCustomSource.AddRange(new string[] { "admin" });
            txtPassword.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtPassword.BackColor = Color.FromArgb(209, 224, 255);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(248, 260);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(305, 30);
            txtPassword.TabIndex = 1;
            // 
            // txtTitle
            // 
            txtTitle.AutoSize = true;
            txtTitle.BackColor = Color.Transparent;
            txtTitle.Font = new Font("Century Gothic", 17F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitle.ForeColor = Color.FromArgb(254, 112, 98);
            txtTitle.Location = new Point(283, 124);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(250, 27);
            txtTitle.TabIndex = 0;
            txtTitle.Text = "Management System";
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(79, 82, 255);
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.FlatAppearance.BorderColor = Color.White;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(309, 314);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(160, 38);
            btnSignIn.TabIndex = 2;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSignIn);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtUsername;
        private Label label1;
        private TextBox txtPassword;
        private Label txtTitle;
        private Button btnSignIn;
    }
}