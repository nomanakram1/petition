using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class Validatortotal
    {
        public string Valid { get; set; }
        public decimal? Ttlgood { get; set; }
        public decimal? Ttlbad { get; set; }
        public decimal? Ttldup { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Petitionname { get; set; }
    }
}
