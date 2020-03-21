using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SoftwareDownloadSystem.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "softwareDownloads",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Employee_Code = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Employee_EmailID = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Software_Name = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Software_Version = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tags = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Website_Link = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Team_Lead_ID = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Employee_Request_Time = table.Column<DateTime>(nullable: true),
                    Team_Lead_Status = table.Column<bool>(nullable: true),
                    Team_Lead_Reamrk = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Team_Lead_Response_Time = table.Column<DateTime>(nullable: true),
                    NSD_Response_Status = table.Column<bool>(nullable: true),
                    NSD_Response_Link = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    NSD_Response_Remark = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    NSD_Response_Time = table.Column<DateTime>(nullable: true),
                    Level_Status = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_softwareDownloads", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "softwareDownloads");
        }
    }
}
