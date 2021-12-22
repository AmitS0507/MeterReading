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
                    AccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.AccountId);
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
                columns: new[] { "AccountId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 2344, "Tommy", "Test" },
                    { 2233, "Bany", "Test" },
                    { 8766, "Sally", "Test" },
                    { 2345, "Jerry", "Test" },
                    { 2346, "Jerry", "Test" },
                    { 2347, "Jerry", "Test" },
                    { 2348, "Jerry", "Test" },
                    { 2349, "Jerry", "Test" },
                    { 2350, "Ollie", "Test" },
                    { 2351, "Tera", "Test" },
                    { 2352, "Tammy", "Test" },
                    { 2353, "Simon", "Test" },
                    { 2355, "Colin", "Test" },
                    { 2356, "Gladys", "Test" },
                    { 6776, "Greg", "Test" }
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
