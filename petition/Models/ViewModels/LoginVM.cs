using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Models.ViewModels
{
    public class LoginVM
    {
        [Required]
        public string userName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }
    }
}
