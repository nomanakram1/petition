using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class BatchDetail2007
    {
        public int BatchId { get; set; }
        public int Circid { get; set; }
        public string Circfullname { get; set; }
        public int Circinitsigs { get; set; }
        public int Entryid { get; set; }
        public int? Circrawcount { get; set; }
        public int? PcInitials { get; set; }
        public int? PcPobox { get; set; }
        public int? PcDiffCounty { get; set; }
        public int? PcIncomAddr { get; set; }
        public int? PcAddrIllegOrCopy { get; set; }
        public int? PcSigPrintedOrPrintIlleg { get; set; }
        public int? PcNameTwiceNoSig { get; set; }
        public int? PcHwsignForOther { get; set; }
        public int? PcWomanSignMrsHusbandFname { get; set; }
        public int? PcForgery { get; set; }
        public int? PcIncomDeclCirc { get; set; }
        public int? PcRubStampUsed { get; set; }
        public int? PcPencilUsed { get; set; }
        public int? PcDupSig { get; set; }
        public int? PcWhiteOut { get; set; }
        public int? PcOther { get; set; }
    }
}
