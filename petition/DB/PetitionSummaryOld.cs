using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class PetitionSummaryOld
    {
        public int? Petitionid { get; set; }
        public int? Batchid { get; set; }
        public int? Batchinitcount { get; set; }
        public int? Batchrawcount { get; set; }
        public int? Batchpurgecount { get; set; }
    }
}
