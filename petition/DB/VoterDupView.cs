using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class VoterDupView
    {
        public string Petitionname { get; set; }
        public string County { get; set; }
        public int? Countycount { get; set; }
    }
}
