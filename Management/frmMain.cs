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
    public partial class frmMain : Form
    {
        ProductServices _productServices = new ProductServices();
        CategoryServices CategoryServices = new CategoryServices();
        public frmMain()
        {
            InitializeComponent();
            data();
            //set value for cmbSearchBy
            cmbSearchBy.Items.Add("Id");
            cmbSearchBy.Items.Add("Name");
            cmbSearchBy.SelectedIndex = 0;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frmAdd frmAdd = new frmAdd();
            frmAdd.ShowDialog();
            //refresh data
            data();
        }

        public void data()
        {
            var products = _productServices.GetAll();
            var categories = CategoryServices.GetAll();
            foreach (var product in products)
            {
                var category = categories.Where(x => x.CategoryId == product.CategoryId).FirstOrDefault();
                if (category != null)
                {
                    product.Category = category;
                }
            }
            var Product = products.Select(
                               x => new
                               {
                                   x.ProductId,
                                   x.Name,
                                   x.Price,
                                   x.Quantity,
                                   CategoryName = x.Category.Name
                               }
                                                         ).ToList();
            dgvProducts.DataSource = Product;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //check if user select a row
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //show dialog to ask user if they want to delete
            var result = MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string id = dgvProducts.SelectedRows[0].Cells[0].Value.ToString();
                _productServices.DeleteProduct(id);

                //check if product is deleted 
                if (_productServices.GetAll().Where(x => x.ProductId == id).FirstOrDefault() == null)
                {
                    MessageBox.Show("Delete successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delete failed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //refresh data
                data();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            //check if user select a row
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string id = dgvProducts.SelectedRows[0].Cells[0].Value.ToString();
            string name = dgvProducts.SelectedRows[0].Cells[1].Value.ToString();
            decimal price = Convert.ToDecimal(dgvProducts.SelectedRows[0].Cells[2].Value.ToString());
            int quantity = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells[3].Value.ToString());
            string category = dgvProducts.SelectedRows[0].Cells[4].Value.ToString();
            frmEdit frmEdit = new frmEdit(id, name, price, quantity, category);
            frmEdit.ShowDialog();
            //refresh data
            //open main form again
            this.Hide();
            frmMain frmMain = new frmMain();
            frmMain.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Get search value
            string searchValue = txtSearch.Text;
            //Get search by
            string searchBy = cmbSearchBy.SelectedItem.ToString();
            if (searchBy.Equals("Id"))
            {
                txtSearch.Text = searchValue;
                var products = _productServices.GetAll().Where(x => x.ProductId.ToLower().Contains(searchValue.ToLower())).ToList();
                var categories = CategoryServices.GetAll();
                foreach (var product in products)
                {
                    var category = categories.Where(x => x.CategoryId == product.CategoryId).FirstOrDefault();
                    if (category != null)
                    {
                        product.Category = category;
                    }
                }
                var Product = products.Select(
                   x => new
                   {
                       x.ProductId,
                       x.Name,
                       x.Price,
                       x.Quantity,
                       CategoryName = x.Category.Name
                   }).ToList();
                dgvProducts.DataSource = Product;
            }
            else if (searchBy.Equals("Name"))
            {
                txtSearch.Text = searchValue;
                var products = _productServices.GetAll().Where(x => x.Name.ToLower().Contains(searchValue.ToLower())).ToList();
                var categories = CategoryServices.GetAll();
                foreach (var product in products)
                {
                    var category = categories.Where(x => x.CategoryId == product.CategoryId).FirstOrDefault();
                    if (category != null)
                    {
                        product.Category = category;
                    }
                }
                var Product = products.Select(
                                      x => new
                                      {
                                          x.ProductId,
                                          x.Name,
                                          x.Price,
                                          x.Quantity,
                                          CategoryName = x.Category.Name
                                      }).ToList();
                dgvProducts.DataSource = Product;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //reset txtSearch
            txtSearch.Text = "";
            button1_Click(sender, e);
        }
    }
}
