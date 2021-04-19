using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Models.ViewModels
{
    [Keyless]
    public class GetPetitionCountyStats
    {
        public double county { get; set; }
        public double Ttlvalid { get; set; }
        public double Ttlbad { get; set; }
        public double Ttldup { get; set; }
        public double Ttlpercent { get; set; }
    }
}
