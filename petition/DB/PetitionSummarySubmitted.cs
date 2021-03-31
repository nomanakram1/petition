using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class PetitionSummarySubmitted
    {
        public int? Petitionid { get; set; }
        public int? Batchid { get; set; }
        public int? Batchsubmittedcount { get; set; }
        public int? Batchrawcount { get; set; }
        public int? Batchpurgecount { get; set; }
        public int? Batchnewreg { get; set; }
    }
}
