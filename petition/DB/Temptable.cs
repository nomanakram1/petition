using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class Temptable
    {
        public string Coordinatorid { get; set; }
        public int PetitionId { get; set; }
    }
}
