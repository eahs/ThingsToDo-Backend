using Microsoft.EntityFrameworkCore.Migrations;

namespace ADSBackend.Migrations
{
    public partial class HourCost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cost",
                table: "Place",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hours",
                table: "Place",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Place");

            migrationBuilder.DropColumn(
                name: "Hours",
                table: "Place");
        }
    }
}
