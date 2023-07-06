using Microsoft.IdentityModel.Tokens;
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
            string id = inputID.Text.Trim();
            string name = inputName.Text.Trim();
            string price = inputPrice.Text.Trim();
            decimal priceDecimal = 0;
            string quantity = inputQuantity.Text.Trim();
            int quantityInt = 0;
            Validation val = new Validation();
            ProductServices productServices = new ProductServices();
            CategoryServices categoryServices = new CategoryServices();
            //check fill all field
            bool check = true;
            if (val.isEmpty(id, name, price, quantity))
            {
                string error = "";
                if (val.isEmpty(id))
                {
                    error += "ID, ";
                }
                if (val.isEmpty(name))
                {
                    error += "Name, ";
                }
                if (val.isEmpty(price))
                {
                    error += "Price, ";
                }
                if (val.isEmpty(quantity))
                {
                    error += "Quantity, ";
                }
                error = error.Substring(0, error.Length - 2);
                error += " can not be empty";
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (val.isEmpty(price))
                {

                }
            }
            else if (!val.formatID(id).IsNullOrEmpty())
            {
                string error = val.formatID(id);
                //check error id format
                if (error == "ID must be start with SW and follow by 3 numbers from 001" || error == "ID must be start with SW" || error == "ID wrong format")
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    check = false;
                }
            }

            //check isName 
            if (!val.isName(name).IsNullOrEmpty())
            {
                string error = val.isName(name);
                if (error == "Name must be not number")
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    check = false;
                }

            }
            //check isPrice
            if (val.isPrice(price) == -2)
            {
                MessageBox.Show("Price must be a positive number >0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }
            else
            {
                if (!price.IsNullOrEmpty())
                {
                    try
                    {
                        priceDecimal = decimal.Parse(price);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Price must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        check = false;
                    }
                }
            }
            //check isQuantity
            if (val.isQuantity(quantity) == -2)
            {
                MessageBox.Show("Quantity must be a positive number >0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }
            else
            {
                if (!quantity.IsNullOrEmpty())
                {
                    try
                    {
                        quantityInt = int.Parse(quantity);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Quantity must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        check = false;
                    }
                }
            }
            if (check)
            {
                var categories = categoryServices.GetAll();
                int categoryID = 0;
                foreach (var category in categories)
                {
                    if (category.Name == comboBox_Type.SelectedItem.ToString())
                    {
                        categoryID = category.CategoryId;
                    }
                }
                //Add new product
                var new_product = new TblProduct();
                new_product.ProductId = id;
                new_product.Name = name;
                new_product.Price = priceDecimal;
                new_product.Quantity = quantityInt;
                new_product.CategoryId = categoryID;
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
