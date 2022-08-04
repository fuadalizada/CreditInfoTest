using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CreditInfoTest.DAL.Migrations
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_INDIVIDUAL",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FIRSTNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LASTNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NATIONAL_ID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_INDIVIDUAL", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_CONTRACT",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IndividualId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ORIGINAL_AMOUNT = table.Column<decimal>(type: "decimal", nullable: false),
                    INSTALLMENT_AMOUNT = table.Column<decimal>(type: "decimal", nullable: false),
                    CURRENT_BALANCE = table.Column<decimal>(type: "decimal", nullable: false),
                    OVERDUE_BALANCE = table.Column<decimal>(type: "decimal", nullable: false),
                    CONTRACT_CODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DATE_OF_LAST_PAYMENT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NEXT_PAYMENT_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATE_ACCOUNT_OPENED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    REAL_END_DATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_CONTRACT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TBL_CONTRACT_TBL_INDIVIDUAL_IndividualId",
                        column: x => x.IndividualId,
                        principalTable: "TBL_INDIVIDUAL",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBL_CONTRACT_IndividualId",
                table: "TBL_CONTRACT",
                column: "IndividualId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_CONTRACT");

            migrationBuilder.DropTable(
                name: "TBL_INDIVIDUAL");
        }
    }
}
