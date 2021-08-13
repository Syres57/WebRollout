using Microsoft.EntityFrameworkCore.Migrations;

namespace Rollout.Data.Migrations
{
    public partial class Customernew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkStations_Domains_DomainId",
                table: "WorkStations");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkStations_StorageLocations_StorageLocationLocationId",
                table: "WorkStations");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkStations_WorkStationStates_WorkStationStateId",
                table: "WorkStations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkStationStates",
                table: "WorkStationStates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StorageLocations",
                table: "StorageLocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Domains",
                table: "Domains");

            migrationBuilder.RenameTable(
                name: "WorkStationStates",
                newName: "WorkStationState");

            migrationBuilder.RenameTable(
                name: "StorageLocations",
                newName: "StorageLocation");

            migrationBuilder.RenameTable(
                name: "Domains",
                newName: "Domain");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkStationState",
                table: "WorkStationState",
                column: "WorkStationStateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StorageLocation",
                table: "StorageLocation",
                column: "LocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Domain",
                table: "Domain",
                column: "DomainId");

            migrationBuilder.CreateTable(
                name: "WorkSteps",
                columns: table => new
                {
                    StepId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinDuration = table.Column<int>(type: "int", nullable: false),
                    MaxDuration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkSteps", x => x.StepId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_WorkStations_Domain_DomainId",
                table: "WorkStations",
                column: "DomainId",
                principalTable: "Domain",
                principalColumn: "DomainId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkStations_StorageLocation_StorageLocationLocationId",
                table: "WorkStations",
                column: "StorageLocationLocationId",
                principalTable: "StorageLocation",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkStations_WorkStationState_WorkStationStateId",
                table: "WorkStations",
                column: "WorkStationStateId",
                principalTable: "WorkStationState",
                principalColumn: "WorkStationStateId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkStations_Domain_DomainId",
                table: "WorkStations");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkStations_StorageLocation_StorageLocationLocationId",
                table: "WorkStations");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkStations_WorkStationState_WorkStationStateId",
                table: "WorkStations");

            migrationBuilder.DropTable(
                name: "WorkSteps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkStationState",
                table: "WorkStationState");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StorageLocation",
                table: "StorageLocation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Domain",
                table: "Domain");

            migrationBuilder.RenameTable(
                name: "WorkStationState",
                newName: "WorkStationStates");

            migrationBuilder.RenameTable(
                name: "StorageLocation",
                newName: "StorageLocations");

            migrationBuilder.RenameTable(
                name: "Domain",
                newName: "Domains");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkStationStates",
                table: "WorkStationStates",
                column: "WorkStationStateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StorageLocations",
                table: "StorageLocations",
                column: "LocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Domains",
                table: "Domains",
                column: "DomainId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkStations_Domains_DomainId",
                table: "WorkStations",
                column: "DomainId",
                principalTable: "Domains",
                principalColumn: "DomainId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkStations_StorageLocations_StorageLocationLocationId",
                table: "WorkStations",
                column: "StorageLocationLocationId",
                principalTable: "StorageLocations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkStations_WorkStationStates_WorkStationStateId",
                table: "WorkStations",
                column: "WorkStationStateId",
                principalTable: "WorkStationStates",
                principalColumn: "WorkStationStateId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
