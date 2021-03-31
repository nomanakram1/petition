using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class VoterRecord2007
    {
        public DateTime? Dateentered { get; set; }
        public int PetitionId { get; set; }
        public int Batchid { get; set; }
        public int Voterid { get; set; }
        public string Enteredby { get; set; }
        public string County { get; set; }
        public int Circid { get; set; }
        public int Batchentryid { get; set; }
    }
}
