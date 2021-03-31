using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class Batches2007
    {
        public DateTime DateAssgBatch { get; set; }
        public int BatchId { get; set; }
        public int KpmuserId { get; set; }
        public string KpmuserName { get; set; }
        public int PetitionId { get; set; }
        public DateTime? DateReceivedBatch { get; set; }
        public short? SigValue { get; set; }
        public string Enteredby { get; set; }
        public int? InitialCount { get; set; }
        public int? RawCount { get; set; }
        public int? PurgedCount { get; set; }
        public DateTime? DateSubmitted { get; set; }
        public int? SubmittedCount { get; set; }
    }
}
