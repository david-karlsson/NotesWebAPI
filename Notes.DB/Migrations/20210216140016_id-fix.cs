using Microsoft.EntityFrameworkCore.Migrations;

namespace Notes.DB.Migrations
{
    public partial class idfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Notes",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Notes",
                newName: "id");
        }
    }
}
