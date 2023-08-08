using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication12.Migrations
{
    public partial class PolikliniklerOlusum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Poliklinikler",
                columns: table => new
                {
                    PoliklinikId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    poliklinikAdı = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poliklinikler", x => x.PoliklinikId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Poliklinikler");
        }
    }
}
