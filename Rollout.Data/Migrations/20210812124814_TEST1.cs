using Microsoft.EntityFrameworkCore.Migrations;

namespace Rollout.Data.Migrations
{
    public partial class TEST1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WorkStepsStepId",
                table: "WorkStations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkStations_WorkStepsStepId",
                table: "WorkStations",
                column: "WorkStepsStepId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkStations_WorkSteps_WorkStepsStepId",
                table: "WorkStations",
                column: "WorkStepsStepId",
                principalTable: "WorkSteps",
                principalColumn: "StepId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkStations_WorkSteps_WorkStepsStepId",
                table: "WorkStations");

            migrationBuilder.DropIndex(
                name: "IX_WorkStations_WorkStepsStepId",
                table: "WorkStations");

            migrationBuilder.DropColumn(
                name: "WorkStepsStepId",
                table: "WorkStations");
        }
    }
}
