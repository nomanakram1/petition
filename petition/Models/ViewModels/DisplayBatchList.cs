using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Models.ViewModels
{
    [Keyless]
    public class DisplayBatchList
    {
        public string? firstname { get; set; }
        public string? lastname { get; set; }
        public int kpmuserid { get; set; }
        public int batchid { get; set; }
        public int circinitsigs { get; set; }
        public int entryid { get; set; }
        public int? circrawcount { get; set; }
        public int? pcInitials { get; set; }
        public int? pcpobox { get; set; }
        public int? pcdiffcounty { get; set; }
        public int? pcIncomAddr { get; set; }
        public int? pcAddrIllegOrCopy { get; set; }
        public int? pcSigPrintedOrPrintIlleg { get; set; }
        public int? pcNameTwiceNoSig { get; set; }
        public int? pcHWSignForOther { get; set; }
        public int? pcWomanSignMrsHusbandFname { get; set; }
        public int? pcForgery { get; set; }
        public int? pcIncomDeclCirc { get; set; }
        public int? pcRubStampUsed { get; set; }
        public int? pcPencilUsed { get; set; }
        public int? pcDupSig { get; set; }
        public int? pcWhiteOut { get; set; }
        public int? pcOther { get; set; }
        public int CircNewReg { get; set; }
        public int? BatchStatus { get; set; }
        public int TotalSigs { get; set; }
        public int BadTotal { get; set; }
        public int SubmittedCount { get; set; }
    }
}
