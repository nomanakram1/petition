using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace petition.Migrations
{
    public partial class addbatchTblPK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Authorize = table.Column<bool>(type: "bit", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BatchDetail2007s",
                columns: table => new
                {
                    BatchId = table.Column<int>(type: "int", nullable: false),
                    Circid = table.Column<int>(type: "int", nullable: false),
                    Circfullname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Circinitsigs = table.Column<int>(type: "int", nullable: false),
                    Entryid = table.Column<int>(type: "int", nullable: false),
                    Circrawcount = table.Column<int>(type: "int", nullable: true),
                    PcInitials = table.Column<int>(type: "int", nullable: true),
                    PcPobox = table.Column<int>(type: "int", nullable: true),
                    PcDiffCounty = table.Column<int>(type: "int", nullable: true),
                    PcIncomAddr = table.Column<int>(type: "int", nullable: true),
                    PcAddrIllegOrCopy = table.Column<int>(type: "int", nullable: true),
                    PcSigPrintedOrPrintIlleg = table.Column<int>(type: "int", nullable: true),
                    PcNameTwiceNoSig = table.Column<int>(type: "int", nullable: true),
                    PcHwsignForOther = table.Column<int>(type: "int", nullable: true),
                    PcWomanSignMrsHusbandFname = table.Column<int>(type: "int", nullable: true),
                    PcForgery = table.Column<int>(type: "int", nullable: true),
                    PcIncomDeclCirc = table.Column<int>(type: "int", nullable: true),
                    PcRubStampUsed = table.Column<int>(type: "int", nullable: true),
                    PcPencilUsed = table.Column<int>(type: "int", nullable: true),
                    PcDupSig = table.Column<int>(type: "int", nullable: true),
                    PcWhiteOut = table.Column<int>(type: "int", nullable: true),
                    PcOther = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BatchDetail2020s",
                columns: table => new
                {
                    BatchId = table.Column<int>(type: "int", nullable: false),
                    Circid = table.Column<int>(type: "int", nullable: false),
                    Circfullname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Circinitsigs = table.Column<int>(type: "int", nullable: false),
                    Entryid = table.Column<int>(type: "int", nullable: false),
                    Circrawcount = table.Column<int>(type: "int", nullable: true),
                    PcInitials = table.Column<int>(type: "int", nullable: true),
                    PcPobox = table.Column<int>(type: "int", nullable: true),
                    PcDiffCounty = table.Column<int>(type: "int", nullable: true),
                    PcIncomAddr = table.Column<int>(type: "int", nullable: true),
                    PcAddrIllegOrCopy = table.Column<int>(type: "int", nullable: true),
                    PcSigPrintedOrPrintIlleg = table.Column<int>(type: "int", nullable: true),
                    PcNameTwiceNoSig = table.Column<int>(type: "int", nullable: true),
                    PcHwsignForOther = table.Column<int>(type: "int", nullable: true),
                    PcWomanSignMrsHusbandFname = table.Column<int>(type: "int", nullable: true),
                    PcForgery = table.Column<int>(type: "int", nullable: true),
                    PcIncomDeclCirc = table.Column<int>(type: "int", nullable: true),
                    PcRubStampUsed = table.Column<int>(type: "int", nullable: true),
                    PcPencilUsed = table.Column<int>(type: "int", nullable: true),
                    PcDupSig = table.Column<int>(type: "int", nullable: true),
                    PcWhiteOut = table.Column<int>(type: "int", nullable: true),
                    PcOther = table.Column<int>(type: "int", nullable: true),
                    BatchStatus = table.Column<int>(type: "int", nullable: false),
                    CircNewReg = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BatchDetails",
                columns: table => new
                {
                    BatchId = table.Column<int>(type: "int", nullable: false),
                    Circid = table.Column<int>(type: "int", nullable: false),
                    Circfullname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Circinitsigs = table.Column<int>(type: "int", nullable: false),
                    Entryid = table.Column<int>(type: "int", nullable: false),
                    Circrawcount = table.Column<int>(type: "int", nullable: true),
                    PcInitials = table.Column<int>(type: "int", nullable: true),
                    PcPobox = table.Column<int>(type: "int", nullable: true),
                    PcDiffCounty = table.Column<int>(type: "int", nullable: true),
                    PcIncomAddr = table.Column<int>(type: "int", nullable: true),
                    PcAddrIllegOrCopy = table.Column<int>(type: "int", nullable: true),
                    PcSigPrintedOrPrintIlleg = table.Column<int>(type: "int", nullable: true),
                    PcNameTwiceNoSig = table.Column<int>(type: "int", nullable: true),
                    PcHwsignForOther = table.Column<int>(type: "int", nullable: true),
                    PcWomanSignMrsHusbandFname = table.Column<int>(type: "int", nullable: true),
                    PcForgery = table.Column<int>(type: "int", nullable: true),
                    PcIncomDeclCirc = table.Column<int>(type: "int", nullable: true),
                    PcRubStampUsed = table.Column<int>(type: "int", nullable: true),
                    PcPencilUsed = table.Column<int>(type: "int", nullable: true),
                    PcDupSig = table.Column<int>(type: "int", nullable: true),
                    PcWhiteOut = table.Column<int>(type: "int", nullable: true),
                    PcOther = table.Column<int>(type: "int", nullable: true),
                    BatchStatus = table.Column<int>(type: "int", nullable: false),
                    CircNewReg = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Batches",
                columns: table => new
                {
                    BatchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateAssgBatch = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KpmuserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KpmuserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PetitionId = table.Column<int>(type: "int", nullable: false),
                    DateReceivedBatch = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SigValue = table.Column<short>(type: "smallint", nullable: true),
                    Enteredby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InitialCount = table.Column<int>(type: "int", nullable: true),
                    RawCount = table.Column<int>(type: "int", nullable: true),
                    PurgedCount = table.Column<int>(type: "int", nullable: true),
                    DateSubmitted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SubmittedCount = table.Column<int>(type: "int", nullable: true),
                    RawComplete = table.Column<bool>(type: "bit", nullable: false),
                    ProcessingComplete = table.Column<bool>(type: "bit", nullable: false),
                    ValidationComplete = table.Column<bool>(type: "bit", nullable: false),
                    ChargeBackDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChargeBackCount = table.Column<int>(type: "int", nullable: false),
                    SigAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batches", x => x.BatchId);
                });

            migrationBuilder.CreateTable(
                name: "Batches2007s",
                columns: table => new
                {
                    DateAssgBatch = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BatchId = table.Column<int>(type: "int", nullable: false),
                    KpmuserId = table.Column<int>(type: "int", nullable: false),
                    KpmuserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PetitionId = table.Column<int>(type: "int", nullable: false),
                    DateReceivedBatch = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SigValue = table.Column<short>(type: "smallint", nullable: true),
                    Enteredby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InitialCount = table.Column<int>(type: "int", nullable: true),
                    RawCount = table.Column<int>(type: "int", nullable: true),
                    PurgedCount = table.Column<int>(type: "int", nullable: true),
                    DateSubmitted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SubmittedCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Batches2020s",
                columns: table => new
                {
                    DateAssgBatch = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BatchId = table.Column<int>(type: "int", nullable: false),
                    KpmuserId = table.Column<int>(type: "int", nullable: false),
                    KpmuserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PetitionId = table.Column<int>(type: "int", nullable: false),
                    DateReceivedBatch = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SigValue = table.Column<short>(type: "smallint", nullable: true),
                    Enteredby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InitialCount = table.Column<int>(type: "int", nullable: true),
                    RawCount = table.Column<int>(type: "int", nullable: true),
                    PurgedCount = table.Column<int>(type: "int", nullable: true),
                    DateSubmitted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SubmittedCount = table.Column<int>(type: "int", nullable: true),
                    RawComplete = table.Column<bool>(type: "bit", nullable: false),
                    ProcessingComplete = table.Column<bool>(type: "bit", nullable: false),
                    ValidationComplete = table.Column<bool>(type: "bit", nullable: false),
                    ChargeBackDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChargeBackCount = table.Column<int>(type: "int", nullable: false),
                    SigAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CityVoters",
                columns: table => new
                {
                    LVoterUniqueId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SAffNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SzStateVoterId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SVoterTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SzNameLast = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SzNameFirst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SzNameMiddle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SNameSuffix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SzSitusAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SzSitusCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SSitusState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SSitusZip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SHouseNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUnitAbbr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUnitNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SzStreetName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SStreetSuffix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SPreDir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SPostDir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SzMailAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SzMailAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SzMailAddress3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SzMailAddress4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SzMailZip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SzPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SzEmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DtBirthDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SBirthPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DtRegDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DtOrigRegDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DtLastUpdateDt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SzStatusReasonDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUserCode1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUserCode2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDuplicateIdflag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SzLanguageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SzPartyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SzAvstatusAbbr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SzAvstatusDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SzPrecinctName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SPrecinctId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SPrecinctPortion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDistrictId0 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISubDistrict0 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SzDistrictName0 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDistrictId1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISubDistrict1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SzDistrictName1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDistrictId2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISubDistrict2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SzDistrictName2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDistrictId3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISubDistrict3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SzDistrictName3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDistrictId4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISubDistrict4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SzDistrictName4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDistrictId5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISubDistrict5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SzDistrictName5 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Cntybads",
                columns: table => new
                {
                    Petitionid = table.Column<int>(type: "int", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Badcount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Cntydups",
                columns: table => new
                {
                    Petitionid = table.Column<int>(type: "int", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dupcount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Cntygoods",
                columns: table => new
                {
                    Petitionid = table.Column<int>(type: "int", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Validcount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Cntytotals",
                columns: table => new
                {
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ttlvalid = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Ttlbad = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Ttldup = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Ttlpercent = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Combinedrecords",
                columns: table => new
                {
                    Petitionid = table.Column<int>(type: "int", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dateentered = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Validcount = table.Column<int>(type: "int", nullable: true),
                    Badcount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CoordBatchLists",
                columns: table => new
                {
                    Circid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coordassigned = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Batchid = table.Column<int>(type: "int", nullable: true),
                    Initsigs = table.Column<int>(type: "int", nullable: true),
                    Circinitsigs = table.Column<int>(type: "int", nullable: true),
                    Rawcount = table.Column<int>(type: "int", nullable: true),
                    Purgecount = table.Column<int>(type: "int", nullable: true),
                    Netcount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CoordBatchListSubmitteds",
                columns: table => new
                {
                    Circid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coordassigned = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Batchid = table.Column<int>(type: "int", nullable: true),
                    Initsigs = table.Column<int>(type: "int", nullable: true),
                    Circinitsigs = table.Column<int>(type: "int", nullable: true),
                    Rawcount = table.Column<int>(type: "int", nullable: true),
                    Purgecount = table.Column<int>(type: "int", nullable: true),
                    Netcount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CoordBatchListSubmittedTemps",
                columns: table => new
                {
                    Batchid = table.Column<int>(type: "int", nullable: true),
                    Suminitsigs = table.Column<int>(type: "int", nullable: true),
                    Coordassigned = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CoordBatchListTemps",
                columns: table => new
                {
                    Batchid = table.Column<int>(type: "int", nullable: true),
                    Suminitsigs = table.Column<int>(type: "int", nullable: true),
                    Coordassigned = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CoordDups",
                columns: table => new
                {
                    PetitionId = table.Column<int>(type: "int", nullable: false),
                    BatchId = table.Column<int>(type: "int", nullable: false),
                    Dateentered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VoterId = table.Column<int>(type: "int", nullable: false),
                    Enteredby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recordid = table.Column<int>(type: "int", nullable: false),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Circid = table.Column<int>(type: "int", nullable: false),
                    Batchentryid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Coordinators",
                columns: table => new
                {
                    Coordinatorname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoordinatorId = table.Column<int>(type: "int", nullable: false),
                    Enteredby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dateentered = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CoordSummaries",
                columns: table => new
                {
                    Circid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coordassigned = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Initsigs = table.Column<int>(type: "int", nullable: true),
                    Rawcount = table.Column<int>(type: "int", nullable: true),
                    Purgecount = table.Column<int>(type: "int", nullable: true),
                    Netcount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CoordUpdates",
                columns: table => new
                {
                    Dateentered = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PetitionId = table.Column<int>(type: "int", nullable: false),
                    Batchid = table.Column<int>(type: "int", nullable: false),
                    Voterid = table.Column<int>(type: "int", nullable: false),
                    Enteredby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CoordUpdates2007s",
                columns: table => new
                {
                    Dateentered = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PetitionId = table.Column<int>(type: "int", nullable: false),
                    Batchid = table.Column<int>(type: "int", nullable: false),
                    Voterid = table.Column<int>(type: "int", nullable: false),
                    Enteredby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Counties",
                columns: table => new
                {
                    Countyname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CountyTotalsViews",
                columns: table => new
                {
                    Petitionname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Petid = table.Column<int>(type: "int", nullable: false),
                    Dupdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dupvoterid = table.Column<int>(type: "int", nullable: false),
                    Dupcounty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dateentered = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PetitionId = table.Column<int>(type: "int", nullable: false),
                    Voterid = table.Column<int>(type: "int", nullable: false),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DailyReports",
                columns: table => new
                {
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Countdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Petitionid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "GetPetetion",
                columns: table => new
                {
                    Petitiondescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Petitionname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PetitionId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    CityPetition = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "KpmcircReports",
                columns: table => new
                {
                    Circid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coordassigned = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Petitionid = table.Column<int>(type: "int", nullable: true),
                    Entryid = table.Column<int>(type: "int", nullable: true),
                    Batchid = table.Column<int>(type: "int", nullable: true),
                    Circinitsigs = table.Column<int>(type: "int", nullable: true),
                    Circrawcount = table.Column<int>(type: "int", nullable: true),
                    PcInitials = table.Column<int>(type: "int", nullable: true),
                    Pcpobox = table.Column<int>(type: "int", nullable: true),
                    PcdiffCounty = table.Column<int>(type: "int", nullable: true),
                    Pcincomaddr = table.Column<int>(type: "int", nullable: true),
                    PcAddrIllegOrCopy = table.Column<int>(type: "int", nullable: true),
                    PcSigPrintedOrPrintIlleg = table.Column<int>(type: "int", nullable: true),
                    PcNameTwiceNoSig = table.Column<int>(type: "int", nullable: true),
                    PcHwsignForOther = table.Column<int>(type: "int", nullable: true),
                    PcWomanSignMrsHusbandFname = table.Column<int>(type: "int", nullable: true),
                    PcForgery = table.Column<int>(type: "int", nullable: true),
                    PcIncomDeclCirc = table.Column<int>(type: "int", nullable: true),
                    PcRubStampUsed = table.Column<int>(type: "int", nullable: true),
                    PcPencilUsed = table.Column<int>(type: "int", nullable: true),
                    PcDupSig = table.Column<int>(type: "int", nullable: true),
                    PcWhiteOut = table.Column<int>(type: "int", nullable: true),
                    PcOther = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "KpmcircReportSubmitteds",
                columns: table => new
                {
                    Circid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coordassigned = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Petitionid = table.Column<int>(type: "int", nullable: true),
                    Entryid = table.Column<int>(type: "int", nullable: true),
                    Batchid = table.Column<int>(type: "int", nullable: true),
                    Circinitsigs = table.Column<int>(type: "int", nullable: true),
                    Circrawcount = table.Column<int>(type: "int", nullable: true),
                    PcInitials = table.Column<int>(type: "int", nullable: true),
                    Pcpobox = table.Column<int>(type: "int", nullable: true),
                    PcdiffCounty = table.Column<int>(type: "int", nullable: true),
                    Pcincomaddr = table.Column<int>(type: "int", nullable: true),
                    PcAddrIllegOrCopy = table.Column<int>(type: "int", nullable: true),
                    PcSigPrintedOrPrintIlleg = table.Column<int>(type: "int", nullable: true),
                    PcNameTwiceNoSig = table.Column<int>(type: "int", nullable: true),
                    PcHwsignForOther = table.Column<int>(type: "int", nullable: true),
                    PcWomanSignMrsHusbandFname = table.Column<int>(type: "int", nullable: true),
                    PcForgery = table.Column<int>(type: "int", nullable: true),
                    PcIncomDeclCirc = table.Column<int>(type: "int", nullable: true),
                    PcRubStampUsed = table.Column<int>(type: "int", nullable: true),
                    PcPencilUsed = table.Column<int>(type: "int", nullable: true),
                    PcDupSig = table.Column<int>(type: "int", nullable: true),
                    PcWhiteOut = table.Column<int>(type: "int", nullable: true),
                    PcOther = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "KpmCoordUpdates",
                columns: table => new
                {
                    Dateentered = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PetitionId = table.Column<int>(type: "int", nullable: false),
                    Batchid = table.Column<int>(type: "int", nullable: false),
                    Voterid = table.Column<int>(type: "int", nullable: false),
                    Enteredby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "KpmUsers",
                columns: table => new
                {
                    KpmuserId = table.Column<int>(type: "int", nullable: false),
                    KpmuserType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enteredby = table.Column<int>(type: "int", nullable: false),
                    DateEntered = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DnnUserId = table.Column<int>(type: "int", nullable: true),
                    CoordAssigned = table.Column<int>(type: "int", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Addr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DnnuserIdOld = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "KpmUsers2009Blendeds",
                columns: table => new
                {
                    KpmuserId = table.Column<int>(type: "int", nullable: false),
                    KpmuserType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enteredby = table.Column<int>(type: "int", nullable: false),
                    DateEntered = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DnnUserId = table.Column<int>(type: "int", nullable: true),
                    CoordAssigned = table.Column<int>(type: "int", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Addr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DnnuserIdOld = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "KpmUsers2019Bcks",
                columns: table => new
                {
                    KpmuserId = table.Column<int>(type: "int", nullable: false),
                    KpmuserType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enteredby = table.Column<int>(type: "int", nullable: false),
                    DateEntered = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DnnUserId = table.Column<int>(type: "int", nullable: true),
                    CoordAssigned = table.Column<int>(type: "int", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Addr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DnnuserIdOld = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "KpmUsers2020s",
                columns: table => new
                {
                    KpmuserId = table.Column<int>(type: "int", nullable: false),
                    KpmuserType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enteredby = table.Column<int>(type: "int", nullable: false),
                    DateEntered = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DnnUserId = table.Column<int>(type: "int", nullable: true),
                    CoordAssigned = table.Column<int>(type: "int", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Addr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DnnuserIdOld = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "KpmUsersBcks",
                columns: table => new
                {
                    KpmuserId = table.Column<int>(type: "int", nullable: false),
                    KpmuserType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enteredby = table.Column<int>(type: "int", nullable: false),
                    DateEntered = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DnnUserId = table.Column<int>(type: "int", nullable: true),
                    CoordAssigned = table.Column<int>(type: "int", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Addr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DnnuserIdOld = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "KpmUsersEmpties",
                columns: table => new
                {
                    KpmuserId = table.Column<int>(type: "int", nullable: false),
                    KpmuserType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enteredby = table.Column<int>(type: "int", nullable: false),
                    DateEntered = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DnnUserId = table.Column<int>(type: "int", nullable: true),
                    CoordAssigned = table.Column<int>(type: "int", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Addr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DnnuserIdOld = table.Column<int>(type: "int", nullable: true),
                    Tempid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "KpmUsersSavs",
                columns: table => new
                {
                    KpmuserId = table.Column<int>(type: "int", nullable: false),
                    KpmuserType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enteredby = table.Column<int>(type: "int", nullable: false),
                    DateEntered = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DnnUserId = table.Column<int>(type: "int", nullable: true),
                    CoordAssigned = table.Column<int>(type: "int", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Addr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DnnuserIdOld = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "KpmUserTransferTables",
                columns: table => new
                {
                    Transferid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Petitions",
                columns: table => new
                {
                    PetitionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Petitiondescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Petitionname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateEntered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateReceived = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnteredBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    CityPetition = table.Column<bool>(type: "bit", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Petitions", x => x.PetitionId);
                });

            migrationBuilder.CreateTable(
                name: "Petitions2007s",
                columns: table => new
                {
                    Petitiondescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Petitionname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateEntered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PetitionId = table.Column<int>(type: "int", nullable: false),
                    DateReceived = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnteredBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PetitionSummaries",
                columns: table => new
                {
                    Petitionid = table.Column<int>(type: "int", nullable: true),
                    Batchid = table.Column<int>(type: "int", nullable: true),
                    Batchinitcount = table.Column<int>(type: "int", nullable: true),
                    Batchrawcount = table.Column<int>(type: "int", nullable: true),
                    Batchpurgecount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PetitionSummaryOlds",
                columns: table => new
                {
                    Petitionid = table.Column<int>(type: "int", nullable: true),
                    Batchid = table.Column<int>(type: "int", nullable: true),
                    Batchinitcount = table.Column<int>(type: "int", nullable: true),
                    Batchrawcount = table.Column<int>(type: "int", nullable: true),
                    Batchpurgecount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PetitionSummarySubmitteds",
                columns: table => new
                {
                    Petitionid = table.Column<int>(type: "int", nullable: true),
                    Batchid = table.Column<int>(type: "int", nullable: true),
                    Batchsubmittedcount = table.Column<int>(type: "int", nullable: true),
                    Batchrawcount = table.Column<int>(type: "int", nullable: true),
                    Batchpurgecount = table.Column<int>(type: "int", nullable: true),
                    Batchnewreg = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Tempcounts",
                columns: table => new
                {
                    Petitionname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Votercount = table.Column<int>(type: "int", nullable: true),
                    Badcount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Temptables",
                columns: table => new
                {
                    Coordinatorid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PetitionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Totalupdates",
                columns: table => new
                {
                    Petitionname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Countydups = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "userRoles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    roleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    roleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    effectiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    expiryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userRoles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Validatorcounts",
                columns: table => new
                {
                    ValId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: true),
                    Fname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rolename = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Validcount = table.Column<int>(type: "int", nullable: true),
                    Badcount = table.Column<int>(type: "int", nullable: true),
                    Dupcount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Validators",
                columns: table => new
                {
                    Validatorid = table.Column<int>(type: "int", nullable: true),
                    Validatorname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Validcount = table.Column<int>(type: "int", nullable: true),
                    Notfoundcount = table.Column<int>(type: "int", nullable: true),
                    Dupcount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Validatortotals",
                columns: table => new
                {
                    Valid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ttlgood = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Ttlbad = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Ttldup = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Fname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Petitionname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Validatortotals3valids",
                columns: table => new
                {
                    Valid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ttlgood = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Ttlbad = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Ttldup = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Validatortotalsalls",
                columns: table => new
                {
                    Valid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Petitionname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ttlgood = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Ttlbad = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Ttldup = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ValidatortotalsOldnews",
                columns: table => new
                {
                    Valid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ttlgood = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Ttlbad = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Ttldup = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VoterDups",
                columns: table => new
                {
                    PetitionId = table.Column<int>(type: "int", nullable: false),
                    BatchId = table.Column<int>(type: "int", nullable: false),
                    Dateentered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VoterId = table.Column<int>(type: "int", nullable: false),
                    Enteredby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recordid = table.Column<int>(type: "int", nullable: false),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Circid = table.Column<int>(type: "int", nullable: false),
                    Batchentryid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VoterDups2007s",
                columns: table => new
                {
                    PetitionId = table.Column<int>(type: "int", nullable: false),
                    BatchId = table.Column<int>(type: "int", nullable: false),
                    Dateentered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VoterId = table.Column<int>(type: "int", nullable: false),
                    Enteredby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recordid = table.Column<int>(type: "int", nullable: false),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Circid = table.Column<int>(type: "int", nullable: false),
                    Batchentryid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VoterDups2020s",
                columns: table => new
                {
                    PetitionId = table.Column<int>(type: "int", nullable: false),
                    BatchId = table.Column<int>(type: "int", nullable: false),
                    Dateentered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VoterId = table.Column<int>(type: "int", nullable: false),
                    Enteredby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recordid = table.Column<int>(type: "int", nullable: false),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Circid = table.Column<int>(type: "int", nullable: false),
                    Batchentryid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VoterDupsbacks",
                columns: table => new
                {
                    PetitionId = table.Column<int>(type: "int", nullable: false),
                    BatchId = table.Column<int>(type: "int", nullable: false),
                    Dateentered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VoterId = table.Column<int>(type: "int", nullable: false),
                    Enteredby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recordid = table.Column<int>(type: "int", nullable: false),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Circid = table.Column<int>(type: "int", nullable: false),
                    Batchentryid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VoterDupViews",
                columns: table => new
                {
                    Petitionname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Countycount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VoterRecord2007s",
                columns: table => new
                {
                    Dateentered = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PetitionId = table.Column<int>(type: "int", nullable: false),
                    Batchid = table.Column<int>(type: "int", nullable: false),
                    Voterid = table.Column<int>(type: "int", nullable: false),
                    Enteredby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Circid = table.Column<int>(type: "int", nullable: false),
                    Batchentryid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VoterRecord2020s",
                columns: table => new
                {
                    Dateentered = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PetitionId = table.Column<int>(type: "int", nullable: false),
                    Batchid = table.Column<int>(type: "int", nullable: false),
                    Voterid = table.Column<int>(type: "int", nullable: false),
                    Enteredby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Circid = table.Column<int>(type: "int", nullable: false),
                    Batchentryid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VoterRecords",
                columns: table => new
                {
                    Dateentered = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PetitionId = table.Column<int>(type: "int", nullable: false),
                    Batchid = table.Column<int>(type: "int", nullable: false),
                    Voterid = table.Column<int>(type: "int", nullable: false),
                    Enteredby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Circid = table.Column<int>(type: "int", nullable: false),
                    Batchentryid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VoterRecordViews",
                columns: table => new
                {
                    Petitionname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Countycount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Voters",
                columns: table => new
                {
                    Ln = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Namesuffix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resstate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resaddr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Voterid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VwBadDetailByEntryIds",
                columns: table => new
                {
                    BatchId = table.Column<int>(type: "int", nullable: false),
                    Circfullname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Entryid = table.Column<int>(type: "int", nullable: false),
                    PetitionId = table.Column<int>(type: "int", nullable: false),
                    Fn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ln = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resaddr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resstate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VwBatchesNotReceiveds",
                columns: table => new
                {
                    BatchId = table.Column<int>(type: "int", nullable: false),
                    Petitionname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateSubmitted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateReceived = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DnnUserId = table.Column<int>(type: "int", nullable: true),
                    Days = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VwGoodDetailByEntryIds",
                columns: table => new
                {
                    BatchId = table.Column<int>(type: "int", nullable: false),
                    Entryid = table.Column<int>(type: "int", nullable: false),
                    Circfullname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PetitionId = table.Column<int>(type: "int", nullable: false),
                    Fn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ln = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resaddr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resstate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VwVoterDupsWpetitionNames",
                columns: table => new
                {
                    PetitionId = table.Column<int>(type: "int", nullable: false),
                    BatchId = table.Column<int>(type: "int", nullable: false),
                    Dateentered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VoterId = table.Column<int>(type: "int", nullable: false),
                    Enteredby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recordid = table.Column<int>(type: "int", nullable: false),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Circid = table.Column<int>(type: "int", nullable: false),
                    Batchentryid = table.Column<int>(type: "int", nullable: false),
                    Petitionname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VwVoterRecordWpetitionNames",
                columns: table => new
                {
                    Dateentered = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PetitionId = table.Column<int>(type: "int", nullable: false),
                    Batchid = table.Column<int>(type: "int", nullable: false),
                    Voterid = table.Column<int>(type: "int", nullable: false),
                    Enteredby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Circid = table.Column<int>(type: "int", nullable: false),
                    Batchentryid = table.Column<int>(type: "int", nullable: false),
                    Petitionname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BatchDetail2007s");

            migrationBuilder.DropTable(
                name: "BatchDetail2020s");

            migrationBuilder.DropTable(
                name: "BatchDetails");

            migrationBuilder.DropTable(
                name: "Batches");

            migrationBuilder.DropTable(
                name: "Batches2007s");

            migrationBuilder.DropTable(
                name: "Batches2020s");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "CityVoters");

            migrationBuilder.DropTable(
                name: "Cntybads");

            migrationBuilder.DropTable(
                name: "Cntydups");

            migrationBuilder.DropTable(
                name: "Cntygoods");

            migrationBuilder.DropTable(
                name: "Cntytotals");

            migrationBuilder.DropTable(
                name: "Combinedrecords");

            migrationBuilder.DropTable(
                name: "CoordBatchLists");

            migrationBuilder.DropTable(
                name: "CoordBatchListSubmitteds");

            migrationBuilder.DropTable(
                name: "CoordBatchListSubmittedTemps");

            migrationBuilder.DropTable(
                name: "CoordBatchListTemps");

            migrationBuilder.DropTable(
                name: "CoordDups");

            migrationBuilder.DropTable(
                name: "Coordinators");

            migrationBuilder.DropTable(
                name: "CoordSummaries");

            migrationBuilder.DropTable(
                name: "CoordUpdates");

            migrationBuilder.DropTable(
                name: "CoordUpdates2007s");

            migrationBuilder.DropTable(
                name: "Counties");

            migrationBuilder.DropTable(
                name: "CountyTotalsViews");

            migrationBuilder.DropTable(
                name: "DailyReports");

            migrationBuilder.DropTable(
                name: "GetPetetion");

            migrationBuilder.DropTable(
                name: "KpmcircReports");

            migrationBuilder.DropTable(
                name: "KpmcircReportSubmitteds");

            migrationBuilder.DropTable(
                name: "KpmCoordUpdates");

            migrationBuilder.DropTable(
                name: "KpmUsers");

            migrationBuilder.DropTable(
                name: "KpmUsers2009Blendeds");

            migrationBuilder.DropTable(
                name: "KpmUsers2019Bcks");

            migrationBuilder.DropTable(
                name: "KpmUsers2020s");

            migrationBuilder.DropTable(
                name: "KpmUsersBcks");

            migrationBuilder.DropTable(
                name: "KpmUsersEmpties");

            migrationBuilder.DropTable(
                name: "KpmUsersSavs");

            migrationBuilder.DropTable(
                name: "KpmUserTransferTables");

            migrationBuilder.DropTable(
                name: "Petitions");

            migrationBuilder.DropTable(
                name: "Petitions2007s");

            migrationBuilder.DropTable(
                name: "PetitionSummaries");

            migrationBuilder.DropTable(
                name: "PetitionSummaryOlds");

            migrationBuilder.DropTable(
                name: "PetitionSummarySubmitteds");

            migrationBuilder.DropTable(
                name: "Tempcounts");

            migrationBuilder.DropTable(
                name: "Temptables");

            migrationBuilder.DropTable(
                name: "Totalupdates");

            migrationBuilder.DropTable(
                name: "userRoles");

            migrationBuilder.DropTable(
                name: "Validatorcounts");

            migrationBuilder.DropTable(
                name: "Validators");

            migrationBuilder.DropTable(
                name: "Validatortotals");

            migrationBuilder.DropTable(
                name: "Validatortotals3valids");

            migrationBuilder.DropTable(
                name: "Validatortotalsalls");

            migrationBuilder.DropTable(
                name: "ValidatortotalsOldnews");

            migrationBuilder.DropTable(
                name: "VoterDups");

            migrationBuilder.DropTable(
                name: "VoterDups2007s");

            migrationBuilder.DropTable(
                name: "VoterDups2020s");

            migrationBuilder.DropTable(
                name: "VoterDupsbacks");

            migrationBuilder.DropTable(
                name: "VoterDupViews");

            migrationBuilder.DropTable(
                name: "VoterRecord2007s");

            migrationBuilder.DropTable(
                name: "VoterRecord2020s");

            migrationBuilder.DropTable(
                name: "VoterRecords");

            migrationBuilder.DropTable(
                name: "VoterRecordViews");

            migrationBuilder.DropTable(
                name: "Voters");

            migrationBuilder.DropTable(
                name: "VwBadDetailByEntryIds");

            migrationBuilder.DropTable(
                name: "VwBatchesNotReceiveds");

            migrationBuilder.DropTable(
                name: "VwGoodDetailByEntryIds");

            migrationBuilder.DropTable(
                name: "VwVoterDupsWpetitionNames");

            migrationBuilder.DropTable(
                name: "VwVoterRecordWpetitionNames");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
