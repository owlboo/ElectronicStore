using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ElectronicStore.Data
{
    public partial class addShipperAssignedForOrderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShipperAssignedForOrders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<long>(nullable: false),
                    ShipperId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipperAssignedForOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShipperAssignedForOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShipperAssignedForOrders_AspNetUsers_ShipperId",
                        column: x => x.ShipperId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShipperAssignedForOrders_OrderId",
                table: "ShipperAssignedForOrders",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipperAssignedForOrders_ShipperId",
                table: "ShipperAssignedForOrders",
                column: "ShipperId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShipperAssignedForOrders");
        }
    }
}
