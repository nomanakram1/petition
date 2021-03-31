using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace petition.DB
{
    [Keyless]
    public partial class Validator
    {
        public int? Validatorid { get; set; }
        public string Validatorname { get; set; }
        public int? Validcount { get; set; }
        public int? Notfoundcount { get; set; }
        public int? Dupcount { get; set; }
    }
}
