using Microsoft.EntityFrameworkCore.Migrations;

namespace Rollout.Data.Migrations
{
    public partial class changed_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Isolation_Report",
                table: "WorkStations",
                newName: "EmissionsReport");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmissionsReport",
                table: "WorkStations",
                newName: "Isolation_Report");
        }
    }
}
