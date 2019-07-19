using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ElectronicStore.Data
{
    public partial class addProdAttToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductAttributes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RAM = table.Column<int>(nullable: false),
                    CPU = table.Column<string>(nullable: true),
                    FrontCamera = table.Column<double>(nullable: false),
                    MainCamera = table.Column<double>(nullable: false),
                    Resolution = table.Column<string>(nullable: true),
                    ExternalStorage = table.Column<string>(nullable: true),
                    SIMCount = table.Column<int>(nullable: false),
                    PinCapacity = table.Column<int>(nullable: false),
                    OS = table.Column<string>(nullable: true),
                    Capacity = table.Column<string>(nullable: true),
                    MonitorSize = table.Column<string>(nullable: true),
                    Connection2G = table.Column<string>(nullable: true),
                    Connection3G = table.Column<string>(nullable: true),
                    Connection4G = table.Column<string>(nullable: true),
                    Wifi = table.Column<string>(nullable: true),
                    GPS = table.Column<string>(nullable: true),
                    Bluetooth = table.Column<string>(nullable: true),
                    ProductId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAttributes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributes_ProductId",
                table: "ProductAttributes",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductAttributes");
        }
    }
}
