using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class VoterDupsback
    {
        public int PetitionId { get; set; }
        public int BatchId { get; set; }
        public DateTime Dateentered { get; set; }
        public int VoterId { get; set; }
        public string Enteredby { get; set; }
        public int Recordid { get; set; }
        public string County { get; set; }
        public int Circid { get; set; }
        public int Batchentryid { get; set; }
    }
}
