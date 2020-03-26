using Microsoft.EntityFrameworkCore.Migrations;

namespace SoftwareDownloadSystem.Migrations
{
    public partial class NewDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_softwareDownloads",
                table: "softwareDownloads");

            migrationBuilder.RenameTable(
                name: "softwareDownloads",
                newName: "softwareDownloadsystem");

            migrationBuilder.AddPrimaryKey(
                name: "PK_softwareDownloadsystem",
                table: "softwareDownloadsystem",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_softwareDownloadsystem",
                table: "softwareDownloadsystem");

            migrationBuilder.RenameTable(
                name: "softwareDownloadsystem",
                newName: "softwareDownloads");

            migrationBuilder.AddPrimaryKey(
                name: "PK_softwareDownloads",
                table: "softwareDownloads",
                column: "ID");
        }
    }
}
