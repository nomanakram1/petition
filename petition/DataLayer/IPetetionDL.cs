using Microsoft.EntityFrameworkCore;
using petition.DB;
using petition.Models;
using petition.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.DataLayer
{
    public interface IPetetionDL
    {
        public List<GetPetetion> GetPetition();
    }
    public class PetetionDL : IPetetionDL
    {
        private readonly AppDbContext context;
        public PetetionDL(AppDbContext context)
        {
            this.context = context;
        }
        public List<GetPetetion> GetPetition()
        {
            var commandText = "SELECT Petitionname, PetitionDescription, petitionID,Status,CityPetition FROM petitions order by petitionname";
            var result = context.GetPetetion.FromSqlRaw(commandText).ToList();
            return result;
        }
    }
}
