using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class KpmcircReport
    {
        public string Circid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Coordassigned { get; set; }
        public int? Petitionid { get; set; }
        public int? Entryid { get; set; }
        public int? Batchid { get; set; }
        public int? Circinitsigs { get; set; }
        public int? Circrawcount { get; set; }
        public int? PcInitials { get; set; }
        public int? Pcpobox { get; set; }
        public int? PcdiffCounty { get; set; }
        public int? Pcincomaddr { get; set; }
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
