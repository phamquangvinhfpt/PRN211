using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class ProductServices : ServicesBase<TblProduct>
    {
        // delete product
        public bool DeleteProduct(string id)
        {
            bool result = false;
            try
            {
                using (var db = new ShoppingContext())
                {
                    TblProduct? productToDelete = db.TblProducts.Where(p => p.ProductId.Equals(id)).FirstOrDefault();
                    if (productToDelete != null)
                    {
                        db.TblProducts.Remove(productToDelete);
                        db.SaveChanges();
                        result = true;
                    }
                    else
                    {
                        throw new Exception("Product not found");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
