using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeboerWeb.Api.Persistence.Migrations
{
    public partial class bookingupdate002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingWindows_BookingItems_BookingItemId",
                table: "BookingWindows");

            migrationBuilder.DropTable(
                name: "BookingBookingItem");

            migrationBuilder.AlterColumn<int>(
                name: "BookingItemId",
                table: "BookingWindows",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookingItemId",
                table: "Bookings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_BookingItemId",
                table: "Bookings",
                column: "BookingItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_BookingItems_BookingItemId",
                table: "Bookings",
                column: "BookingItemId",
                principalTable: "BookingItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingWindows_BookingItems_BookingItemId",
                table: "BookingWindows",
                column: "BookingItemId",
                principalTable: "BookingItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_BookingItems_BookingItemId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingWindows_BookingItems_BookingItemId",
                table: "BookingWindows");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_BookingItemId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "BookingItemId",
                table: "Bookings");

            migrationBuilder.AlterColumn<int>(
                name: "BookingItemId",
                table: "BookingWindows",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "BookingBookingItem",
                columns: table => new
                {
                    BookingItemsId = table.Column<int>(type: "int", nullable: false),
                    BookingsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingBookingItem", x => new { x.BookingItemsId, x.BookingsId });
                    table.ForeignKey(
                        name: "FK_BookingBookingItem_BookingItems_BookingItemsId",
                        column: x => x.BookingItemsId,
                        principalTable: "BookingItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingBookingItem_Bookings_BookingsId",
                        column: x => x.BookingsId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookingBookingItem_BookingsId",
                table: "BookingBookingItem",
                column: "BookingsId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingWindows_BookingItems_BookingItemId",
                table: "BookingWindows",
                column: "BookingItemId",
                principalTable: "BookingItems",
                principalColumn: "Id");
        }
    }
}
