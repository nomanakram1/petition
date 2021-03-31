using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class VwBatchesNotReceived
    {
        public int BatchId { get; set; }
        public string Petitionname { get; set; }
        public DateTime? DateSubmitted { get; set; }
        public DateTime? DateReceived { get; set; }
        public int? DnnUserId { get; set; }
        public int? Days { get; set; }
    }
}
