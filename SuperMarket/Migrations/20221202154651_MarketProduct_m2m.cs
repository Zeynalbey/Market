using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperMarket.Migrations
{
    /// <inheritdoc />
    public partial class MarketProductm2m : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "MarketProducts",
               columns: table => new
               {
                   MarketId = table.Column<int>(type: "int", nullable: false),
                   ProductId = table.Column<int>(type: "int", nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_MarketProducts", x => new { x.MarketId, x.ProductId });
                   table.ForeignKey(
                       name: "FK_MarketProducts_Markets_MarketId",
                       column: x => x.MarketId,
                       principalTable: "Markets",
                       principalColumn: "Id",
                       onDelete: ReferentialAction.Cascade);
                   table.ForeignKey(
                       name: "FK_MarketProducts_Products_ProductId",
                       column: x => x.ProductId,
                       principalTable: "Products",
                       principalColumn: "Id",
                       onDelete: ReferentialAction.Cascade);
               });

            migrationBuilder.CreateIndex(
                name: "IX_MarketProducts_ProductId",
                table: "MarketProducts",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
               name: "MarketProducts");
        }
    }
}
