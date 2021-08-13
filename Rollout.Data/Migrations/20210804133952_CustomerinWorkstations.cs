using Microsoft.EntityFrameworkCore.Migrations;

namespace Rollout.Data.Migrations
{
    public partial class CustomerinWorkstations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Battery_Projects_ProjectsProjectId",
                table: "Battery");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Battery_ProjectsProjectId",
                table: "Battery");

            migrationBuilder.DropColumn(
                name: "ProjectsProjectId",
                table: "Battery");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProjectsProjectId",
                table: "Battery",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    DomainId = table.Column<int>(type: "int", nullable: true),
                    OrderId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    WorkStationStateId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    WorkStationsWorkStationId = table.Column<int>(type: "int", nullable: true),
                    WorkStepsStepId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_Projects_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projects_Domain_DomainId",
                        column: x => x.DomainId,
                        principalTable: "Domain",
                        principalColumn: "DomainId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projects_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projects_WorkStations_WorkStationsWorkStationId",
                        column: x => x.WorkStationsWorkStationId,
                        principalTable: "WorkStations",
                        principalColumn: "WorkStationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projects_WorkStationState_WorkStationStateId",
                        column: x => x.WorkStationStateId,
                        principalTable: "WorkStationState",
                        principalColumn: "WorkStationStateId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projects_WorkSteps_WorkStepsStepId",
                        column: x => x.WorkStepsStepId,
                        principalTable: "WorkSteps",
                        principalColumn: "StepId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Battery_ProjectsProjectId",
                table: "Battery",
                column: "ProjectsProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CustomerId",
                table: "Projects",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_DomainId",
                table: "Projects",
                column: "DomainId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_OrderId",
                table: "Projects",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_WorkStationStateId",
                table: "Projects",
                column: "WorkStationStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_WorkStationsWorkStationId",
                table: "Projects",
                column: "WorkStationsWorkStationId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_WorkStepsStepId",
                table: "Projects",
                column: "WorkStepsStepId");

            migrationBuilder.AddForeignKey(
                name: "FK_Battery_Projects_ProjectsProjectId",
                table: "Battery",
                column: "ProjectsProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
