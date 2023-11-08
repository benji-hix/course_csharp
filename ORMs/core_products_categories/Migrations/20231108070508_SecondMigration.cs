using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace core_products_categories.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Categories");

            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Categories",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "Categories",
                type: "float",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
