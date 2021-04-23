using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Models.ViewModels
{
    [Keyless]
    public class KPMBatchesGetSubmittedByPetByDateRange
    {
        public int? BatchID { get; set; }
        public DateTime? dateAssgBatch { get; set; }
        public string lastname { get; set; }
        public string petitionname { get; set; }
        public double SigAmount { get; set; }
        public DateTime dateReceivedBatch { get; set; }
        public double SubmittedCount { get; set; }
        public double RawCount { get; set; }
        public double PurgedCount { get; set; }
        public DateTime datesubmitted { get; set; }
    }
}
