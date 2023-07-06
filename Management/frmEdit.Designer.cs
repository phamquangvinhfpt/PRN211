namespace Management
{
    partial class frmEdit
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
            lblFullname = new Label();
            inputID = new TextBox();
            lblPassword = new Label();
            inputPrice = new TextBox();
            lblUsername = new Label();
            inputName = new TextBox();
            label1 = new Label();
            comboBox_Type = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            inputQuantity = new TextBox();
            SuspendLayout();
            // 
            // lblFullname
            // 
            lblFullname.AutoSize = true;
            lblFullname.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblFullname.Location = new Point(253, 63);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(80, 19);
            lblFullname.TabIndex = 8;
            lblFullname.Text = "Product ID";
            // 
            // inputID
            // 
            inputID.Location = new Point(253, 83);
            inputID.Margin = new Padding(3, 2, 3, 2);
            inputID.Name = "inputID";
            inputID.Size = new Size(301, 23);
            inputID.TabIndex = 0;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(253, 174);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(42, 19);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Price";
            // 
            // inputPrice
            // 
            inputPrice.Location = new Point(253, 194);
            inputPrice.Margin = new Padding(3, 2, 3, 2);
            inputPrice.Name = "inputPrice";
            inputPrice.Size = new Size(301, 23);
            inputPrice.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(253, 117);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(51, 19);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "Name";
            // 
            // inputName
            // 
            inputName.Location = new Point(253, 138);
            inputName.Margin = new Padding(3, 2, 3, 2);
            inputName.Name = "inputName";
            inputName.Size = new Size(301, 23);
            inputName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(277, 284);
            label1.Name = "label1";
            label1.Size = new Size(41, 19);
            label1.TabIndex = 11;
            label1.Text = "Type";
            // 
            // comboBox_Type
            // 
            comboBox_Type.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Type.FormattingEnabled = true;
            comboBox_Type.Location = new Point(375, 284);
            comboBox_Type.Name = "comboBox_Type";
            comboBox_Type.Size = new Size(121, 23);
            comboBox_Type.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(142, 167, 233);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(277, 345);
            button1.Name = "button1";
            button1.Size = new Size(98, 31);
            button1.TabIndex = 5;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(245, 81, 81);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(444, 345);
            button2.Name = "button2";
            button2.Size = new Size(98, 31);
            button2.TabIndex = 6;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(253, 222);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 7;
            label2.Text = "Quantity";
            // 
            // inputQuantity
            // 
            inputQuantity.Location = new Point(253, 242);
            inputQuantity.Margin = new Padding(3, 2, 3, 2);
            inputQuantity.Name = "inputQuantity";
            inputQuantity.Size = new Size(301, 23);
            inputQuantity.TabIndex = 0;
            // 
            // frmEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(inputQuantity);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBox_Type);
            Controls.Add(lblFullname);
            Controls.Add(inputID);
            Controls.Add(lblPassword);
            Controls.Add(inputPrice);
            Controls.Add(lblUsername);
            Controls.Add(inputName);
            Name = "frmEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFullname;
        private TextBox inputID1;
        private Label lblPassword;
        private TextBox inputPrice;
        private Label lblUsername;
        private TextBox inputName;
        private Label label1;
        private ComboBox comboBox_Type;
        private Button button1;
        private Button button2;
        private Label label2;
        private TextBox inputQuantity;
        private TextBox inputID;
    }
}