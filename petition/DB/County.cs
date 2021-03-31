using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class County
    {
        public string Countyname { get; set; }
        public int CountyId { get; set; }
    }
}
