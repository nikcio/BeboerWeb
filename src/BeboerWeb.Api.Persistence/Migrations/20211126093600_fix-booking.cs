using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeboerWeb.Api.Persistence.Migrations
{
    public partial class fixbooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingItemBookingWindow");

            migrationBuilder.AddColumn<int>(
                name: "BookingItemId",
                table: "BookingWindows",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookingWindows_BookingItemId",
                table: "BookingWindows",
                column: "BookingItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingWindows_BookingItems_BookingItemId",
                table: "BookingWindows",
                column: "BookingItemId",
                principalTable: "BookingItems",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingWindows_BookingItems_BookingItemId",
                table: "BookingWindows");

            migrationBuilder.DropIndex(
                name: "IX_BookingWindows_BookingItemId",
                table: "BookingWindows");

            migrationBuilder.DropColumn(
                name: "BookingItemId",
                table: "BookingWindows");

            migrationBuilder.CreateTable(
                name: "BookingItemBookingWindow",
                columns: table => new
                {
                    BookingItemsId = table.Column<int>(type: "int", nullable: false),
                    BookingWindowsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingItemBookingWindow", x => new { x.BookingItemsId, x.BookingWindowsId });
                    table.ForeignKey(
                        name: "FK_BookingItemBookingWindow_BookingItems_BookingItemsId",
                        column: x => x.BookingItemsId,
                        principalTable: "BookingItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingItemBookingWindow_BookingWindows_BookingWindowsId",
                        column: x => x.BookingWindowsId,
                        principalTable: "BookingWindows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookingItemBookingWindow_BookingWindowsId",
                table: "BookingItemBookingWindow",
                column: "BookingWindowsId");
        }
    }
}
