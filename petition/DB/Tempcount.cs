using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class Tempcount
    {
        public string Petitionname { get; set; }
        public string County { get; set; }
        public int? Votercount { get; set; }
        public int? Badcount { get; set; }
    }
}
