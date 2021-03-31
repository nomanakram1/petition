using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Models.ViewModels
{
    public class RegisterVM
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string zipCode { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("password",ErrorMessage ="Password and Confirm Password do Not Match")]
        public string ConfirmPassword { get; set; }
        [Required]
        public string userName { get; set; }
        public string phoneNumber { get; set; }

    }
}
