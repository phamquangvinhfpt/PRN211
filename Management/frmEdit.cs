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
            string id = inputID.Text;
            string name = inputName.Text;
            decimal price = Convert.ToDecimal(inputPrice.Text);
            int quantity = Convert.ToInt32(inputQuantity.Text);
            string category = comboBox_Type.SelectedItem.ToString();
            ProductServices productServices = new ProductServices();
            CategoryServices categoryServices = new CategoryServices();
            var categories = categoryServices.GetAll();
            var categoryId = categories.Where(x => x.Name == category).FirstOrDefault().CategoryId;
            //Add new product
            var product = new TblProduct();
            product.ProductId = id;
            product.Name = name;
            product.Price = price;
            product.Quantity = quantity;
            product.CategoryId = categoryId;
            productServices.Update(product);
            this.Close();
            //set result to ok
            this.DialogResult = DialogResult.OK;
            //refresh data
            frmMain frmMain = new frmMain();
            frmMain.data();
        }
    }
}
