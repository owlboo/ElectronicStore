using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ElectronicStore.Data
{
    public partial class AddProdToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    MetaTitle = table.Column<string>(nullable: true),
                    SEOTitle = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Images = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    PromotionPrice = table.Column<double>(nullable: false),
                    IncludeVAT = table.Column<bool>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    CategoryId = table.Column<long>(nullable: false),
                    BrandId = table.Column<long>(nullable: false),
                    Warranty = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    MetaKeyword = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    MetaDescription = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    ShowOnHome = table.Column<bool>(nullable: false),
                    TopHot = table.Column<DateTime>(nullable: false),
                    ViewCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
