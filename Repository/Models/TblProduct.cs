using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class TblProduct
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public int CategoryId { get; set; }
        public virtual TblCategory Category {
            get; set;
        }
    }
}
