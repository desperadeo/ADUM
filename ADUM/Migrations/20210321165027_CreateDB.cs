using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ADUM.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SamAccountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiredTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tokens", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tokens",
                columns: new[] { "Id", "ADGroup", "ExpiredTime", "SamAccountName", "StartTime", "Status" },
                values: new object[] { 1, "G_INF_ADM", new DateTime(2021, 3, 15, 8, 9, 14, 0, DateTimeKind.Unspecified), "dan", new DateTime(2021, 3, 15, 8, 4, 14, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.InsertData(
                table: "Tokens",
                columns: new[] { "Id", "ADGroup", "ExpiredTime", "SamAccountName", "StartTime", "Status" },
                values: new object[] { 2, "G_INF_ADM", new DateTime(2021, 3, 20, 18, 34, 14, 0, DateTimeKind.Unspecified), "toan", new DateTime(2021, 3, 20, 18, 24, 14, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.InsertData(
                table: "Tokens",
                columns: new[] { "Id", "ADGroup", "ExpiredTime", "SamAccountName", "StartTime", "Status" },
                values: new object[] { 3, "G_INF_ADM", new DateTime(2021, 3, 21, 20, 4, 14, 0, DateTimeKind.Unspecified), "alex", new DateTime(2021, 3, 21, 12, 4, 14, 0, DateTimeKind.Unspecified), 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tokens");
        }
    }
}
