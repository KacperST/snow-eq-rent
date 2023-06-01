using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentMVCApp.Migrations.Item
{
    /// <inheritdoc />
    public partial class SecondCreate : Migration
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
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    lastName = table.Column<string>(type: "TEXT", nullable: true),
                    addres = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    itemID = table.Column<int>(type: "INTEGER", nullable: true),
                    userID = table.Column<int>(type: "INTEGER", nullable: true),
                    reservedFrom = table.Column<DateTime>(type: "TEXT", nullable: false),
                    reservedUntill = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Reservation_Item_itemID",
                        column: x => x.itemID,
                        principalTable: "Item",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Reservation_User_userID",
                        column: x => x.userID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_itemID",
                table: "Reservation",
                column: "itemID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_userID",
                table: "Reservation",
                column: "userID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
