using Microsoft.EntityFrameworkCore.Migrations;

namespace Indecor.Migrations
{
    public partial class wtoWeek : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_weekCategories",
                table: "weekCategories");

            migrationBuilder.RenameTable(
                name: "weekCategories",
                newName: "WeekCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeekCategories",
                table: "WeekCategories",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WeekCategories",
                table: "WeekCategories");

            migrationBuilder.RenameTable(
                name: "WeekCategories",
                newName: "weekCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_weekCategories",
                table: "weekCategories",
                column: "Id");
        }
    }
}
