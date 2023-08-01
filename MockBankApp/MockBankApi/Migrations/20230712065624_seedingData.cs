using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MockBankApi.Migrations
{
    /// <inheritdoc />
    public partial class seedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Staging",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: false),
                    AccountName = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    Currency = table.Column<string>(type: "TEXT", nullable: false),
                    CumulativeInflow = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staging", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Staging",
                columns: new[] { "Id", "AccountName", "AccountNumber", "Address", "City", "CumulativeInflow", "Currency", "State" },
                values: new object[,]
                {
                    { new Guid("4e9df2ed-8299-45ad-b293-9f23cd038d0d"), "John One Doe", "1500643512", "No3 Peninsula Graden Estate", "Ajah", 20000.0, "N", "Lagos" },
                    { new Guid("712f4112-7343-4b62-b8bb-2391035ffdf7"), "John Two Doe", "1500343511", "Dolphin Estate", "Ikoyi", 200.0, "N", "Lagos" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staging");
        }
    }
}
