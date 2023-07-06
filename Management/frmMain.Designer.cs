namespace Management
{
    partial class frmMain
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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            cmbSearchBy = new ComboBox();
            label2 = new Label();
            txtSearch = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            btn_Delete = new Button();
            btn_Edit = new Button();
            btn_Add = new Button();
            dgvProducts = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(cmbSearchBy);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 87);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(663, 60);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(572, 60);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmbSearchBy
            // 
            cmbSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearchBy.FormattingEnabled = true;
            cmbSearchBy.Location = new Point(572, 31);
            cmbSearchBy.Name = "cmbSearchBy";
            cmbSearchBy.Size = new Size(75, 23);
            cmbSearchBy.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(513, 29);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 2;
            label2.Text = "Filter";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(69, 61);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(493, 23);
            txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 61);
            label1.Name = "label1";
            label1.Size = new Size(60, 18);
            label1.TabIndex = 0;
            label1.Text = "Search";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_Delete);
            panel2.Controls.Add(btn_Edit);
            panel2.Controls.Add(btn_Add);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(647, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(153, 363);
            panel2.TabIndex = 1;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.FromArgb(235, 70, 96);
            btn_Delete.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Delete.Location = new Point(6, 183);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(138, 32);
            btn_Delete.TabIndex = 2;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.BackColor = Color.FromArgb(255, 184, 77);
            btn_Edit.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Edit.Location = new Point(6, 140);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(138, 32);
            btn_Edit.TabIndex = 1;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = false;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.FromArgb(125, 185, 182);
            btn_Add.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Add.ForeColor = SystemColors.ButtonHighlight;
            btn_Add.Location = new Point(6, 95);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(138, 32);
            btn_Add.TabIndex = 0;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(0, 87);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowTemplate.Height = 25;
            dgvProducts.Size = new Size(647, 363);
            dgvProducts.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProducts);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvProducts;
        private Button btn_Delete;
        private Button btn_Edit;
        private Button btn_Add;
        private ComboBox cmbSearchBy;
        private Label label2;
        private TextBox txtSearch;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}