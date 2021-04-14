using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Models.ViewModels
{
    [Keyless]
    public class GetCoordinate
    {
        public string? firstname { get; set; }
        public string? lastname { get; set; }
        public int kpmuserID { get; set; }
        public string? coordassigned { get; set; }
    }
}
