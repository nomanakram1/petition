using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class KpmUserTransferTable
    {
        public int? Transferid { get; set; }
    }
}
