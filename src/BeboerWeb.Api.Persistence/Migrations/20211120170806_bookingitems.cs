using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeboerWeb.Api.Persistence.Migrations
{
    public partial class bookingitems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "BookingItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "BookingItems",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "BookingItems",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "BookingItems");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "BookingItems");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "BookingItems");
        }
    }
}
