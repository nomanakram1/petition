using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    public partial class KpmUser
    {
        public int KpmuserId { get; set; }
        public string KpmuserType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Enteredby { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string? DnnUserId { get; set; }
        public string? CoordAssigned { get; set; }
        public string DisplayName { get; set; }
        public string Addr { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Telephone { get; set; }
        public string Status { get; set; }
        public string? DnnuserIdOld { get; set; }
    }
}
