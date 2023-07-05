using Repository.Models;
using Repository.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
            CategoryServices categoryServices = new CategoryServices();
            var categories = categoryServices.GetAll();
            foreach (var category in categories)
            {
                comboBox_Type.Items.Add(category.Name);
            }
            comboBox_Type.SelectedIndex = 0;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            //show dialog to ask user if they want to cancel
            var result = MessageBox.Show("Are you sure you want to cancel?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
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
            productServices.Create(product);
            this.Close();
        }
    }
}
