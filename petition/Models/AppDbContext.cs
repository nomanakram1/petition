using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using petition.DB;
using petition.Models.DbModel;
using petition.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Models
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }
        public DbSet<ApplicationIdentityUser> MyProperty { get; set; }

        public DbSet<UserRole> userRoles { get; set; }
        public  DbSet<Batch> Batches { get; set; }
        public  DbSet<BatchDetail> BatchDetails { get; set; }
        public  DbSet<City> Cities { get; set; }
        public  DbSet<CityVoter> CityVoters { get; set; }
        public  DbSet<Cntybad> Cntybads { get; set; }
        public  DbSet<Cntydup> Cntydups { get; set; }
        public  DbSet<Cntygood> Cntygoods { get; set; }
        public  DbSet<Cntytotal> Cntytotals { get; set; }
        public  DbSet<Combinedrecord> Combinedrecords { get; set; }
        public  DbSet<CoordBatchList> CoordBatchLists { get; set; }
        public  DbSet<CoordBatchListSubmitted> CoordBatchListSubmitteds { get; set; }
        public  DbSet<CoordBatchListSubmittedTemp> CoordBatchListSubmittedTemps { get; set; }
        public  DbSet<CoordBatchListTemp> CoordBatchListTemps { get; set; }
        public  DbSet<CoordDup> CoordDups { get; set; }
        public  DbSet<CoordSummary> CoordSummaries { get; set; }
        public  DbSet<CoordUpdate> CoordUpdates { get; set; }
        public  DbSet<Coordinator> Coordinators { get; set; }
        public  DbSet<County> Counties { get; set; }
        public  DbSet<CountyTotalsView> CountyTotalsViews { get; set; }
        public  DbSet<DailyReport> DailyReports { get; set; }
        public  DbSet<KpmCoordUpdate> KpmCoordUpdates { get; set; }
        public  DbSet<KpmUser> KpmUsers { get; set; }
        public  DbSet<KpmUserTransferTable> KpmUserTransferTables { get; set; }
        public  DbSet<KpmUsersBck> KpmUsersBcks { get; set; }
        public  DbSet<KpmUsersEmpty> KpmUsersEmpties { get; set; }
        public  DbSet<KpmUsersSav> KpmUsersSavs { get; set; }
        public  DbSet<KpmcircReport> KpmcircReports { get; set; }
        public  DbSet<KpmcircReportSubmitted> KpmcircReportSubmitteds { get; set; }
        public  DbSet<Petition> Petitions { get; set; }
        public  DbSet<PetitionSummary> PetitionSummaries { get; set; }
        public  DbSet<PetitionSummarySubmitted> PetitionSummarySubmitteds { get; set; }
        public  DbSet<Tempcount> Tempcounts { get; set; }
        public  DbSet<Temptable> Temptables { get; set; }
        public  DbSet<Totalupdate> Totalupdates { get; set; }
        public  DbSet<Validator> Validators { get; set; }
        public  DbSet<Validatorcount> Validatorcounts { get; set; }
        public  DbSet<Validatortotal> Validatortotals { get; set; }
        public  DbSet<Validatortotals3valid> Validatortotals3valids { get; set; }
        public  DbSet<ValidatortotalsOldnew> ValidatortotalsOldnews { get; set; }
        public  DbSet<Validatortotalsall> Validatortotalsalls { get; set; }
        public  DbSet<Voter> Voters { get; set; }
        public  DbSet<VoterDup> VoterDups { get; set; }
        public  DbSet<VoterRecord> VoterRecords { get; set; }
        public  DbSet<VwBadDetailByEntryId> VwBadDetailByEntryIds { get; set; }
        public  DbSet<VwBatchesNotReceived> VwBatchesNotReceiveds { get; set; }
        public  DbSet<VwGoodDetailByEntryId> VwGoodDetailByEntryIds { get; set; }
        public  DbSet<VwVoterDupsWpetitionName> VwVoterDupsWpetitionNames { get; set; }
        public  DbSet<VwVoterRecordWpetitionName> VwVoterRecordWpetitionNames { get; set; }



        ///////classes used for sql queries ///////////////

        public DbSet<GetPetetion> GetPetetion { get; set; }
        public DbSet<GetBatches> GetBatches { get; set; }
        public DbSet<GetBatchList> GetBatchList { get; set; }
        public DbSet<DisplayBatchList> DisplayBatchList { get; set; }
        public DbSet<DisplayBathListForPrint> DisplayBathListForPrint { get; set; }
        public DbSet<GetCirculator> GetCirculator { get; set; }
        public DbSet<GetCoordinate> GetCoordinate { get; set; }
        public DbSet<KPMBatchesGetSubmittedByPetByDateRange> KPMBatchesGetSubmittedByPetByDateRange { get; set; }
        public DbSet<PetitionStatsSubmitted> PetitionStatsSubmitted { get; set; }
        public DbSet<GetPetitionCountyStats> GetPetitionCountyStats { get; set; }
        public DbSet<CoordBatchListSubmit> CoordBatchListSubmit { get; set; }
        public DbSet<GetValidatorData> GetValidatorData { get; set; }

    }
}
