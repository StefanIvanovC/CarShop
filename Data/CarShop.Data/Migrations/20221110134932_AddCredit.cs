#nullable disable

namespace CarShop.Data.Migrations
{
    using System;

    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddCredit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Credits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsWorking = table.Column<bool>(type: "bit", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    TotalMoney = table.Column<int>(type: "int", nullable: false),
                    MonthPeriod = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Credits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Credits_AspNetUsers_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Credits_CreatedByUserId",
                table: "Credits",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Credits_IsDeleted",
                table: "Credits",
                column: "IsDeleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Credits");
        }
    }
}
