using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class CoordBatchListSubmittedTemp
    {
        public int? Batchid { get; set; }
        public int? Suminitsigs { get; set; }
        public string Coordassigned { get; set; }
    }
}
