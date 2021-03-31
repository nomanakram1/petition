using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Models.ViewModels
{
    public class ResetPasswordVM
    {
        public string userId { get; set; }
        public string newPassword { get; set; }
    }
}
