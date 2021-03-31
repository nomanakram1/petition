using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class DailyReport
    {
        public string County { get; set; }
        public DateTime? Countdate { get; set; }
        public int? Petitionid { get; set; }
    }
}
