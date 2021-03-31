using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace petition.DB
{
    public partial class Batch
    {
        public DateTime DateAssgBatch { get; set; }
        [Key]

        public int BatchId { get; set; }
        public string KpmuserId { get; set; }
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
        public bool RawComplete { get; set; }
        public bool ProcessingComplete { get; set; }
        public bool ValidationComplete { get; set; }
        public DateTime? ChargeBackDate { get; set; }
        public int ChargeBackCount { get; set; }
        public decimal? SigAmount { get; set; }
    }
}
