using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddedPIClaim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PIClaim",
                columns: table => new
                {
                    PIClaimId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimIdenfier = table.Column<int>(nullable: false),
                    ClaimIdenfier1 = table.Column<int>(nullable: true),
                    Deductible = table.Column<decimal>(nullable: true),
                    Amount = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PIClaim", x => x.PIClaimId);
                    table.ForeignKey(
                        name: "FK_PIClaim_Claims_ClaimIdenfier1",
                        column: x => x.ClaimIdenfier1,
                        principalTable: "Claims",
                        principalColumn: "ClaimIdenfier",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PIClaim_ClaimIdenfier1",
                table: "PIClaim",
                column: "ClaimIdenfier1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PIClaim");
        }
    }
}
