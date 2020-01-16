using Microsoft.EntityFrameworkCore.Migrations;

namespace ADSBackend.Migrations
{
    public partial class URL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Place");

            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "Place",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "URL",
                table: "Place");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Place",
                nullable: false,
                defaultValue: "");
        }
    }
}
