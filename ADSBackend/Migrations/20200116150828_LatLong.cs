using Microsoft.EntityFrameworkCore.Migrations;

namespace ADSBackend.Migrations
{
    public partial class LatLong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Coordinates",
                table: "Place");

            migrationBuilder.AddColumn<int>(
                name: "Latitude",
                table: "Place",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Longitude",
                table: "Place",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Place");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Place");

            migrationBuilder.AddColumn<string>(
                name: "Coordinates",
                table: "Place",
                nullable: false,
                defaultValue: "");
        }
    }
}
