using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication12.Migrations
{
    public partial class CreatePoliklinikIdColumnInDoktorlarTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PoliklinikId",
                table: "Doktorlar",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PoliklinikId",
                table: "Doktorlar");
        }
    }
}
