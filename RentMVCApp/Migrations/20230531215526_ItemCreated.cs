using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentMVCApp.Migrations
{
    /// <inheritdoc />
    public partial class ItemCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    price = table.Column<int>(type: "INTEGER", nullable: false),
                    type = table.Column<int>(type: "INTEGER", nullable: false),
                    availability = table.Column<bool>(type: "INTEGER", nullable: false),
                    description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
