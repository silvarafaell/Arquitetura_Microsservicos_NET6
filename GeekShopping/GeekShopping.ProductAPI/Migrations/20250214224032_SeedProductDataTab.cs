using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductDataTab : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "Id", "category_name", "description", "image_url", "name", "price" },
                values: new object[] { 2L, "CategoryName", "Description", "ImageURL", "Name", 69.9m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: 2L);
        }
    }
}
