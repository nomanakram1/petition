using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class Totalupdate
    {
        public string Petitionname { get; set; }
        public string County { get; set; }
        public int? Countydups { get; set; }
    }
}
