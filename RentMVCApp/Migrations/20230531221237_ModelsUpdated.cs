using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentMVCApp.Migrations
{
    /// <inheritdoc />
    public partial class ModelsUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Reservation",
                newName: "userID");

            migrationBuilder.AlterColumn<int>(
                name: "userID",
                table: "Reservation",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "itemID",
                table: "Reservation",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_itemID",
                table: "Reservation",
                column: "itemID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_userID",
                table: "Reservation",
                column: "userID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Items_itemID",
                table: "Reservation",
                column: "itemID",
                principalTable: "Items",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_User_userID",
                table: "Reservation",
                column: "userID",
                principalTable: "User",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Items_itemID",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_User_userID",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_itemID",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_userID",
                table: "Reservation");

            migrationBuilder.RenameColumn(
                name: "userID",
                table: "Reservation",
                newName: "userId");

            migrationBuilder.AlterColumn<string>(
                name: "userId",
                table: "Reservation",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "itemID",
                table: "Reservation",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);
        }
    }
}
