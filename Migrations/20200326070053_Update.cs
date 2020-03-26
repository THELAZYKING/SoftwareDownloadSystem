using Microsoft.EntityFrameworkCore.Migrations;

namespace SoftwareDownloadSystem.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Tags",
                table: "softwareDownloads",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Software_License",
                table: "softwareDownloads",
                type: "nvarchar(255)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Software_License",
                table: "softwareDownloads");

            migrationBuilder.AlterColumn<string>(
                name: "Tags",
                table: "softwareDownloads",
                type: "nvarchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);
        }
    }
}
