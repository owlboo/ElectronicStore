using Microsoft.EntityFrameworkCore.Migrations;

namespace ElectronicStore.Data
{
    public partial class AddShipperConfPropToOrderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ShipperConfirm",
                table: "Orders",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShipperConfirm",
                table: "Orders");
        }
    }
}
