using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class ValidatortotalsOldnew
    {
        public string Valid { get; set; }
        public decimal? Ttlgood { get; set; }
        public decimal? Ttlbad { get; set; }
        public decimal? Ttldup { get; set; }
    }
}
