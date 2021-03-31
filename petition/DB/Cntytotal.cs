using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class Cntytotal
    {
        public string County { get; set; }
        public decimal? Ttlvalid { get; set; }
        public decimal? Ttlbad { get; set; }
        public decimal? Ttldup { get; set; }
        public decimal? Ttlpercent { get; set; }
    }
}
