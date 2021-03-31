using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class CountyTotalsView
    {
        public string Petitionname { get; set; }
        public int Petid { get; set; }
        public DateTime Dupdate { get; set; }
        public int Dupvoterid { get; set; }
        public string Dupcounty { get; set; }
        public DateTime? Dateentered { get; set; }
        public int PetitionId { get; set; }
        public int Voterid { get; set; }
        public string County { get; set; }
    }
}
