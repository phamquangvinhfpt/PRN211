namespace Management
{
    partial class frmAdd
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
            lblID = new Label();
            inputID = new TextBox();
            lblPassword = new Label();
            inputPrice = new TextBox();
            lblUsername = new Label();
            inputName = new TextBox();
            lblFullName = new Label();
            inputQuantity = new TextBox();
            btn_Add = new Button();
            btn_Cancel = new Button();
            comboBox_Type = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblID.Location = new Point(233, 90);
            lblID.Name = "lblID";
            lblID.Size = new Size(22, 19);
            lblID.TabIndex = 11;
            lblID.Text = "ID";
            // 
            // inputID
            // 
            inputID.Location = new Point(233, 110);
            inputID.Margin = new Padding(3, 2, 3, 2);
            inputID.Name = "inputID";
            inputID.Size = new Size(301, 23);
            inputID.TabIndex = 10;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(233, 196);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(42, 19);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Price";
            // 
            // inputPrice
            // 
            inputPrice.Location = new Point(233, 216);
            inputPrice.Margin = new Padding(3, 2, 3, 2);
            inputPrice.Name = "inputPrice";
            inputPrice.Size = new Size(301, 23);
            inputPrice.TabIndex = 8;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(233, 145);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(109, 19);
            lblUsername.TabIndex = 7;
            lblUsername.Text = "Product Name";
            // 
            // inputName
            // 
            inputName.Location = new Point(233, 165);
            inputName.Margin = new Padding(3, 2, 3, 2);
            inputName.Name = "inputName";
            inputName.Size = new Size(301, 23);
            inputName.TabIndex = 6;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblFullName.Location = new Point(233, 244);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(70, 19);
            lblFullName.TabIndex = 17;
            lblFullName.Text = "Quantity";
            // 
            // inputQuantity
            // 
            inputQuantity.Location = new Point(233, 269);
            inputQuantity.Margin = new Padding(3, 2, 3, 2);
            inputQuantity.Name = "inputQuantity";
            inputQuantity.Size = new Size(301, 23);
            inputQuantity.TabIndex = 16;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.FromArgb(142, 167, 233);
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Add.Location = new Point(244, 361);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(98, 31);
            btn_Add.TabIndex = 28;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.FlatStyle = FlatStyle.Flat;
            btn_Cancel.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Cancel.ForeColor = Color.IndianRed;
            btn_Cancel.Location = new Point(408, 361);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(98, 31);
            btn_Cancel.TabIndex = 29;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // comboBox_Type
            // 
            comboBox_Type.FormattingEnabled = true;
            comboBox_Type.Location = new Point(332, 310);
            comboBox_Type.Name = "comboBox_Type";
            comboBox_Type.Size = new Size(121, 23);
            comboBox_Type.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(234, 310);
            label1.Name = "label1";
            label1.Size = new Size(41, 19);
            label1.TabIndex = 31;
            label1.Text = "Type";
            // 
            // frmAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 494);
            Controls.Add(label1);
            Controls.Add(comboBox_Type);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Add);
            Controls.Add(lblFullName);
            Controls.Add(inputQuantity);
            Controls.Add(lblID);
            Controls.Add(inputID);
            Controls.Add(lblPassword);
            Controls.Add(inputPrice);
            Controls.Add(lblUsername);
            Controls.Add(inputName);
            Name = "frmAdd";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Product";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private TextBox inputID;
        private Label lblPassword;
        private TextBox inputPrice;
        private Label lblUsername;
        private TextBox inputName;
        private Label lblFullName;
        private TextBox inputQuantity;
        private Button btn_Add;
        private Button btn_Cancel;
        private ComboBox comboBox_Type;
        private Label label1;
    }
}