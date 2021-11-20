using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace BeboerWeb.Api.Persistence.Migrations
{
    public partial class domainupdate001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingItems_Bookings_BookingId",
                table: "BookingItems");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingItems_Calenders_CalenderId",
                table: "BookingItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_BookingWindows_BookingWindowId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingWindows_Calenders_CalenderId",
                table: "BookingWindows");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_People_PersonId",
                table: "Employees");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_LeasePeriodTenant_LeasePeriods_LessePeriodsId",
            //    table: "LeasePeriodTenant");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_People_PersonId",
                table: "Tenants");

            migrationBuilder.DropTable(
                name: "Calenders");

            migrationBuilder.DropTable(
                name: "CompanyEmployee1");

            migrationBuilder.DropTable(
                name: "LeaseProperty");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropIndex(
                name: "IX_Tenants_PersonId",
                table: "Tenants");

            migrationBuilder.DropIndex(
                name: "IX_Employees_PersonId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_BookingWindows_CalenderId",
                table: "BookingWindows");

            migrationBuilder.DropIndex(
                name: "IX_BookingItems_BookingId",
                table: "BookingItems");

            migrationBuilder.DropIndex(
                name: "IX_BookingItems_CalenderId",
                table: "BookingItems");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CalenderId",
                table: "BookingWindows");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "BookingItems");

            migrationBuilder.DropColumn(
                name: "CalenderId",
                table: "BookingItems");

            migrationBuilder.RenameColumn(
                name: "LessePeriodsId",
                table: "LeasePeriodTenant",
                newName: "LeasePeriodsId");

            migrationBuilder.RenameColumn(
                name: "BookingWindowId",
                table: "Bookings",
                newName: "TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_BookingWindowId",
                table: "Bookings",
                newName: "IX_Bookings_TenantId");

            migrationBuilder.AddColumn<double>(
                name: "Balance",
                table: "Tenants",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Tenants",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Tenants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Leases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PropertyId",
                table: "Leases",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "LeasePeriods",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Employees",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookingDocument",
                columns: table => new
                {
                    BookingsId = table.Column<int>(type: "int", nullable: false),
                    DocumentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingDocument", x => new { x.BookingsId, x.DocumentsId });
                    table.ForeignKey(
                        name: "FK_BookingDocument_Bookings_BookingsId",
                        column: x => x.BookingsId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingDocument_Documents_DocumentsId",
                        column: x => x.DocumentsId,
                        principalTable: "Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DocumentLeasePeriod",
                columns: table => new
                {
                    DocumentsId = table.Column<int>(type: "int", nullable: false),
                    LeasePeriodsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentLeasePeriod", x => new { x.DocumentsId, x.LeasePeriodsId });
                    table.ForeignKey(
                        name: "FK_DocumentLeasePeriod_Documents_DocumentsId",
                        column: x => x.DocumentsId,
                        principalTable: "Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocumentLeasePeriod_LeasePeriods_LeasePeriodsId",
                        column: x => x.LeasePeriodsId,
                        principalTable: "LeasePeriods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Leases_AddressId",
                table: "Leases",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Leases_PropertyId",
                table: "Leases",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingBookingItem_BookingsId",
                table: "BookingBookingItem",
                column: "BookingsId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingDocument_DocumentsId",
                table: "BookingDocument",
                column: "DocumentsId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingItemBookingWindow_BookingWindowsId",
                table: "BookingItemBookingWindow",
                column: "BookingWindowsId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentLeasePeriod_LeasePeriodsId",
                table: "DocumentLeasePeriod",
                column: "LeasePeriodsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Tenants_TenantId",
                table: "Bookings",
                column: "TenantId",
                principalTable: "Tenants",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeasePeriodTenant_LeasePeriods_LeasePeriodsId",
                table: "LeasePeriodTenant",
                column: "LeasePeriodsId",
                principalTable: "LeasePeriods",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Leases_Addresses_AddressId",
                table: "Leases",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Leases_Properties_PropertyId",
                table: "Leases",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Tenants_TenantId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_LeasePeriodTenant_LeasePeriods_LeasePeriodsId",
                table: "LeasePeriodTenant");

            migrationBuilder.DropForeignKey(
                name: "FK_Leases_Addresses_AddressId",
                table: "Leases");

            migrationBuilder.DropForeignKey(
                name: "FK_Leases_Properties_PropertyId",
                table: "Leases");

            migrationBuilder.DropTable(
                name: "BookingBookingItem");

            migrationBuilder.DropTable(
                name: "BookingDocument");

            migrationBuilder.DropTable(
                name: "BookingItemBookingWindow");

            migrationBuilder.DropTable(
                name: "DocumentLeasePeriod");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropIndex(
                name: "IX_Leases_AddressId",
                table: "Leases");

            migrationBuilder.DropIndex(
                name: "IX_Leases_PropertyId",
                table: "Leases");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Leases");

            migrationBuilder.DropColumn(
                name: "PropertyId",
                table: "Leases");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "LeasePeriodsId",
                table: "LeasePeriodTenant",
                newName: "LessePeriodsId");

            migrationBuilder.RenameColumn(
                name: "TenantId",
                table: "Bookings",
                newName: "BookingWindowId");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_TenantId",
                table: "Bookings",
                newName: "IX_Bookings_BookingWindowId");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Tenants",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "LeasePeriods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CalenderId",
                table: "BookingWindows",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookingId",
                table: "BookingItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CalenderId",
                table: "BookingItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Calenders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowVersion = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calenders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyEmployee1",
                columns: table => new
                {
                    OwnedCompaniesId = table.Column<int>(type: "int", nullable: false),
                    OwnersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyEmployee1", x => new { x.OwnedCompaniesId, x.OwnersId });
                    table.ForeignKey(
                        name: "FK_CompanyEmployee1_Companies_OwnedCompaniesId",
                        column: x => x.OwnedCompaniesId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyEmployee1_Employees_OwnersId",
                        column: x => x.OwnersId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeaseProperty",
                columns: table => new
                {
                    LessesId = table.Column<int>(type: "int", nullable: false),
                    PropertiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaseProperty", x => new { x.LessesId, x.PropertiesId });
                    table.ForeignKey(
                        name: "FK_LeaseProperty_Leases_LessesId",
                        column: x => x.LessesId,
                        principalTable: "Leases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeaseProperty_Properties_PropertiesId",
                        column: x => x.PropertiesId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_PersonId",
                table: "Tenants",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PersonId",
                table: "Employees",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingWindows_CalenderId",
                table: "BookingWindows",
                column: "CalenderId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingItems_BookingId",
                table: "BookingItems",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingItems_CalenderId",
                table: "BookingItems",
                column: "CalenderId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyEmployee1_OwnersId",
                table: "CompanyEmployee1",
                column: "OwnersId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaseProperty_PropertiesId",
                table: "LeaseProperty",
                column: "PropertiesId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingItems_Bookings_BookingId",
                table: "BookingItems",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingItems_Calenders_CalenderId",
                table: "BookingItems",
                column: "CalenderId",
                principalTable: "Calenders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_BookingWindows_BookingWindowId",
                table: "Bookings",
                column: "BookingWindowId",
                principalTable: "BookingWindows",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingWindows_Calenders_CalenderId",
                table: "BookingWindows",
                column: "CalenderId",
                principalTable: "Calenders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_People_PersonId",
                table: "Employees",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeasePeriodTenant_LeasePeriods_LessePeriodsId",
                table: "LeasePeriodTenant",
                column: "LessePeriodsId",
                principalTable: "LeasePeriods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_People_PersonId",
                table: "Tenants",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id");
        }
    }
}
