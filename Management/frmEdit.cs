using Repository.Models;
using Repository.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management
{
    public partial class frmEdit : Form
    {
        public frmEdit()
        {
            InitializeComponent();
        }
        public frmEdit(string id, string name, decimal price, int quantity, string category)
        {
            InitializeComponent();
            CategoryServices categoryServices = new CategoryServices();
            var categories = categoryServices.GetAll();
            foreach (var item in categories)
            {
                comboBox_Type.Items.Add(item.Name);
            }
            inputID.Text = id;
            inputName.Text = name;
            inputPrice.Text = price.ToString();
            inputQuantity.Text = quantity.ToString();
            comboBox_Type.SelectedItem = category;
            inputID.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //show dialog to ask user if they want to cancel
            var result = MessageBox.Show("Are you sure you want to cancel?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check = true;
            string id = inputID.Text;
            string name;
            decimal price;
            int quantity;
            string category;
            int categoryId;
            ProductServices productServices = new ProductServices();
            CategoryServices categoryServices = new CategoryServices();
            //check fill all field
            if (inputID.Text == "" || inputName.Text == "" || inputPrice.Text == "" || inputQuantity.Text == "")
            {
                MessageBox.Show("Please fill all field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check = false;
            }
            //check inputId is exist
            id = inputID.Text;
            name = inputName.Text;
            price = Convert.ToDecimal(inputPrice.Text);
            quantity = Convert.ToInt32(inputQuantity.Text);
            category = comboBox_Type.SelectedItem.ToString();
            var categories = categoryServices.GetAll();
            categoryId = categories.Where(x => x.Name == category).FirstOrDefault().CategoryId;
            //check name is not a number
            if (name.All(char.IsDigit))
            {
                MessageBox.Show("Name is not a number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check = false;
            }
            //check price is not a string
            if (price.ToString().All(char.IsLetter))
            {
                MessageBox.Show("Price is not a string", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check = false;
            }
            else if (price < 0)
            {
                MessageBox.Show("Price is not a negative number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check = false;
            }
            //check quantity is not a string
            if (quantity.ToString().All(char.IsLetter))
            {
                MessageBox.Show("Quantity is not a string", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check = false;
            }
            else if (quantity < 0)
            {
                MessageBox.Show("Quantity is not a negative number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check = false;
            }
            if (check)
            {
                //Add new product
                var new_product = new TblProduct();
                new_product.ProductId = id;
                new_product.Name = name;
                new_product.Price = price;
                new_product.Quantity = quantity;
                new_product.CategoryId = categoryId;
                productServices.Update(new_product);
                this.Close();
                //set result to ok
                this.DialogResult = DialogResult.OK;
                //refresh data
                frmMain frmMain = new frmMain();
                frmMain.data();
            }
        }
    }
}
