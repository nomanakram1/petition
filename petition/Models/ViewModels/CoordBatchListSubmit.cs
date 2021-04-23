using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Models.ViewModels
{
    [Keyless]
    public class CoordBatchListSubmit
    {
        public int coordassigned { get; set; }
        public string batchid { get; set; }
        public double initsigs { get; set; }
        public double circinitsigs { get; set; }
        public double rawcount { get; set; }
        public double purgecount { get; set; }
    }
}
