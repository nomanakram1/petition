using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Models.ViewModels
{
    [Keyless]
    public class GetBatchList
    {
        public DateTime DateAssgBatch { get; set; }
        public int BatchId { get; set; }
        public int Petitionid { get; set; }
        public string KpmuserId { get; set; }
        public string Lastname { get; set; }
        public string Petitionname { get; set; }
        public DateTime? DateReceivedBatch { get; set; }
        public short? SigValue { get; set; }
        public int? RawCount { get; set; }
        public int? PurgedCount { get; set; }
        public DateTime? DateSubmitted { get; set; }
        public int? SubmittedCount { get; set; }
        public decimal? SigAmount { get; set; }
    }
}
