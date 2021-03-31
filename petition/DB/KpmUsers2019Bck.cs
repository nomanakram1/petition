using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class KpmUsers2019Bck
    {
        public int KpmuserId { get; set; }
        public string KpmuserType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Enteredby { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public int? DnnUserId { get; set; }
        public int? CoordAssigned { get; set; }
        public string DisplayName { get; set; }
        public string Addr { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Telephone { get; set; }
        public string Status { get; set; }
        public int? DnnuserIdOld { get; set; }
    }
}
