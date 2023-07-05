using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class TblUser
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
