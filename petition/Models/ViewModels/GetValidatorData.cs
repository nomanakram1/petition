using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Models.ViewModels
{
    [Keyless]
    public class GetValidatorData
    {
        public string valid { get; set; }
        public double ttlgood { get; set; }
        public double ttlbad { get; set; }
        public double ttldup { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string petitionname { get; set; }
    }
}
