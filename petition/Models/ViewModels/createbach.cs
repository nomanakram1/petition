using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Models.ViewModels
{
    public class createbach
    {
        public DateTime dateAssgBatch { get; set; }

        public string kpmuserId { get; set; }
        public string kpmuserName { get; set; }
        public int petitionId { get; set; }
        public int sigValue { get; set; }
    }
}
