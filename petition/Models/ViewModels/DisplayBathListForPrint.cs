using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Models.ViewModels
{
    [Keyless]
    public class DisplayBathListForPrint
    {
        public int BatchID { get; set; }
        public int circid { get; set; }
        public string circfullname { get; set; }
        public int circinitsigs { get; set; }
        public int entryid { get; set; }        
        public int? circrawcount { get; set; }
        public int? pcInitials { get; set; }
        public int? pcPOBox { get; set; }
        public int? pcDiffCounty { get; set; }
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
        public int BatchStatus { get; set; }
        public int TotalSigs { get; set; }
        public int BadCount { get; set; }
        public int GoodCount { get; set; }
        public int GoodPercent { get; set; }
        public int SubmittedCount { get; set; }
    }
}
