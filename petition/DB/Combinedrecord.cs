using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class Combinedrecord
    {
        public int? Petitionid { get; set; }
        public string County { get; set; }
        public DateTime? Dateentered { get; set; }
        public int? Validcount { get; set; }
        public int? Badcount { get; set; }
    }
}
