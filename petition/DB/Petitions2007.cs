using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class Petitions2007
    {
        public string Petitiondescription { get; set; }
        public string Petitionname { get; set; }
        public DateTime DateEntered { get; set; }
        public int PetitionId { get; set; }
        public DateTime? DateReceived { get; set; }
        public string EnteredBy { get; set; }
    }
}
