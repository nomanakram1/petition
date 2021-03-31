using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
    }
}
