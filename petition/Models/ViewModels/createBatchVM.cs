using petition.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Models.ViewModels
{
    public class createBatchVM
    {

        public List<GetPetetion> petitons { get; set; }
        public List<UserListVM> users { get; set; }
    }
}
