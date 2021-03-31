using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Models.ViewModels
{
    public class UserRolesVM
    {
        public int Id { get; set; }
        public string userId { get; set; }
        public string roleId { get; set; }
        public string roleName { get; set; }
        public DateTime effectiveDate { get; set; }
        public DateTime expiryDate { get; set; }
    }
}
