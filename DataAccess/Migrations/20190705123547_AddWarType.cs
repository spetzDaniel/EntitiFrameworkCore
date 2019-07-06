using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddWarType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ClaimType",
                columns: new[] { "ClaimTypeID", "ClaimTypeName" },
                values: new object[] { 4, "War" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClaimType",
                keyColumn: "ClaimTypeID",
                keyValue: 4);
        }
    }
}
