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
            inputName = new TextBox();
            lblPassword = new Label();
            inputQuantity = new TextBox();
            lblUsername = new Label();
            inputPrice = new TextBox();
            label1 = new Label();
            comboBox_Type = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            inputID = new TextBox();
            SuspendLayout();
            // 
            // lblFullname
            // 
            lblFullname.AutoSize = true;
            lblFullname.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblFullname.Location = new Point(252, 102);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(109, 19);
            lblFullname.TabIndex = 19;
            lblFullname.Text = "Product Name";
            // 
            // inputName
            // 
            inputName.Location = new Point(252, 122);
            inputName.Margin = new Padding(3, 2, 3, 2);
            inputName.Name = "inputName";
            inputName.Size = new Size(301, 23);
            inputName.TabIndex = 18;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(252, 213);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 19);
            lblPassword.TabIndex = 17;
            lblPassword.Text = "Quantity";
            // 
            // inputQuantity
            // 
            inputQuantity.Location = new Point(252, 233);
            inputQuantity.Margin = new Padding(3, 2, 3, 2);
            inputQuantity.Name = "inputQuantity";
            inputQuantity.Size = new Size(301, 23);
            inputQuantity.TabIndex = 16;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(252, 156);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(42, 19);
            lblUsername.TabIndex = 15;
            lblUsername.Text = "Price";
            // 
            // inputPrice
            // 
            inputPrice.Location = new Point(252, 177);
            inputPrice.Margin = new Padding(3, 2, 3, 2);
            inputPrice.Name = "inputPrice";
            inputPrice.Size = new Size(301, 23);
            inputPrice.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(277, 284);
            label1.Name = "label1";
            label1.Size = new Size(41, 19);
            label1.TabIndex = 33;
            label1.Text = "Type";
            // 
            // comboBox_Type
            // 
            comboBox_Type.FormattingEnabled = true;
            comboBox_Type.Location = new Point(375, 284);
            comboBox_Type.Name = "comboBox_Type";
            comboBox_Type.Size = new Size(121, 23);
            comboBox_Type.TabIndex = 32;
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
            button1.TabIndex = 34;
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
            button2.TabIndex = 35;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(252, 48);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 37;
            label2.Text = "Product ID";
            // 
            // inputID
            // 
            inputID.Location = new Point(252, 68);
            inputID.Margin = new Padding(3, 2, 3, 2);
            inputID.Name = "inputID";
            inputID.Size = new Size(301, 23);
            inputID.TabIndex = 36;
            // 
            // frmEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(inputID);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBox_Type);
            Controls.Add(lblFullname);
            Controls.Add(inputName);
            Controls.Add(lblPassword);
            Controls.Add(inputQuantity);
            Controls.Add(lblUsername);
            Controls.Add(inputPrice);
            Name = "frmEdit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFullname;
        private TextBox inputName;
        private Label lblPassword;
        private TextBox inputQuantity;
        private Label lblUsername;
        private TextBox inputPrice;
        private Label label1;
        private ComboBox comboBox_Type;
        private Button button1;
        private Button button2;
        private Label label2;
        private TextBox inputID;
    }
}