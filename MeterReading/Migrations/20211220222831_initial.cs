using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MeterReadings.API.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeterReading",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    MeterReadingDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MeterReadValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeterReading", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "AccountId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 2344, "Tommy", "Test" },
                    { 2, 2233, "Bany", "Test" },
                    { 3, 8766, "Sally", "Test" },
                    { 4, 2345, "Jerry", "Test" },
                    { 5, 2345, "Jerry", "Test" },
                    { 6, 2345, "Jerry", "Test" },
                    { 7, 2345, "Jerry", "Test" },
                    { 8, 2345, "Jerry", "Test" },
                    { 9, 2346, "Ollie", "Test" },
                    { 10, 2347, "Tera", "Test" },
                    { 11, 2348, "Tammy", "Test" },
                    { 12, 2349, "Simon", "Test" },
                    { 13, 2350, "Colin", "Test" },
                    { 14, 2351, "Gladys", "Test" },
                    { 15, 2352, "Greg", "Test" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "MeterReading");
        }
    }
}
