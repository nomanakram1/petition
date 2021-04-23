using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Models.ViewModels
{
    [Keyless]
    public class PetitionStatsSubmitted
    {
        public string petitionname { get; set; }
        public string petitiondescription { get; set; }
        public double batchsubmittedcount { get; set; }
        public double batchrawcount { get; set; }
        public double batchnewreg { get; set; }
        public double batchpurgecount { get; set; }
    }
}
