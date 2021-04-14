using Microsoft.EntityFrameworkCore.Migrations;

namespace petition.Migrations
{
    public partial class _1342021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DisplayBathListForPrint",
                columns: table => new
                {
                    BatchID = table.Column<int>(type: "int", nullable: false),
                    circid = table.Column<int>(type: "int", nullable: false),
                    circfullname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    circinitsigs = table.Column<int>(type: "int", nullable: false),
                    entryid = table.Column<int>(type: "int", nullable: false),
                    circrawcount = table.Column<int>(type: "int", nullable: true),
                    pcInitials = table.Column<int>(type: "int", nullable: true),
                    pcPOBox = table.Column<int>(type: "int", nullable: true),
                    pcDiffCounty = table.Column<int>(type: "int", nullable: true),
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
                    BadCount = table.Column<int>(type: "int", nullable: false),
                    GoodCount = table.Column<int>(type: "int", nullable: false),
                    GoodPercent = table.Column<int>(type: "int", nullable: false),
                    SubmittedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DisplayBathListForPrint");
        }
    }
}
