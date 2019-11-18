using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ADSBackend.Migrations
{
    public partial class PlaceType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlaceTypeId",
                table: "Place",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PlaceType",
                columns: table => new
                {
                    PlaceTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceType", x => x.PlaceTypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Place_PlaceTypeId",
                table: "Place",
                column: "PlaceTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Place_PlaceType_PlaceTypeId",
                table: "Place",
                column: "PlaceTypeId",
                principalTable: "PlaceType",
                principalColumn: "PlaceTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Place_PlaceType_PlaceTypeId",
                table: "Place");

            migrationBuilder.DropTable(
                name: "PlaceType");

            migrationBuilder.DropIndex(
                name: "IX_Place_PlaceTypeId",
                table: "Place");

            migrationBuilder.DropColumn(
                name: "PlaceTypeId",
                table: "Place");
        }
    }
}
