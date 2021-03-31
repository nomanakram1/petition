//using Microsoft.EntityFrameworkCore;

//#nullable disable

//namespace petition.DB
//{
//    public partial class KPMdb2014Context : DbContext
//    {
//        public KPMdb2014Context()
//        {
//        }

//        public KPMdb2014Context(DbContextOptions<KPMdb2014Context> options)
//            : base(options)
//        {
//        }

//        public virtual DbSet<Batch> Batches { get; set; }
//        public virtual DbSet<BatchDetail> BatchDetails { get; set; }
//        public virtual DbSet<BatchDetail2007> BatchDetail2007s { get; set; }
//        public virtual DbSet<BatchDetail2020> BatchDetail2020s { get; set; }
//        public virtual DbSet<Batches2007> Batches2007s { get; set; }
//        public virtual DbSet<Batches2020> Batches2020s { get; set; }
//        public virtual DbSet<City> Cities { get; set; }
//        public virtual DbSet<CityVoter> CityVoters { get; set; }
//        public virtual DbSet<Cntybad> Cntybads { get; set; }
//        public virtual DbSet<Cntydup> Cntydups { get; set; }
//        public virtual DbSet<Cntygood> Cntygoods { get; set; }
//        public virtual DbSet<Cntytotal> Cntytotals { get; set; }
//        public virtual DbSet<Combinedrecord> Combinedrecords { get; set; }
//        public virtual DbSet<CoordBatchList> CoordBatchLists { get; set; }
//        public virtual DbSet<CoordBatchListSubmitted> CoordBatchListSubmitteds { get; set; }
//        public virtual DbSet<CoordBatchListSubmittedTemp> CoordBatchListSubmittedTemps { get; set; }
//        public virtual DbSet<CoordBatchListTemp> CoordBatchListTemps { get; set; }
//        public virtual DbSet<CoordDup> CoordDups { get; set; }
//        public virtual DbSet<CoordSummary> CoordSummaries { get; set; }
//        public virtual DbSet<CoordUpdate> CoordUpdates { get; set; }
//        public virtual DbSet<CoordUpdates2007> CoordUpdates2007s { get; set; }
//        public virtual DbSet<Coordinator> Coordinators { get; set; }
//        public virtual DbSet<County> Counties { get; set; }
//        public virtual DbSet<CountyTotalsView> CountyTotalsViews { get; set; }
//        public virtual DbSet<DailyReport> DailyReports { get; set; }
//        public virtual DbSet<KpmCoordUpdate> KpmCoordUpdates { get; set; }
//        public virtual DbSet<KpmUser> KpmUsers { get; set; }
//        public virtual DbSet<KpmUserTransferTable> KpmUserTransferTables { get; set; }
//        public virtual DbSet<KpmUsers2009Blended> KpmUsers2009Blendeds { get; set; }
//        public virtual DbSet<KpmUsers2019Bck> KpmUsers2019Bcks { get; set; }
//        public virtual DbSet<KpmUsers2020> KpmUsers2020s { get; set; }
//        public virtual DbSet<KpmUsersBck> KpmUsersBcks { get; set; }
//        public virtual DbSet<KpmUsersEmpty> KpmUsersEmpties { get; set; }
//        public virtual DbSet<KpmUsersSav> KpmUsersSavs { get; set; }
//        public virtual DbSet<KpmcircReport> KpmcircReports { get; set; }
//        public virtual DbSet<KpmcircReportSubmitted> KpmcircReportSubmitteds { get; set; }
//        public virtual DbSet<Petition> Petitions { get; set; }
//        public virtual DbSet<PetitionSummary> PetitionSummaries { get; set; }
//        public virtual DbSet<PetitionSummaryOld> PetitionSummaryOlds { get; set; }
//        public virtual DbSet<PetitionSummarySubmitted> PetitionSummarySubmitteds { get; set; }
//        public virtual DbSet<Petitions2007> Petitions2007s { get; set; }
//        public virtual DbSet<Tempcount> Tempcounts { get; set; }
//        public virtual DbSet<Temptable> Temptables { get; set; }
//        public virtual DbSet<Totalupdate> Totalupdates { get; set; }
//        public virtual DbSet<Validator> Validators { get; set; }
//        public virtual DbSet<Validatorcount> Validatorcounts { get; set; }
//        public virtual DbSet<Validatortotal> Validatortotals { get; set; }
//        public virtual DbSet<Validatortotals3valid> Validatortotals3valids { get; set; }
//        public virtual DbSet<ValidatortotalsOldnew> ValidatortotalsOldnews { get; set; }
//        public virtual DbSet<Validatortotalsall> Validatortotalsalls { get; set; }
//        public virtual DbSet<Voter> Voters { get; set; }
//        public virtual DbSet<VoterDup> VoterDups { get; set; }
//        public virtual DbSet<VoterDupView> VoterDupViews { get; set; }
//        public virtual DbSet<VoterDups2007> VoterDups2007s { get; set; }
//        public virtual DbSet<VoterDups2020> VoterDups2020s { get; set; }
//        public virtual DbSet<VoterDupsback> VoterDupsbacks { get; set; }
//        public virtual DbSet<VoterRecord> VoterRecords { get; set; }
//        public virtual DbSet<VoterRecord2007> VoterRecord2007s { get; set; }
//        public virtual DbSet<VoterRecord2020> VoterRecord2020s { get; set; }
//        public virtual DbSet<VoterRecordView> VoterRecordViews { get; set; }
//        public virtual DbSet<VwBadDetailByEntryId> VwBadDetailByEntryIds { get; set; }
//        public virtual DbSet<VwBatchesNotReceived> VwBatchesNotReceiveds { get; set; }
//        public virtual DbSet<VwGoodDetailByEntryId> VwGoodDetailByEntryIds { get; set; }
//        public virtual DbSet<VwVoterDupsWpetitionName> VwVoterDupsWpetitionNames { get; set; }
//        public virtual DbSet<VwVoterRecordWpetitionName> VwVoterRecordWpetitionNames { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=DESKTOP-N7J7833;Database=KPMdb2014;Trusted_Connection=True;");
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

//            modelBuilder.Entity<Batch>(entity =>
//            {
//                entity.Property(e => e.BatchId).HasColumnName("BatchID");

//                entity.Property(e => e.ChargeBackDate).HasColumnType("smalldatetime");

//                entity.Property(e => e.DateAssgBatch)
//                    .HasColumnType("smalldatetime")
//                    .HasColumnName("dateAssgBatch");

//                entity.Property(e => e.DateReceivedBatch)
//                    .HasColumnType("smalldatetime")
//                    .HasColumnName("dateReceivedBatch");

//                entity.Property(e => e.DateSubmitted).HasColumnType("smalldatetime");

//                entity.Property(e => e.Enteredby)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("enteredby")
//                    .IsFixedLength(true);

//                entity.Property(e => e.KpmuserId).HasColumnName("KPMUserID");

//                entity.Property(e => e.KpmuserName)
//                    .HasMaxLength(30)
//                    .IsUnicode(false)
//                    .HasColumnName("KPMUserName");

//                entity.Property(e => e.PetitionId).HasColumnName("PetitionID");

//                entity.Property(e => e.SigAmount)
//                    .HasColumnType("money")
//                    .HasDefaultValueSql("((0))");
//            });

//            modelBuilder.Entity<BatchDetail>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("BatchDetail");

//                entity.Property(e => e.BatchId).HasColumnName("BatchID");

//                entity.Property(e => e.Circfullname)
//                    .HasMaxLength(30)
//                    .IsUnicode(false)
//                    .HasColumnName("circfullname");

//                entity.Property(e => e.Circid).HasColumnName("circid");

//                entity.Property(e => e.Circinitsigs).HasColumnName("circinitsigs");

//                entity.Property(e => e.Circrawcount).HasColumnName("circrawcount");

//                entity.Property(e => e.Entryid)
//                    .ValueGeneratedOnAdd()
//                    .HasColumnName("entryid");

//                entity.Property(e => e.PcAddrIllegOrCopy).HasColumnName("pcAddrIllegOrCopy");

//                entity.Property(e => e.PcDiffCounty).HasColumnName("pcDiffCounty");

//                entity.Property(e => e.PcDupSig).HasColumnName("pcDupSig");

//                entity.Property(e => e.PcForgery).HasColumnName("pcForgery");

//                entity.Property(e => e.PcHwsignForOther).HasColumnName("pcHWSignForOther");

//                entity.Property(e => e.PcIncomAddr).HasColumnName("pcIncomAddr");

//                entity.Property(e => e.PcIncomDeclCirc).HasColumnName("pcIncomDeclCirc");

//                entity.Property(e => e.PcInitials).HasColumnName("pcInitials");

//                entity.Property(e => e.PcNameTwiceNoSig).HasColumnName("pcNameTwiceNoSig");

//                entity.Property(e => e.PcOther).HasColumnName("pcOther");

//                entity.Property(e => e.PcPencilUsed).HasColumnName("pcPencilUsed");

//                entity.Property(e => e.PcPobox).HasColumnName("pcPOBox");

//                entity.Property(e => e.PcRubStampUsed).HasColumnName("pcRubStampUsed");

//                entity.Property(e => e.PcSigPrintedOrPrintIlleg).HasColumnName("pcSigPrintedOrPrintIlleg");

//                entity.Property(e => e.PcWhiteOut).HasColumnName("pcWhiteOut");

//                entity.Property(e => e.PcWomanSignMrsHusbandFname).HasColumnName("pcWomanSignMrsHusbandFname");
//            });

//            modelBuilder.Entity<BatchDetail2007>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("BatchDetail_2007");

//                entity.Property(e => e.BatchId).HasColumnName("BatchID");

//                entity.Property(e => e.Circfullname)
//                    .HasMaxLength(30)
//                    .IsUnicode(false)
//                    .HasColumnName("circfullname");

//                entity.Property(e => e.Circid).HasColumnName("circid");

//                entity.Property(e => e.Circinitsigs).HasColumnName("circinitsigs");

//                entity.Property(e => e.Circrawcount).HasColumnName("circrawcount");

//                entity.Property(e => e.Entryid)
//                    .ValueGeneratedOnAdd()
//                    .HasColumnName("entryid");

//                entity.Property(e => e.PcAddrIllegOrCopy).HasColumnName("pcAddrIllegOrCopy");

//                entity.Property(e => e.PcDiffCounty).HasColumnName("pcDiffCounty");

//                entity.Property(e => e.PcDupSig).HasColumnName("pcDupSig");

//                entity.Property(e => e.PcForgery).HasColumnName("pcForgery");

//                entity.Property(e => e.PcHwsignForOther).HasColumnName("pcHWSignForOther");

//                entity.Property(e => e.PcIncomAddr).HasColumnName("pcIncomAddr");

//                entity.Property(e => e.PcIncomDeclCirc).HasColumnName("pcIncomDeclCirc");

//                entity.Property(e => e.PcInitials).HasColumnName("pcInitials");

//                entity.Property(e => e.PcNameTwiceNoSig).HasColumnName("pcNameTwiceNoSig");

//                entity.Property(e => e.PcOther).HasColumnName("pcOther");

//                entity.Property(e => e.PcPencilUsed).HasColumnName("pcPencilUsed");

//                entity.Property(e => e.PcPobox).HasColumnName("pcPOBox");

//                entity.Property(e => e.PcRubStampUsed).HasColumnName("pcRubStampUsed");

//                entity.Property(e => e.PcSigPrintedOrPrintIlleg).HasColumnName("pcSigPrintedOrPrintIlleg");

//                entity.Property(e => e.PcWhiteOut).HasColumnName("pcWhiteOut");

//                entity.Property(e => e.PcWomanSignMrsHusbandFname).HasColumnName("pcWomanSignMrsHusbandFname");
//            });

//            modelBuilder.Entity<BatchDetail2020>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("BatchDetail_2020");

//                entity.Property(e => e.BatchId).HasColumnName("BatchID");

//                entity.Property(e => e.Circfullname)
//                    .HasMaxLength(30)
//                    .IsUnicode(false)
//                    .HasColumnName("circfullname");

//                entity.Property(e => e.Circid).HasColumnName("circid");

//                entity.Property(e => e.Circinitsigs).HasColumnName("circinitsigs");

//                entity.Property(e => e.Circrawcount).HasColumnName("circrawcount");

//                entity.Property(e => e.Entryid).HasColumnName("entryid");

//                entity.Property(e => e.PcAddrIllegOrCopy).HasColumnName("pcAddrIllegOrCopy");

//                entity.Property(e => e.PcDiffCounty).HasColumnName("pcDiffCounty");

//                entity.Property(e => e.PcDupSig).HasColumnName("pcDupSig");

//                entity.Property(e => e.PcForgery).HasColumnName("pcForgery");

//                entity.Property(e => e.PcHwsignForOther).HasColumnName("pcHWSignForOther");

//                entity.Property(e => e.PcIncomAddr).HasColumnName("pcIncomAddr");

//                entity.Property(e => e.PcIncomDeclCirc).HasColumnName("pcIncomDeclCirc");

//                entity.Property(e => e.PcInitials).HasColumnName("pcInitials");

//                entity.Property(e => e.PcNameTwiceNoSig).HasColumnName("pcNameTwiceNoSig");

//                entity.Property(e => e.PcOther).HasColumnName("pcOther");

//                entity.Property(e => e.PcPencilUsed).HasColumnName("pcPencilUsed");

//                entity.Property(e => e.PcPobox).HasColumnName("pcPOBox");

//                entity.Property(e => e.PcRubStampUsed).HasColumnName("pcRubStampUsed");

//                entity.Property(e => e.PcSigPrintedOrPrintIlleg).HasColumnName("pcSigPrintedOrPrintIlleg");

//                entity.Property(e => e.PcWhiteOut).HasColumnName("pcWhiteOut");

//                entity.Property(e => e.PcWomanSignMrsHusbandFname).HasColumnName("pcWomanSignMrsHusbandFname");
//            });

//            modelBuilder.Entity<Batches2007>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("Batches_2007");

//                entity.Property(e => e.BatchId)
//                    .ValueGeneratedOnAdd()
//                    .HasColumnName("BatchID");

//                entity.Property(e => e.DateAssgBatch)
//                    .HasColumnType("smalldatetime")
//                    .HasColumnName("dateAssgBatch");

//                entity.Property(e => e.DateReceivedBatch)
//                    .HasColumnType("smalldatetime")
//                    .HasColumnName("dateReceivedBatch");

//                entity.Property(e => e.DateSubmitted).HasColumnType("smalldatetime");

//                entity.Property(e => e.Enteredby)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("enteredby")
//                    .IsFixedLength(true);

//                entity.Property(e => e.KpmuserId).HasColumnName("KPMUserID");

//                entity.Property(e => e.KpmuserName)
//                    .HasMaxLength(30)
//                    .IsUnicode(false)
//                    .HasColumnName("KPMUserName");

//                entity.Property(e => e.PetitionId).HasColumnName("PetitionID");
//            });

//            modelBuilder.Entity<Batches2020>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("Batches_2020");

//                entity.Property(e => e.BatchId).HasColumnName("BatchID");

//                entity.Property(e => e.ChargeBackDate).HasColumnType("smalldatetime");

//                entity.Property(e => e.DateAssgBatch)
//                    .HasColumnType("smalldatetime")
//                    .HasColumnName("dateAssgBatch");

//                entity.Property(e => e.DateReceivedBatch)
//                    .HasColumnType("smalldatetime")
//                    .HasColumnName("dateReceivedBatch");

//                entity.Property(e => e.DateSubmitted).HasColumnType("smalldatetime");

//                entity.Property(e => e.Enteredby)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("enteredby")
//                    .IsFixedLength(true);

//                entity.Property(e => e.KpmuserId).HasColumnName("KPMUserID");

//                entity.Property(e => e.KpmuserName)
//                    .HasMaxLength(30)
//                    .IsUnicode(false)
//                    .HasColumnName("KPMUserName");

//                entity.Property(e => e.PetitionId).HasColumnName("PetitionID");

//                entity.Property(e => e.SigAmount).HasColumnType("money");
//            });

//            modelBuilder.Entity<City>(entity =>
//            {
//                entity.HasNoKey();

//                entity.Property(e => e.CityId).HasColumnName("CityID");

//                entity.Property(e => e.CityName)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<CityVoter>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("CityVoter");

//                entity.Property(e => e.DtBirthDate)
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("dtBirthDate");

//                entity.Property(e => e.DtLastUpdateDt)
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("dtLastUpdate_dt");

//                entity.Property(e => e.DtOrigRegDate)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("dtOrigRegDate");

//                entity.Property(e => e.DtRegDate)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("dtRegDate");

//                entity.Property(e => e.IDuplicateIdflag)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("iDuplicateIDFlag");

//                entity.Property(e => e.ISubDistrict0)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("iSubDistrict_0");

//                entity.Property(e => e.ISubDistrict1)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("iSubDistrict_1");

//                entity.Property(e => e.ISubDistrict2)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("iSubDistrict_2");

//                entity.Property(e => e.ISubDistrict3)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("iSubDistrict_3");

//                entity.Property(e => e.ISubDistrict4)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("iSubDistrict_4");

//                entity.Property(e => e.ISubDistrict5)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("iSubDistrict_5");

//                entity.Property(e => e.LVoterUniqueId)
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("lVoterUniqueID");

//                entity.Property(e => e.SAffNumber)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("sAffNumber");

//                entity.Property(e => e.SBirthPlace)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("sBirthPlace");

//                entity.Property(e => e.SDistrictId0)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("sDistrictID_0");

//                entity.Property(e => e.SDistrictId1)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("sDistrictID_1");

//                entity.Property(e => e.SDistrictId2)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("sDistrictID_2");

//                entity.Property(e => e.SDistrictId3)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("sDistrictID_3");

//                entity.Property(e => e.SDistrictId4)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("sDistrictID_4");

//                entity.Property(e => e.SDistrictId5)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("sDistrictID_5");

//                entity.Property(e => e.SGender)
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("sGender");

//                entity.Property(e => e.SHouseNum)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("sHouseNum");

//                entity.Property(e => e.SNameSuffix)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("sNameSuffix");

//                entity.Property(e => e.SPostDir)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("sPostDir");

//                entity.Property(e => e.SPreDir)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("sPreDir");

//                entity.Property(e => e.SPrecinctId)
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("sPrecinctID");

//                entity.Property(e => e.SPrecinctPortion)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("sPrecinctPortion");

//                entity.Property(e => e.SSitusState)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("sSitusState");

//                entity.Property(e => e.SSitusZip)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("sSitusZip");

//                entity.Property(e => e.SStatusCode)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("sStatusCode");

//                entity.Property(e => e.SStreetSuffix)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("sStreetSuffix");

//                entity.Property(e => e.SUnitAbbr)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("sUnitAbbr");

//                entity.Property(e => e.SUnitNum)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("sUnitNum");

//                entity.Property(e => e.SUserCode1)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("sUserCode1");

//                entity.Property(e => e.SUserCode2)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("sUserCode2");

//                entity.Property(e => e.SVoterTitle)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("sVoterTitle");

//                entity.Property(e => e.SzAvstatusAbbr)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("szAVStatusAbbr");

//                entity.Property(e => e.SzAvstatusDesc)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("szAVStatusDesc");

//                entity.Property(e => e.SzDistrictName0)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("szDistrictName_0");

//                entity.Property(e => e.SzDistrictName1)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("szDistrictName_1");

//                entity.Property(e => e.SzDistrictName2)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("szDistrictName_2");

//                entity.Property(e => e.SzDistrictName3)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("szDistrictName_3");

//                entity.Property(e => e.SzDistrictName4)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("szDistrictName_4");

//                entity.Property(e => e.SzDistrictName5)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("szDistrictName_5");

//                entity.Property(e => e.SzEmailAddress)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("szEmailAddress");

//                entity.Property(e => e.SzLanguageName)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("szLanguageName");

//                entity.Property(e => e.SzMailAddress1)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("szMailAddress1");

//                entity.Property(e => e.SzMailAddress2)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("szMailAddress2");

//                entity.Property(e => e.SzMailAddress3)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("szMailAddress3");

//                entity.Property(e => e.SzMailAddress4)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("szMailAddress4");

//                entity.Property(e => e.SzMailZip)
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("szMailZip");

//                entity.Property(e => e.SzNameFirst)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("szNameFirst");

//                entity.Property(e => e.SzNameLast)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("szNameLast");

//                entity.Property(e => e.SzNameMiddle)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("szNameMiddle");

//                entity.Property(e => e.SzPartyName)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("szPartyName");

//                entity.Property(e => e.SzPhone)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("szPhone");

//                entity.Property(e => e.SzPrecinctName)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("szPrecinctName");

//                entity.Property(e => e.SzSitusAddress)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("szSitusAddress");

//                entity.Property(e => e.SzSitusCity)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("szSitusCity");

//                entity.Property(e => e.SzStateVoterId)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("szStateVoterID");

//                entity.Property(e => e.SzStatusReasonDesc)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("szStatusReasonDesc");

//                entity.Property(e => e.SzStreetName)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("szStreetName");
//            });

//            modelBuilder.Entity<Cntybad>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("cntybad");

//                entity.Property(e => e.Badcount).HasColumnName("badcount");

//                entity.Property(e => e.County)
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("county");

//                entity.Property(e => e.Petitionid).HasColumnName("petitionid");
//            });

//            modelBuilder.Entity<Cntydup>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("cntydups");

//                entity.Property(e => e.County)
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("county");

//                entity.Property(e => e.Dupcount).HasColumnName("dupcount");

//                entity.Property(e => e.Petitionid).HasColumnName("petitionid");
//            });

//            modelBuilder.Entity<Cntygood>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("cntygood");

//                entity.Property(e => e.County)
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("county");

//                entity.Property(e => e.Petitionid).HasColumnName("petitionid");

//                entity.Property(e => e.Validcount).HasColumnName("validcount");
//            });

//            modelBuilder.Entity<Cntytotal>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("cntytotals");

//                entity.Property(e => e.County)
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("county");

//                entity.Property(e => e.Ttlbad)
//                    .HasColumnType("numeric(18, 0)")
//                    .HasColumnName("ttlbad");

//                entity.Property(e => e.Ttldup)
//                    .HasColumnType("numeric(18, 0)")
//                    .HasColumnName("ttldup");

//                entity.Property(e => e.Ttlpercent)
//                    .HasColumnType("numeric(5, 2)")
//                    .HasColumnName("ttlpercent");

//                entity.Property(e => e.Ttlvalid)
//                    .HasColumnType("numeric(18, 0)")
//                    .HasColumnName("ttlvalid");
//            });

//            modelBuilder.Entity<Combinedrecord>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("combinedrecords");

//                entity.Property(e => e.Badcount).HasColumnName("badcount");

//                entity.Property(e => e.County)
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("county");

//                entity.Property(e => e.Dateentered)
//                    .HasColumnType("datetime")
//                    .HasColumnName("dateentered");

//                entity.Property(e => e.Petitionid).HasColumnName("petitionid");

//                entity.Property(e => e.Validcount).HasColumnName("validcount");
//            });

//            modelBuilder.Entity<CoordBatchList>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("CoordBatchList");

//                entity.Property(e => e.Batchid).HasColumnName("batchid");

//                entity.Property(e => e.Circid)
//                    .HasMaxLength(7)
//                    .IsUnicode(false)
//                    .HasColumnName("circid");

//                entity.Property(e => e.Circinitsigs).HasColumnName("circinitsigs");

//                entity.Property(e => e.Coordassigned)
//                    .HasMaxLength(7)
//                    .IsUnicode(false)
//                    .HasColumnName("coordassigned");

//                entity.Property(e => e.FirstName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.Initsigs).HasColumnName("initsigs");

//                entity.Property(e => e.LastName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.Netcount).HasColumnName("netcount");

//                entity.Property(e => e.Purgecount).HasColumnName("purgecount");

//                entity.Property(e => e.Rawcount).HasColumnName("rawcount");
//            });

//            modelBuilder.Entity<CoordBatchListSubmitted>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("CoordBatchListSubmitted");

//                entity.Property(e => e.Batchid).HasColumnName("batchid");

//                entity.Property(e => e.Circid)
//                    .HasMaxLength(7)
//                    .IsUnicode(false)
//                    .HasColumnName("circid");

//                entity.Property(e => e.Circinitsigs).HasColumnName("circinitsigs");

//                entity.Property(e => e.Coordassigned)
//                    .HasMaxLength(7)
//                    .IsUnicode(false)
//                    .HasColumnName("coordassigned");

//                entity.Property(e => e.FirstName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.Initsigs).HasColumnName("initsigs");

//                entity.Property(e => e.LastName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.Netcount).HasColumnName("netcount");

//                entity.Property(e => e.Purgecount).HasColumnName("purgecount");

//                entity.Property(e => e.Rawcount).HasColumnName("rawcount");
//            });

//            modelBuilder.Entity<CoordBatchListSubmittedTemp>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("CoordBatchListSubmittedTemp");

//                entity.Property(e => e.Batchid).HasColumnName("batchid");

//                entity.Property(e => e.Coordassigned)
//                    .HasMaxLength(7)
//                    .IsUnicode(false)
//                    .HasColumnName("coordassigned");

//                entity.Property(e => e.Suminitsigs).HasColumnName("suminitsigs");
//            });

//            modelBuilder.Entity<CoordBatchListTemp>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("CoordBatchListTemp");

//                entity.Property(e => e.Batchid).HasColumnName("batchid");

//                entity.Property(e => e.Coordassigned)
//                    .HasMaxLength(7)
//                    .IsUnicode(false)
//                    .HasColumnName("coordassigned");

//                entity.Property(e => e.Suminitsigs).HasColumnName("suminitsigs");
//            });

//            modelBuilder.Entity<CoordDup>(entity =>
//            {
//                entity.HasNoKey();

//                entity.Property(e => e.BatchId).HasColumnName("batchID");

//                entity.Property(e => e.Batchentryid).HasColumnName("batchentryid");

//                entity.Property(e => e.Circid).HasColumnName("circid");

//                entity.Property(e => e.County)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("county")
//                    .IsFixedLength(true);

//                entity.Property(e => e.Dateentered)
//                    .HasColumnType("datetime")
//                    .HasColumnName("dateentered");

//                entity.Property(e => e.Enteredby)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("enteredby")
//                    .IsFixedLength(true);

//                entity.Property(e => e.PetitionId).HasColumnName("petitionID");

//                entity.Property(e => e.Recordid)
//                    .ValueGeneratedOnAdd()
//                    .HasColumnName("recordid");

//                entity.Property(e => e.VoterId).HasColumnName("voterID");
//            });

//            modelBuilder.Entity<CoordSummary>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("CoordSummary");

//                entity.Property(e => e.Circid)
//                    .HasMaxLength(7)
//                    .IsUnicode(false)
//                    .HasColumnName("circid");

//                entity.Property(e => e.Coordassigned)
//                    .HasMaxLength(7)
//                    .IsUnicode(false)
//                    .HasColumnName("coordassigned");

//                entity.Property(e => e.FirstName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.Initsigs).HasColumnName("initsigs");

//                entity.Property(e => e.LastName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.Netcount).HasColumnName("netcount");

//                entity.Property(e => e.Purgecount).HasColumnName("purgecount");

//                entity.Property(e => e.Rawcount).HasColumnName("rawcount");
//            });

//            modelBuilder.Entity<CoordUpdate>(entity =>
//            {
//                entity.HasNoKey();

//                entity.Property(e => e.Batchid).HasColumnName("batchid");

//                entity.Property(e => e.County)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("county")
//                    .IsFixedLength(true);

//                entity.Property(e => e.Dateentered)
//                    .HasColumnType("datetime")
//                    .HasColumnName("dateentered");

//                entity.Property(e => e.Enteredby)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("enteredby")
//                    .IsFixedLength(true);

//                entity.Property(e => e.PetitionId).HasColumnName("petitionID");

//                entity.Property(e => e.Voterid).HasColumnName("voterid");
//            });

//            modelBuilder.Entity<CoordUpdates2007>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("CoordUpdates_2007");

//                entity.Property(e => e.Batchid).HasColumnName("batchid");

//                entity.Property(e => e.County)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("county")
//                    .IsFixedLength(true);

//                entity.Property(e => e.Dateentered)
//                    .HasColumnType("datetime")
//                    .HasColumnName("dateentered");

//                entity.Property(e => e.Enteredby)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("enteredby")
//                    .IsFixedLength(true);

//                entity.Property(e => e.PetitionId).HasColumnName("petitionID");

//                entity.Property(e => e.Voterid).HasColumnName("voterid");
//            });

//            modelBuilder.Entity<Coordinator>(entity =>
//            {
//                entity.HasNoKey();

//                entity.Property(e => e.CoordinatorId).HasColumnName("coordinatorID");

//                entity.Property(e => e.Coordinatorname)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("coordinatorname")
//                    .IsFixedLength(true);

//                entity.Property(e => e.Dateentered)
//                    .HasColumnType("datetime")
//                    .HasColumnName("dateentered");

//                entity.Property(e => e.Enteredby)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("enteredby")
//                    .IsFixedLength(true);
//            });

//            modelBuilder.Entity<County>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("County");

//                entity.Property(e => e.CountyId).HasColumnName("countyID");

//                entity.Property(e => e.Countyname)
//                    .IsRequired()
//                    .HasMaxLength(30)
//                    .IsUnicode(false)
//                    .HasColumnName("countyname")
//                    .IsFixedLength(true);
//            });

//            modelBuilder.Entity<CountyTotalsView>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("CountyTotals_View");

//                entity.Property(e => e.County)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("county")
//                    .IsFixedLength(true);

//                entity.Property(e => e.Dateentered)
//                    .HasColumnType("datetime")
//                    .HasColumnName("dateentered");

//                entity.Property(e => e.Dupcounty)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("dupcounty")
//                    .IsFixedLength(true);

//                entity.Property(e => e.Dupdate)
//                    .HasColumnType("datetime")
//                    .HasColumnName("dupdate");

//                entity.Property(e => e.Dupvoterid).HasColumnName("dupvoterid");

//                entity.Property(e => e.Petid).HasColumnName("petid");

//                entity.Property(e => e.PetitionId).HasColumnName("petitionID");

//                entity.Property(e => e.Petitionname)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("petitionname")
//                    .IsFixedLength(true);

//                entity.Property(e => e.Voterid).HasColumnName("voterid");
//            });

//            modelBuilder.Entity<DailyReport>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("DailyReport");

//                entity.Property(e => e.Countdate)
//                    .HasColumnType("datetime")
//                    .HasColumnName("countdate");

//                entity.Property(e => e.County)
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("county")
//                    .IsFixedLength(true);

//                entity.Property(e => e.Petitionid).HasColumnName("petitionid");
//            });

//            modelBuilder.Entity<KpmCoordUpdate>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("kpm_CoordUpdates");

//                entity.Property(e => e.Batchid).HasColumnName("batchid");

//                entity.Property(e => e.County)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("county")
//                    .IsFixedLength(true);

//                entity.Property(e => e.Dateentered)
//                    .HasColumnType("datetime")
//                    .HasColumnName("dateentered");

//                entity.Property(e => e.Enteredby)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("enteredby")
//                    .IsFixedLength(true);

//                entity.Property(e => e.PetitionId).HasColumnName("petitionID");

//                entity.Property(e => e.Voterid).HasColumnName("voterid");
//            });

//            modelBuilder.Entity<KpmUser>(entity =>
//            {
//                entity.ToTable("KPM_Users");

//                entity.Property(e => e.KpmuserId).HasColumnName("KPMUserID");

//                entity.Property(e => e.Addr)
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.City)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.DateEntered).HasColumnType("smalldatetime");

//                entity.Property(e => e.DateModified).HasColumnType("smalldatetime");

//                entity.Property(e => e.DisplayName)
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.DnnUserId).HasColumnName("dnn_UserID");

//                entity.Property(e => e.DnnuserIdOld).HasColumnName("DNNUserID_old");

//                entity.Property(e => e.FirstName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.KpmuserType)
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("KPMUserType");

//                entity.Property(e => e.LastName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.State)
//                    .HasMaxLength(2)
//                    .IsUnicode(false);

//                entity.Property(e => e.Status)
//                    .HasMaxLength(8)
//                    .IsUnicode(false);

//                entity.Property(e => e.Telephone)
//                    .HasMaxLength(15)
//                    .IsUnicode(false);

//                entity.Property(e => e.Zip)
//                    .HasMaxLength(5)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<KpmUserTransferTable>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("KPM_User_TransferTable");

//                entity.Property(e => e.Transferid).HasColumnName("transferid");
//            });

//            modelBuilder.Entity<KpmUsers2009Blended>(entity =>
//            {
//                entity.HasKey(e => e.KpmuserId)
//                    .HasName("PK_KPM_Users");

//                entity.ToTable("KPM_Users2009Blended");

//                entity.Property(e => e.KpmuserId).HasColumnName("KPMUserID");

//                entity.Property(e => e.Addr)
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.City)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.DateEntered).HasColumnType("smalldatetime");

//                entity.Property(e => e.DateModified).HasColumnType("smalldatetime");

//                entity.Property(e => e.DisplayName)
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.DnnUserId).HasColumnName("dnn_UserID");

//                entity.Property(e => e.DnnuserIdOld).HasColumnName("DNNUserID_old");

//                entity.Property(e => e.FirstName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.KpmuserType)
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("KPMUserType");

//                entity.Property(e => e.LastName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.State)
//                    .HasMaxLength(2)
//                    .IsUnicode(false);

//                entity.Property(e => e.Status)
//                    .HasMaxLength(8)
//                    .IsUnicode(false);

//                entity.Property(e => e.Telephone)
//                    .HasMaxLength(15)
//                    .IsUnicode(false);

//                entity.Property(e => e.Zip)
//                    .HasMaxLength(5)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<KpmUsers2019Bck>(entity =>
//            {
//                entity.HasKey(e => e.KpmuserId)
//                    .HasName("PK_KPM_Users_2019_BCK_1");

//                entity.ToTable("KPM_Users_2019_BCK");

//                entity.Property(e => e.KpmuserId).HasColumnName("KPMUserID");

//                entity.Property(e => e.Addr)
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.City)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.DateEntered).HasColumnType("smalldatetime");

//                entity.Property(e => e.DateModified).HasColumnType("smalldatetime");

//                entity.Property(e => e.DisplayName)
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.DnnUserId).HasColumnName("dnn_UserID");

//                entity.Property(e => e.DnnuserIdOld).HasColumnName("DNNUserID_old");

//                entity.Property(e => e.FirstName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.KpmuserType)
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("KPMUserType");

//                entity.Property(e => e.LastName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.State)
//                    .HasMaxLength(2)
//                    .IsUnicode(false);

//                entity.Property(e => e.Status)
//                    .HasMaxLength(8)
//                    .IsUnicode(false);

//                entity.Property(e => e.Telephone)
//                    .HasMaxLength(15)
//                    .IsUnicode(false);

//                entity.Property(e => e.Zip)
//                    .HasMaxLength(5)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<KpmUsers2020>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("KPM_Users_2020");

//                entity.Property(e => e.Addr)
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.City)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.DateEntered).HasColumnType("smalldatetime");

//                entity.Property(e => e.DateModified).HasColumnType("smalldatetime");

//                entity.Property(e => e.DisplayName)
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.DnnUserId).HasColumnName("dnn_UserID");

//                entity.Property(e => e.DnnuserIdOld).HasColumnName("DNNUserID_old");

//                entity.Property(e => e.FirstName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.KpmuserId).HasColumnName("KPMUserID");

//                entity.Property(e => e.KpmuserType)
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("KPMUserType");

//                entity.Property(e => e.LastName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.State)
//                    .HasMaxLength(2)
//                    .IsUnicode(false);

//                entity.Property(e => e.Status)
//                    .HasMaxLength(8)
//                    .IsUnicode(false);

//                entity.Property(e => e.Telephone)
//                    .HasMaxLength(15)
//                    .IsUnicode(false);

//                entity.Property(e => e.Zip)
//                    .HasMaxLength(5)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<KpmUsersBck>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("KPM_Users_bck");

//                entity.Property(e => e.Addr)
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.City)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.DateEntered).HasColumnType("smalldatetime");

//                entity.Property(e => e.DateModified).HasColumnType("smalldatetime");

//                entity.Property(e => e.DisplayName)
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.DnnUserId).HasColumnName("dnn_UserID");

//                entity.Property(e => e.DnnuserIdOld).HasColumnName("DNNUserID_old");

//                entity.Property(e => e.FirstName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.KpmuserId).HasColumnName("KPMUserID");

//                entity.Property(e => e.KpmuserType)
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("KPMUserType");

//                entity.Property(e => e.LastName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.State)
//                    .HasMaxLength(2)
//                    .IsUnicode(false);

//                entity.Property(e => e.Status)
//                    .HasMaxLength(8)
//                    .IsUnicode(false);

//                entity.Property(e => e.Telephone)
//                    .HasMaxLength(15)
//                    .IsUnicode(false);

//                entity.Property(e => e.Zip)
//                    .HasMaxLength(5)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<KpmUsersEmpty>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("KPM_Users_Empty");

//                entity.Property(e => e.Addr)
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.City)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.DateEntered).HasColumnType("smalldatetime");

//                entity.Property(e => e.DateModified).HasColumnType("smalldatetime");

//                entity.Property(e => e.DisplayName)
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.DnnUserId).HasColumnName("dnn_UserID");

//                entity.Property(e => e.DnnuserIdOld).HasColumnName("DNNUserID_old");

//                entity.Property(e => e.FirstName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.KpmuserId).HasColumnName("KPMUserID");

//                entity.Property(e => e.KpmuserType)
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("KPMUserType");

//                entity.Property(e => e.LastName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.State)
//                    .HasMaxLength(2)
//                    .IsUnicode(false);

//                entity.Property(e => e.Status)
//                    .HasMaxLength(8)
//                    .IsUnicode(false);

//                entity.Property(e => e.Telephone)
//                    .HasMaxLength(15)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tempid)
//                    .ValueGeneratedOnAdd()
//                    .HasColumnName("tempid");

//                entity.Property(e => e.Zip)
//                    .HasMaxLength(5)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<KpmUsersSav>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("KPM_Users_Sav");

//                entity.Property(e => e.Addr)
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.City)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.DateEntered).HasColumnType("smalldatetime");

//                entity.Property(e => e.DateModified).HasColumnType("smalldatetime");

//                entity.Property(e => e.DisplayName)
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.DnnUserId).HasColumnName("dnn_UserID");

//                entity.Property(e => e.DnnuserIdOld).HasColumnName("DNNUserID_old");

//                entity.Property(e => e.FirstName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.KpmuserId).HasColumnName("KPMUserID");

//                entity.Property(e => e.KpmuserType)
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("KPMUserType");

//                entity.Property(e => e.LastName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.State)
//                    .HasMaxLength(2)
//                    .IsUnicode(false);

//                entity.Property(e => e.Status)
//                    .HasMaxLength(8)
//                    .IsUnicode(false);

//                entity.Property(e => e.Telephone)
//                    .HasMaxLength(15)
//                    .IsUnicode(false);

//                entity.Property(e => e.Zip)
//                    .HasMaxLength(5)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<KpmcircReport>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("KPMCircReport");

//                entity.Property(e => e.Batchid).HasColumnName("batchid");

//                entity.Property(e => e.Circid)
//                    .HasMaxLength(7)
//                    .IsUnicode(false)
//                    .HasColumnName("circid");

//                entity.Property(e => e.Circinitsigs).HasColumnName("circinitsigs");

//                entity.Property(e => e.Circrawcount).HasColumnName("circrawcount");

//                entity.Property(e => e.Coordassigned)
//                    .HasMaxLength(7)
//                    .IsUnicode(false)
//                    .HasColumnName("coordassigned");

//                entity.Property(e => e.Entryid).HasColumnName("entryid");

//                entity.Property(e => e.FirstName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.LastName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.PcAddrIllegOrCopy).HasColumnName("pcAddrIllegOrCopy");

//                entity.Property(e => e.PcDupSig).HasColumnName("pcDupSig");

//                entity.Property(e => e.PcForgery).HasColumnName("pcForgery");

//                entity.Property(e => e.PcHwsignForOther).HasColumnName("pcHWSignForOther");

//                entity.Property(e => e.PcIncomDeclCirc).HasColumnName("pcIncomDeclCirc");

//                entity.Property(e => e.PcInitials).HasColumnName("pcInitials");

//                entity.Property(e => e.PcNameTwiceNoSig).HasColumnName("pcNameTwiceNoSig");

//                entity.Property(e => e.PcOther).HasColumnName("pcOther");

//                entity.Property(e => e.PcPencilUsed).HasColumnName("pcPencilUsed");

//                entity.Property(e => e.PcRubStampUsed).HasColumnName("pcRubStampUsed");

//                entity.Property(e => e.PcSigPrintedOrPrintIlleg).HasColumnName("pcSigPrintedOrPrintIlleg");

//                entity.Property(e => e.PcWhiteOut).HasColumnName("pcWhiteOut");

//                entity.Property(e => e.PcWomanSignMrsHusbandFname).HasColumnName("pcWomanSignMrsHusbandFname");

//                entity.Property(e => e.PcdiffCounty).HasColumnName("PCDiffCounty");

//                entity.Property(e => e.Pcincomaddr).HasColumnName("pcincomaddr");

//                entity.Property(e => e.Pcpobox).HasColumnName("PCPOBox");

//                entity.Property(e => e.Petitionid).HasColumnName("petitionid");
//            });

//            modelBuilder.Entity<KpmcircReportSubmitted>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("KPMCircReportSubmitted");

//                entity.Property(e => e.Batchid).HasColumnName("batchid");

//                entity.Property(e => e.Circid)
//                    .HasMaxLength(7)
//                    .IsUnicode(false)
//                    .HasColumnName("circid");

//                entity.Property(e => e.Circinitsigs).HasColumnName("circinitsigs");

//                entity.Property(e => e.Circrawcount).HasColumnName("circrawcount");

//                entity.Property(e => e.Coordassigned)
//                    .HasMaxLength(7)
//                    .IsUnicode(false)
//                    .HasColumnName("coordassigned");

//                entity.Property(e => e.Entryid).HasColumnName("entryid");

//                entity.Property(e => e.FirstName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.LastName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.PcAddrIllegOrCopy).HasColumnName("pcAddrIllegOrCopy");

//                entity.Property(e => e.PcDupSig).HasColumnName("pcDupSig");

//                entity.Property(e => e.PcForgery).HasColumnName("pcForgery");

//                entity.Property(e => e.PcHwsignForOther).HasColumnName("pcHWSignForOther");

//                entity.Property(e => e.PcIncomDeclCirc).HasColumnName("pcIncomDeclCirc");

//                entity.Property(e => e.PcInitials).HasColumnName("pcInitials");

//                entity.Property(e => e.PcNameTwiceNoSig).HasColumnName("pcNameTwiceNoSig");

//                entity.Property(e => e.PcOther).HasColumnName("pcOther");

//                entity.Property(e => e.PcPencilUsed).HasColumnName("pcPencilUsed");

//                entity.Property(e => e.PcRubStampUsed).HasColumnName("pcRubStampUsed");

//                entity.Property(e => e.PcSigPrintedOrPrintIlleg).HasColumnName("pcSigPrintedOrPrintIlleg");

//                entity.Property(e => e.PcWhiteOut).HasColumnName("pcWhiteOut");

//                entity.Property(e => e.PcWomanSignMrsHusbandFname).HasColumnName("pcWomanSignMrsHusbandFname");

//                entity.Property(e => e.PcdiffCounty).HasColumnName("PCDiffCounty");

//                entity.Property(e => e.Pcincomaddr).HasColumnName("pcincomaddr");

//                entity.Property(e => e.Pcpobox).HasColumnName("PCPOBox");

//                entity.Property(e => e.Petitionid).HasColumnName("petitionid");
//            });

//            modelBuilder.Entity<Petition>(entity =>
//            {
//                entity.Property(e => e.PetitionId).HasColumnName("PetitionID");

//                entity.Property(e => e.DateEntered).HasColumnType("datetime");

//                entity.Property(e => e.DateReceived).HasColumnType("datetime");

//                entity.Property(e => e.EnteredBy)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .IsFixedLength(true);

//                entity.Property(e => e.Petitiondescription)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("petitiondescription")
//                    .IsFixedLength(true);

//                entity.Property(e => e.Petitionname)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("petitionname")
//                    .IsFixedLength(true);

//                entity.Property(e => e.StartDate).HasColumnType("date");

//                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
//            });

//            modelBuilder.Entity<PetitionSummary>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("PetitionSummary");

//                entity.Property(e => e.Batchid).HasColumnName("batchid");

//                entity.Property(e => e.Batchinitcount).HasColumnName("batchinitcount");

//                entity.Property(e => e.Batchpurgecount).HasColumnName("batchpurgecount");

//                entity.Property(e => e.Batchrawcount).HasColumnName("batchrawcount");

//                entity.Property(e => e.Petitionid).HasColumnName("petitionid");
//            });

//            modelBuilder.Entity<PetitionSummaryOld>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("PetitionSummary_old");

//                entity.Property(e => e.Batchid).HasColumnName("batchid");

//                entity.Property(e => e.Batchinitcount).HasColumnName("batchinitcount");

//                entity.Property(e => e.Batchpurgecount).HasColumnName("batchpurgecount");

//                entity.Property(e => e.Batchrawcount).HasColumnName("batchrawcount");

//                entity.Property(e => e.Petitionid).HasColumnName("petitionid");
//            });

//            modelBuilder.Entity<PetitionSummarySubmitted>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("PetitionSummarySubmitted");

//                entity.Property(e => e.Batchid).HasColumnName("batchid");

//                entity.Property(e => e.Batchnewreg)
//                    .HasColumnName("batchnewreg")
//                    .HasDefaultValueSql("((0))");

//                entity.Property(e => e.Batchpurgecount)
//                    .HasColumnName("batchpurgecount")
//                    .HasDefaultValueSql("((0))");

//                entity.Property(e => e.Batchrawcount)
//                    .HasColumnName("batchrawcount")
//                    .HasDefaultValueSql("((0))");

//                entity.Property(e => e.Batchsubmittedcount)
//                    .HasColumnName("batchsubmittedcount")
//                    .HasDefaultValueSql("((0))");

//                entity.Property(e => e.Petitionid).HasColumnName("petitionid");
//            });

//            modelBuilder.Entity<Petitions2007>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("Petitions_2007");

//                entity.Property(e => e.DateEntered).HasColumnType("datetime");

//                entity.Property(e => e.DateReceived).HasColumnType("datetime");

//                entity.Property(e => e.EnteredBy)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .IsFixedLength(true);

//                entity.Property(e => e.PetitionId)
//                    .ValueGeneratedOnAdd()
//                    .HasColumnName("PetitionID");

//                entity.Property(e => e.Petitiondescription)
//                    .IsRequired()
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("petitiondescription")
//                    .IsFixedLength(true);

//                entity.Property(e => e.Petitionname)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("petitionname")
//                    .IsFixedLength(true);
//            });

//            modelBuilder.Entity<Tempcount>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("tempcounts");

//                entity.Property(e => e.Badcount).HasColumnName("badcount");

//                entity.Property(e => e.County)
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("county");

//                entity.Property(e => e.Petitionname)
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("petitionname");

//                entity.Property(e => e.Votercount).HasColumnName("votercount");
//            });

//            modelBuilder.Entity<Temptable>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("temptable");

//                entity.Property(e => e.Coordinatorid)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("coordinatorid")
//                    .IsFixedLength(true);

//                entity.Property(e => e.PetitionId).HasColumnName("petitionID");
//            });

//            modelBuilder.Entity<Totalupdate>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("totalupdates");

//                entity.Property(e => e.County)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("county")
//                    .IsFixedLength(true);

//                entity.Property(e => e.Countydups).HasColumnName("countydups");

//                entity.Property(e => e.Petitionname)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("petitionname")
//                    .IsFixedLength(true);
//            });

//            modelBuilder.Entity<Validator>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("validator");

//                entity.Property(e => e.Dupcount).HasColumnName("dupcount");

//                entity.Property(e => e.Notfoundcount).HasColumnName("notfoundcount");

//                entity.Property(e => e.Validatorid).HasColumnName("validatorid");

//                entity.Property(e => e.Validatorname)
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("validatorname");

//                entity.Property(e => e.Validcount).HasColumnName("validcount");
//            });

//            modelBuilder.Entity<Validatorcount>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("validatorcount");

//                entity.Property(e => e.Badcount).HasColumnName("badcount");

//                entity.Property(e => e.Dupcount).HasColumnName("dupcount");

//                entity.Property(e => e.Fname)
//                    .HasMaxLength(15)
//                    .IsUnicode(false)
//                    .HasColumnName("fname");

//                entity.Property(e => e.Lname)
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("lname");

//                entity.Property(e => e.RoleId).HasColumnName("role_id");

//                entity.Property(e => e.Rolename)
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("rolename");

//                entity.Property(e => e.ValId)
//                    .HasMaxLength(4)
//                    .IsUnicode(false)
//                    .HasColumnName("val_id");

//                entity.Property(e => e.Validcount).HasColumnName("validcount");
//            });

//            modelBuilder.Entity<Validatortotal>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("validatortotals");

//                entity.Property(e => e.Fname)
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("fname");

//                entity.Property(e => e.Lname)
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("lname");

//                entity.Property(e => e.Petitionname)
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("petitionname");

//                entity.Property(e => e.Ttlbad)
//                    .HasColumnType("numeric(18, 0)")
//                    .HasColumnName("ttlbad");

//                entity.Property(e => e.Ttldup)
//                    .HasColumnType("numeric(18, 0)")
//                    .HasColumnName("ttldup");

//                entity.Property(e => e.Ttlgood)
//                    .HasColumnType("numeric(18, 0)")
//                    .HasColumnName("ttlgood");

//                entity.Property(e => e.Valid)
//                    .HasMaxLength(4)
//                    .IsUnicode(false)
//                    .HasColumnName("valid");
//            });

//            modelBuilder.Entity<Validatortotals3valid>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("validatortotals_3Valid");

//                entity.Property(e => e.Ttlbad)
//                    .HasColumnType("numeric(18, 0)")
//                    .HasColumnName("ttlbad");

//                entity.Property(e => e.Ttldup)
//                    .HasColumnType("numeric(18, 0)")
//                    .HasColumnName("ttldup");

//                entity.Property(e => e.Ttlgood)
//                    .HasColumnType("numeric(18, 0)")
//                    .HasColumnName("ttlgood");

//                entity.Property(e => e.Valid)
//                    .HasMaxLength(3)
//                    .IsUnicode(false)
//                    .HasColumnName("valid");
//            });

//            modelBuilder.Entity<ValidatortotalsOldnew>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("validatortotalsOldnew");

//                entity.Property(e => e.Ttlbad)
//                    .HasColumnType("numeric(18, 0)")
//                    .HasColumnName("ttlbad");

//                entity.Property(e => e.Ttldup)
//                    .HasColumnType("numeric(18, 0)")
//                    .HasColumnName("ttldup");

//                entity.Property(e => e.Ttlgood)
//                    .HasColumnType("numeric(18, 0)")
//                    .HasColumnName("ttlgood");

//                entity.Property(e => e.Valid)
//                    .HasMaxLength(3)
//                    .IsUnicode(false)
//                    .HasColumnName("valid");
//            });

//            modelBuilder.Entity<Validatortotalsall>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("validatortotalsall");

//                entity.Property(e => e.Petitionname)
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("petitionname");

//                entity.Property(e => e.Ttlbad)
//                    .HasColumnType("numeric(18, 0)")
//                    .HasColumnName("ttlbad");

//                entity.Property(e => e.Ttldup)
//                    .HasColumnType("numeric(18, 0)")
//                    .HasColumnName("ttldup");

//                entity.Property(e => e.Ttlgood)
//                    .HasColumnType("numeric(18, 0)")
//                    .HasColumnName("ttlgood");

//                entity.Property(e => e.Valid)
//                    .HasMaxLength(4)
//                    .IsUnicode(false)
//                    .HasColumnName("valid");
//            });

//            modelBuilder.Entity<Voter>(entity =>
//            {
//                entity.HasNoKey();

//                entity.Property(e => e.County)
//                    .HasMaxLength(30)
//                    .IsUnicode(false)
//                    .HasColumnName("county");

//                entity.Property(e => e.Ct)
//                    .HasMaxLength(30)
//                    .IsUnicode(false)
//                    .HasColumnName("ct");

//                entity.Property(e => e.Fn)
//                    .HasMaxLength(30)
//                    .IsUnicode(false)
//                    .HasColumnName("fn");

//                entity.Property(e => e.Ln)
//                    .HasMaxLength(30)
//                    .IsUnicode(false)
//                    .HasColumnName("ln");

//                entity.Property(e => e.Mi)
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("mi")
//                    .IsFixedLength(true);

//                entity.Property(e => e.Namesuffix)
//                    .HasMaxLength(3)
//                    .IsUnicode(false)
//                    .HasColumnName("namesuffix");

//                entity.Property(e => e.Resaddr)
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("resaddr");

//                entity.Property(e => e.Resstate)
//                    .HasMaxLength(2)
//                    .IsUnicode(false)
//                    .HasColumnName("resstate")
//                    .IsFixedLength(true);

//                entity.Property(e => e.Voterid)
//                    .ValueGeneratedOnAdd()
//                    .HasColumnName("voterid");

//                entity.Property(e => e.Zp)
//                    .HasMaxLength(5)
//                    .IsUnicode(false)
//                    .HasColumnName("zp")
//                    .IsFixedLength(true);
//            });

//            modelBuilder.Entity<VoterDup>(entity =>
//            {
//                entity.HasNoKey();

//                entity.Property(e => e.BatchId).HasColumnName("batchID");

//                entity.Property(e => e.Batchentryid).HasColumnName("batchentryid");

//                entity.Property(e => e.Circid).HasColumnName("circid");

//                entity.Property(e => e.County)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("county")
//                    .IsFixedLength(true);

//                entity.Property(e => e.Dateentered)
//                    .HasColumnType("datetime")
//                    .HasColumnName("dateentered");

//                entity.Property(e => e.Enteredby)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("enteredby")
//                    .IsFixedLength(true);

//                entity.Property(e => e.PetitionId).HasColumnName("petitionID");

//                entity.Property(e => e.Recordid)
//                    .ValueGeneratedOnAdd()
//                    .HasColumnName("recordid");

//                entity.Property(e => e.VoterId).HasColumnName("voterID");
//            });

//            modelBuilder.Entity<VoterDupView>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("VoterDupView");

//                entity.Property(e => e.County)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("county")
//                    .IsFixedLength(true);

//                entity.Property(e => e.Countycount).HasColumnName("countycount");

//                entity.Property(e => e.Petitionname)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("petitionname")
//                    .IsFixedLength(true);
//            });

//            modelBuilder.Entity<VoterDups2007>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("VoterDups_2007");

//                entity.Property(e => e.BatchId).HasColumnName("batchID");

//                entity.Property(e => e.Batchentryid).HasColumnName("batchentryid");

//                entity.Property(e => e.Circid).HasColumnName("circid");

//                entity.Property(e => e.County)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("county")
//                    .IsFixedLength(true);

//                entity.Property(e => e.Dateentered)
//                    .HasColumnType("datetime")
//                    .HasColumnName("dateentered");

//                entity.Property(e => e.Enteredby)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("enteredby")
//                    .IsFixedLength(true);

//                entity.Property(e => e.PetitionId).HasColumnName("petitionID");

//                entity.Property(e => e.Recordid)
//                    .ValueGeneratedOnAdd()
//                    .HasColumnName("recordid");

//                entity.Property(e => e.VoterId).HasColumnName("voterID");
//            });

//            modelBuilder.Entity<VoterDups2020>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("VoterDups_2020");

//                entity.Property(e => e.BatchId).HasColumnName("batchID");

//                entity.Property(e => e.Batchentryid).HasColumnName("batchentryid");

//                entity.Property(e => e.Circid).HasColumnName("circid");

//                entity.Property(e => e.County)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("county")
//                    .IsFixedLength(true);

//                entity.Property(e => e.Dateentered)
//                    .HasColumnType("datetime")
//                    .HasColumnName("dateentered");

//                entity.Property(e => e.Enteredby)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("enteredby")
//                    .IsFixedLength(true);

//                entity.Property(e => e.PetitionId).HasColumnName("petitionID");

//                entity.Property(e => e.Recordid).HasColumnName("recordid");

//                entity.Property(e => e.VoterId).HasColumnName("voterID");
//            });

//            modelBuilder.Entity<VoterDupsback>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("VoterDupsback");

//                entity.Property(e => e.BatchId).HasColumnName("batchID");

//                entity.Property(e => e.Batchentryid).HasColumnName("batchentryid");

//                entity.Property(e => e.Circid).HasColumnName("circid");

//                entity.Property(e => e.County)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("county")
//                    .IsFixedLength(true);

//                entity.Property(e => e.Dateentered)
//                    .HasColumnType("datetime")
//                    .HasColumnName("dateentered");

//                entity.Property(e => e.Enteredby)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("enteredby")
//                    .IsFixedLength(true);

//                entity.Property(e => e.PetitionId).HasColumnName("petitionID");

//                entity.Property(e => e.Recordid).HasColumnName("recordid");

//                entity.Property(e => e.VoterId).HasColumnName("voterID");
//            });

//            modelBuilder.Entity<VoterRecord>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("VoterRecord");

//                entity.Property(e => e.Batchentryid).HasColumnName("batchentryid");

//                entity.Property(e => e.Batchid).HasColumnName("batchid");

//                entity.Property(e => e.Circid).HasColumnName("circid");

//                entity.Property(e => e.County)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("county")
//                    .IsFixedLength(true);

//                entity.Property(e => e.Dateentered)
//                    .HasColumnType("datetime")
//                    .HasColumnName("dateentered");

//                entity.Property(e => e.Enteredby)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("enteredby")
//                    .IsFixedLength(true);

//                entity.Property(e => e.PetitionId).HasColumnName("petitionID");

//                entity.Property(e => e.Voterid).HasColumnName("voterid");
//            });

//            modelBuilder.Entity<VoterRecord2007>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("VoterRecord_2007");

//                entity.Property(e => e.Batchentryid).HasColumnName("batchentryid");

//                entity.Property(e => e.Batchid).HasColumnName("batchid");

//                entity.Property(e => e.Circid).HasColumnName("circid");

//                entity.Property(e => e.County)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("county")
//                    .IsFixedLength(true);

//                entity.Property(e => e.Dateentered)
//                    .HasColumnType("datetime")
//                    .HasColumnName("dateentered");

//                entity.Property(e => e.Enteredby)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("enteredby")
//                    .IsFixedLength(true);

//                entity.Property(e => e.PetitionId).HasColumnName("petitionID");

//                entity.Property(e => e.Voterid).HasColumnName("voterid");
//            });

//            modelBuilder.Entity<VoterRecord2020>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("VoterRecord_2020");

//                entity.Property(e => e.Batchentryid).HasColumnName("batchentryid");

//                entity.Property(e => e.Batchid).HasColumnName("batchid");

//                entity.Property(e => e.Circid).HasColumnName("circid");

//                entity.Property(e => e.County)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("county")
//                    .IsFixedLength(true);

//                entity.Property(e => e.Dateentered)
//                    .HasColumnType("datetime")
//                    .HasColumnName("dateentered");

//                entity.Property(e => e.Enteredby)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("enteredby")
//                    .IsFixedLength(true);

//                entity.Property(e => e.PetitionId).HasColumnName("petitionID");

//                entity.Property(e => e.Voterid).HasColumnName("voterid");
//            });

//            modelBuilder.Entity<VoterRecordView>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("VoterRecordView");

//                entity.Property(e => e.County)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("county")
//                    .IsFixedLength(true);

//                entity.Property(e => e.Countycount).HasColumnName("countycount");

//                entity.Property(e => e.Petitionname)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("petitionname")
//                    .IsFixedLength(true);
//            });

//            modelBuilder.Entity<VwBadDetailByEntryId>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("vw_BadDetailByEntryID");

//                entity.Property(e => e.BatchId).HasColumnName("BatchID");

//                entity.Property(e => e.Circfullname)
//                    .HasMaxLength(30)
//                    .IsUnicode(false)
//                    .HasColumnName("circfullname");

//                entity.Property(e => e.Ct)
//                    .HasMaxLength(30)
//                    .IsUnicode(false)
//                    .HasColumnName("ct");

//                entity.Property(e => e.Entryid).HasColumnName("entryid");

//                entity.Property(e => e.Fn)
//                    .HasMaxLength(30)
//                    .IsUnicode(false)
//                    .HasColumnName("fn");

//                entity.Property(e => e.Ln)
//                    .HasMaxLength(30)
//                    .IsUnicode(false)
//                    .HasColumnName("ln");

//                entity.Property(e => e.Mi)
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("mi")
//                    .IsFixedLength(true);

//                entity.Property(e => e.PetitionId).HasColumnName("petitionID");

//                entity.Property(e => e.Resaddr)
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("resaddr");

//                entity.Property(e => e.Resstate)
//                    .HasMaxLength(2)
//                    .IsUnicode(false)
//                    .HasColumnName("resstate")
//                    .IsFixedLength(true);

//                entity.Property(e => e.Zp)
//                    .HasMaxLength(5)
//                    .IsUnicode(false)
//                    .HasColumnName("zp")
//                    .IsFixedLength(true);
//            });

//            modelBuilder.Entity<VwBatchesNotReceived>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("vw_BatchesNot Received");

//                entity.Property(e => e.BatchId).HasColumnName("BatchID");

//                entity.Property(e => e.DateReceived)
//                    .HasColumnType("smalldatetime")
//                    .HasColumnName("Date Received");

//                entity.Property(e => e.DateSubmitted)
//                    .HasColumnType("smalldatetime")
//                    .HasColumnName("Date Submitted");

//                entity.Property(e => e.DnnUserId).HasColumnName("dnn_UserID");

//                entity.Property(e => e.Petitionname)
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("petitionname")
//                    .IsFixedLength(true);
//            });

//            modelBuilder.Entity<VwGoodDetailByEntryId>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("vw_GoodDetailByEntryID");

//                entity.Property(e => e.BatchId).HasColumnName("BatchID");

//                entity.Property(e => e.Circfullname)
//                    .HasMaxLength(30)
//                    .IsUnicode(false)
//                    .HasColumnName("circfullname");

//                entity.Property(e => e.Ct)
//                    .HasMaxLength(30)
//                    .IsUnicode(false)
//                    .HasColumnName("ct");

//                entity.Property(e => e.Entryid).HasColumnName("entryid");

//                entity.Property(e => e.Fn)
//                    .HasMaxLength(30)
//                    .IsUnicode(false)
//                    .HasColumnName("fn");

//                entity.Property(e => e.Ln)
//                    .HasMaxLength(30)
//                    .IsUnicode(false)
//                    .HasColumnName("ln");

//                entity.Property(e => e.Mi)
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("mi")
//                    .IsFixedLength(true);

//                entity.Property(e => e.PetitionId).HasColumnName("petitionID");

//                entity.Property(e => e.Resaddr)
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .HasColumnName("resaddr");

//                entity.Property(e => e.Resstate)
//                    .HasMaxLength(2)
//                    .IsUnicode(false)
//                    .HasColumnName("resstate")
//                    .IsFixedLength(true);

//                entity.Property(e => e.Zp)
//                    .HasMaxLength(5)
//                    .IsUnicode(false)
//                    .HasColumnName("zp")
//                    .IsFixedLength(true);
//            });

//            modelBuilder.Entity<VwVoterDupsWpetitionName>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("vw_VoterDupsWPetitionName");

//                entity.Property(e => e.BatchId).HasColumnName("batchID");

//                entity.Property(e => e.Batchentryid).HasColumnName("batchentryid");

//                entity.Property(e => e.Circid).HasColumnName("circid");

//                entity.Property(e => e.County)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("county")
//                    .IsFixedLength(true);

//                entity.Property(e => e.Dateentered)
//                    .HasColumnType("datetime")
//                    .HasColumnName("dateentered");

//                entity.Property(e => e.Enteredby)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("enteredby")
//                    .IsFixedLength(true);

//                entity.Property(e => e.PetitionId).HasColumnName("petitionID");

//                entity.Property(e => e.Petitionname)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("petitionname")
//                    .IsFixedLength(true);

//                entity.Property(e => e.Recordid).HasColumnName("recordid");

//                entity.Property(e => e.VoterId).HasColumnName("voterID");
//            });

//            modelBuilder.Entity<VwVoterRecordWpetitionName>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("vw_VoterRecordWPetitionName");

//                entity.Property(e => e.Batchentryid).HasColumnName("batchentryid");

//                entity.Property(e => e.Batchid).HasColumnName("batchid");

//                entity.Property(e => e.Circid).HasColumnName("circid");

//                entity.Property(e => e.County)
//                    .IsRequired()
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .HasColumnName("county")
//                    .IsFixedLength(true);

//                entity.Property(e => e.Dateentered)
//                    .HasColumnType("datetime")
//                    .HasColumnName("dateentered");

//                entity.Property(e => e.Enteredby)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("enteredby")
//                    .IsFixedLength(true);

//                entity.Property(e => e.PetitionId).HasColumnName("petitionID");

//                entity.Property(e => e.Petitionname)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .IsUnicode(false)
//                    .HasColumnName("petitionname")
//                    .IsFixedLength(true);

//                entity.Property(e => e.Voterid).HasColumnName("voterid");
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
//}
