using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace petition.Migrations
{
    public partial class _1242021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DisplayBatchList",
                columns: table => new
                {
                    firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kpmuserid = table.Column<int>(type: "int", nullable: false),
                    batchid = table.Column<int>(type: "int", nullable: false),
                    circinitsigs = table.Column<int>(type: "int", nullable: false),
                    entryid = table.Column<int>(type: "int", nullable: false),
                    circrawcount = table.Column<int>(type: "int", nullable: true),
                    pcInitials = table.Column<int>(type: "int", nullable: true),
                    pcpobox = table.Column<int>(type: "int", nullable: true),
                    pcdiffcounty = table.Column<int>(type: "int", nullable: true),
                    pcIncomAddr = table.Column<int>(type: "int", nullable: true),
                    pcAddrIllegOrCopy = table.Column<int>(type: "int", nullable: true),
                    pcSigPrintedOrPrintIlleg = table.Column<int>(type: "int", nullable: true),
                    pcNameTwiceNoSig = table.Column<int>(type: "int", nullable: true),
                    pcHWSignForOther = table.Column<int>(type: "int", nullable: true),
                    pcWomanSignMrsHusbandFname = table.Column<int>(type: "int", nullable: true),
                    pcForgery = table.Column<int>(type: "int", nullable: true),
                    pcIncomDeclCirc = table.Column<int>(type: "int", nullable: true),
                    pcRubStampUsed = table.Column<int>(type: "int", nullable: true),
                    pcPencilUsed = table.Column<int>(type: "int", nullable: true),
                    pcDupSig = table.Column<int>(type: "int", nullable: true),
                    pcWhiteOut = table.Column<int>(type: "int", nullable: true),
                    pcOther = table.Column<int>(type: "int", nullable: true),
                    CircNewReg = table.Column<int>(type: "int", nullable: false),
                    BatchStatus = table.Column<int>(type: "int", nullable: false),
                    TotalSigs = table.Column<int>(type: "int", nullable: false),
                    BadTotal = table.Column<int>(type: "int", nullable: false),
                    SubmittedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "GetBatchList",
                columns: table => new
                {
                    DateAssgBatch = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BatchId = table.Column<int>(type: "int", nullable: false),
                    Petitionid = table.Column<int>(type: "int", nullable: false),
                    KpmuserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Petitionname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateReceivedBatch = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SigValue = table.Column<short>(type: "smallint", nullable: true),
                    RawCount = table.Column<int>(type: "int", nullable: true),
                    PurgedCount = table.Column<int>(type: "int", nullable: true),
                    DateSubmitted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SubmittedCount = table.Column<int>(type: "int", nullable: true),
                    SigAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "GetCirculator",
                columns: table => new
                {
                    lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kpmuserID = table.Column<int>(type: "int", nullable: false),
                    coordassigned = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    displayname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    addr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    zip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DisplayBatchList");

            migrationBuilder.DropTable(
                name: "GetBatchList");

            migrationBuilder.DropTable(
                name: "GetCirculator");
        }
    }
}
