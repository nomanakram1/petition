using Microsoft.EntityFrameworkCore;
using petition.DB;
using petition.Models;
using petition.Models.DbModel;
using petition.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.DataLayer
{
    public interface IBatchDL
    {
        public List<GetBatches> Getbatch(string KPMUserId, int PetitionId);
        public bool DeleteBatche(int id);
    }
    public class BatchDL : IBatchDL
    {
        private readonly AppDbContext context;
        public BatchDL(AppDbContext context)
        {
            this.context = context;
        }
        public List<GetBatches> Getbatch(string KPMUserId, int PetitionId)
        {
            var commandText = "SELECT dbo.Batches.BatchID, dbo.Batches.KPMUserID, dbo.Batches.dateAssgBatch, dbo.AspNetUsers.LastName, dbo.Petitions.petitionname, dbo.batches.sigvalue, dbo.Batches.dateReceivedBatch, dbo.batches.SubmittedCount, dbo.batches.RawCount, dbo.batches.PurgedCount, dbo.batches.datesubmitted,dbo.batches.ChargeBackCount,dbo.batches.ChargeBackDate,dbo.Batches.SubmittedCount - dbo.Batches.ChargeBackCount AS TotalSigs,SigAmount FROM dbo.Batches INNER JOIN dbo.AspNetUsers ON dbo.Batches.KPMUserID = dbo.AspNetUsers.Id INNER JOIN dbo.Petitions ON dbo.Batches.PetitionID = dbo.Petitions.PetitionID where dbo.batches.petitionid = " + PetitionId + " and dbo.Batches.KPMUserID = '" + KPMUserId + "' and datesubmitted is not null ORDER BY dbo.batches.batchid desc";
            //var commandText = "SELECT DISTINCT dbo.Batches.BatchID, dbo.Batches.KPMUserID, dbo.Batches.dateAssgBatch, dbo.AspNetUsers.lastname, dbo.Petitions.petitionname name, dbo.batches.sigvalue, dbo.batches.sigamount, dbo.Batches.dateReceivedBatch, dbo.batches.SubmittedCount, dbo.batches.RawCount, dbo.batches.PurgedCount, dbo.batches.datesubmitted FROM dbo.Batches INNER JOIN dbo.AspNetUsers ON dbo.Batches.KPMUserID = dbo.AspNetUsers.Id INNER JOIN dbo.Petitions ON dbo.Batches.PetitionID = dbo.Petitions.PetitionID where dbo.batches.petitionid = "+PetitionId+" AND dbo.Batches.KPMUserID = '"+KPMUserId+"' AND dbo.Batches.dateReceivedBatch IS NULL ORDER BY dbo.batches.batchid desc";
            var result = context.GetBatches.FromSqlRaw(commandText).ToList();
            return result;
        }
        public bool DeleteBatche(int id)
        {
            var commandText = "DELETE FROM dbo.batches WHERE (batchid = '" + id + "')";
            try
            {
                var result = context.Database.ExecuteSqlRaw(commandText);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
