using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class CoordBatchListSubmitted
    {
        public string Circid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Coordassigned { get; set; }
        public int? Batchid { get; set; }
        public int? Initsigs { get; set; }
        public int? Circinitsigs { get; set; }
        public int? Rawcount { get; set; }
        public int? Purgecount { get; set; }
        public int? Netcount { get; set; }
    }
}
