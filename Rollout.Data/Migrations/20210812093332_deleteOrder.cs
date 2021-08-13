using Microsoft.EntityFrameworkCore.Migrations;

namespace Rollout.Data.Migrations
{
    public partial class deleteOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Order_OrderId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkStations_Order_OrderId",
                table: "WorkStations");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropIndex(
                name: "IX_WorkStations_OrderId",
                table: "WorkStations");

            migrationBuilder.DropIndex(
                name: "IX_Customer_OrderId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "WorkStations");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Customer");

            migrationBuilder.AddColumn<int>(
                name: "Ticketnumber",
                table: "WorkStations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ticketnumber",
                table: "WorkStations");

            migrationBuilder.AddColumn<string>(
                name: "OrderId",
                table: "WorkStations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderId",
                table: "Customer",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ticketnumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkStations_OrderId",
                table: "WorkStations",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_OrderId",
                table: "Customer",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Order_OrderId",
                table: "Customer",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkStations_Order_OrderId",
                table: "WorkStations",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
