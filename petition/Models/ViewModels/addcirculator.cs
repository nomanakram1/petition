using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Models.ViewModels
{
    public class addcirculator
    {
        public int KpmuserId { get; set; }
        public string KpmuserType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Enteredby { get; set; }
        public int? DnnUserId { get; set; }
        public int? CoordAssigned { get; set; }
        public string DisplayName { get; set; }
        public string Addr { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Telephone { get; set; }
        public string Status { get; set; }
    }
}
