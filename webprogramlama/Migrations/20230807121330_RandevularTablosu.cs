using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication12.Migrations
{
    public partial class RandevularTablosu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Randevular",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    hastaAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    poliklinik = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    doktor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    gün = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevular", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Randevular");
        }
    }
}
