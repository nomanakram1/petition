using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class Coordinator
    {
        public string Coordinatorname { get; set; }
        public int CoordinatorId { get; set; }
        public string Enteredby { get; set; }
        public DateTime? Dateentered { get; set; }
    }
}
