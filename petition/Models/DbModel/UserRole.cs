using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Models.DbModel
{
    public class UserRole
    {
        public int id { get; set; }
        public string userId { get; set; }
        public string roleId { get; set; }
        public string roleName { get; set; }
        public DateTime effectiveDate { get; set; }
        public DateTime expiryDate { get; set; }
    }
}
