using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class Cntybad
    {
        public int? Petitionid { get; set; }
        public string County { get; set; }
        public int? Badcount { get; set; }
    }
}
