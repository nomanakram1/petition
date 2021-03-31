using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class Voter
    {
        public string Ln { get; set; }
        public string Fn { get; set; }
        public string Mi { get; set; }
        public string Namesuffix { get; set; }
        public string County { get; set; }
        public string Ct { get; set; }
        public string Resstate { get; set; }
        public string Zp { get; set; }
        public string Resaddr { get; set; }
        public int Voterid { get; set; }
    }
}
