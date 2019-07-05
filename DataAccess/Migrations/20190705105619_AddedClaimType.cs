using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddedClaimType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClaimType",
                columns: table => new
                {
                    ClaimTypeID = table.Column<int>(nullable: false),
                    ClaimTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaimType", x => x.ClaimTypeID);
                });

            migrationBuilder.InsertData(
                table: "ClaimType",
                columns: new[] { "ClaimTypeID", "ClaimTypeName" },
                values: new object[] { 1, "P&&I" });

            migrationBuilder.InsertData(
                table: "ClaimType",
                columns: new[] { "ClaimTypeID", "ClaimTypeName" },
                values: new object[] { 2, "FDD" });

            migrationBuilder.InsertData(
                table: "ClaimType",
                columns: new[] { "ClaimTypeID", "ClaimTypeName" },
                values: new object[] { 3, "Loss Prevention" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClaimType");
        }
    }
}
