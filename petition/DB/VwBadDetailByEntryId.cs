using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class VwBadDetailByEntryId
    {
        public int BatchId { get; set; }
        public string Circfullname { get; set; }
        public int Entryid { get; set; }
        public int PetitionId { get; set; }
        public string Fn { get; set; }
        public string Ln { get; set; }
        public string Mi { get; set; }
        public string Resaddr { get; set; }
        public string Ct { get; set; }
        public string Resstate { get; set; }
        public string Zp { get; set; }
    }
}
