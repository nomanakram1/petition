using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Models.ViewModels
{
    [Keyless]
    public class GetCirculator
    {
        public string lastname { get; set; }
        public string firstname { get; set; }
        public int kpmuserID { get; set; }
        public string coordassigned { get; set; }
        public string displayname { get; set; }
        public string addr { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string telephone { get; set; }
        public string status { get; set; }
    }
}
