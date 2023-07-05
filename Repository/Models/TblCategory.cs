using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class TblCategory
    {
        public TblCategory()
        {
            TblProducts = new HashSet<TblProduct>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TblProduct> TblProducts { get; set; }
    }
}
