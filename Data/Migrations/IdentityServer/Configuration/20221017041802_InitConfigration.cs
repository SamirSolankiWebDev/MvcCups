using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcCups.Data.Migrations.IdentityServer.Configuration
{
    public partial class InitConfigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleName = table.Column<string>(nullable: true),
                    ManufacturingDate = table.Column<DateTime>(nullable: false),
                    Shape = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    Colour = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Review = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cup", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cup");
        }
    }
}
