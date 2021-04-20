using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Models.ViewModels
{
    [Keyless]
    public class GetCircReportByPetitionCoordSubmitted
    {
        public string? firstname { get; set; }
        public string? lastname { get; set; }
        public string coordassigned { get; set; }
        public int circid { get; set; }
        public int circinitsigs { get; set; }
        public int? rawcount { get; set; }
        public int? pcInitials { get; set; }
        public int? pcpobox { get; set; }
        public int? pcdiffcounty { get; set; }
        public int? pcincomAddr { get; set; }
        public int? pcaddrIllegorcopy { get; set; }
        public int? pcsigprintedorprintIlleg { get; set; }
        public int? pcnametwicenosig { get; set; }
        public int? pchwsignforother { get; set; }
        public string? pcwomansignmrshusbandfname { get; set; }
        public int? pcforgery { get; set; }
        public int? pcincomdeclcirc { get; set; }
        public int? pcrubstampused { get; set; }
        public int? pcpencilused { get; set; }
        public int? pcdupsig { get; set; }
        public int? pcwhiteout { get; set; }
        public int? pcother { get; set; }
    }
}
