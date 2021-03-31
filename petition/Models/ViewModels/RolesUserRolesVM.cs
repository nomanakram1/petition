using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Models.ViewModels
{
    public class RolesUserRolesVM
    {
        public UserListVM UserData { get; set; }
        public List<UserRolesVM> UserRoles { get; set; }
        public List<RolesVM> Roles { get; set; }
    }
}
