using Microsoft.EntityFrameworkCore.Migrations;

namespace KissKartan.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Average",
                table: "Ratings");

            migrationBuilder.RenameColumn(
                name: "Count",
                table: "Ratings",
                newName: "Stars");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Stars",
                table: "Ratings",
                newName: "Count");

            migrationBuilder.AddColumn<double>(
                name: "Average",
                table: "Ratings",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
