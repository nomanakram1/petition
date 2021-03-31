using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Models.ViewModels
{
    [Keyless]
    public class GetPetetion
    {
        public string Petitiondescription { get; set; }
        public string Petitionname { get; set; }
        public int PetitionId { get; set; }
        public bool? Status { get; set; }
        public bool? CityPetition { get; set; }
    }
}
