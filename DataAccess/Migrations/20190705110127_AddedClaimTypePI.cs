using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddedClaimTypePI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ClaimType",
                keyColumn: "ClaimTypeID",
                keyValue: 1,
                column: "ClaimTypeName",
                value: "P&I");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ClaimType",
                keyColumn: "ClaimTypeID",
                keyValue: 1,
                column: "ClaimTypeName",
                value: "P&&I");
        }
    }
}
