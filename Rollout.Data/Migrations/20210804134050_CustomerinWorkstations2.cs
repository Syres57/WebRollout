using Microsoft.EntityFrameworkCore.Migrations;

namespace Rollout.Data.Migrations
{
    public partial class CustomerinWorkstations2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_WorkStations_WorkStationId",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Customers_WorkStationId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "WorkStationId",
                table: "Customer");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "WorkStations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkStations_CustomerId",
                table: "WorkStations",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkStations_Customer_CustomerId",
                table: "WorkStations",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkStations_Customer_CustomerId",
                table: "WorkStations");

            migrationBuilder.DropIndex(
                name: "IX_WorkStations_CustomerId",
                table: "WorkStations");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "WorkStations");

            migrationBuilder.AddColumn<int>(
                name: "WorkStationId",
                table: "Customer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customer_WorkStationId",
                table: "Customer",
                column: "WorkStationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_WorkStations_WorkStationId",
                table: "Customer",
                column: "WorkStationId",
                principalTable: "WorkStations",
                principalColumn: "WorkStationId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
