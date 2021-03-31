using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class Validatorcount
    {
        public string ValId { get; set; }
        public int? RoleId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Rolename { get; set; }
        public int? Validcount { get; set; }
        public int? Badcount { get; set; }
        public int? Dupcount { get; set; }
    }
}
