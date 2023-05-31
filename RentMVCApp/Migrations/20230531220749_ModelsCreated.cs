using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentMVCApp.Migrations
{
    /// <inheritdoc />
    public partial class ModelsCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    addres = table.Column<int>(type: "INTEGER", nullable: false),
                    openfrom = table.Column<DateTime>(type: "TEXT", nullable: true),
                    openUntil = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    itemID = table.Column<int>(type: "INTEGER", nullable: false),
                    userId = table.Column<string>(type: "TEXT", nullable: true),
                    reservedFrom = table.Column<DateTime>(type: "TEXT", nullable: false),
                    reservedUntill = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Reservation");
        }
    }
}
