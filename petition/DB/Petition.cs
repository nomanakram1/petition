using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    public partial class Petition
    {
        public string Petitiondescription { get; set; }
        public string Petitionname { get; set; }
        public DateTime DateEntered { get; set; }
        public int PetitionId { get; set; }
        public DateTime? DateReceived { get; set; }
        public string EnteredBy { get; set; }
        public bool? Status { get; set; }
        public bool? CityPetition { get; set; }
        public DateTime? StartDate { get; set; }
    }
}
