#nullable disable

namespace CarShop.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddCarFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Features",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Features",
                table: "Cars");
        }
    }
}
