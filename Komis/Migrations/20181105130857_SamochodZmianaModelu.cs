using Microsoft.EntityFrameworkCore.Migrations;

namespace Komis.Migrations
{
    public partial class SamochodZmianaModelu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "JestWCentralii",
                table: "Samochody",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JestWCentralii",
                table: "Samochody");
        }
    }
}
