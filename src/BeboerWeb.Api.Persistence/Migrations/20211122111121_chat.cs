using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace BeboerWeb.Api.Persistence.Migrations
{
    public partial class chat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeToTenantMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderId = table.Column<int>(type: "int", nullable: true),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageText = table.Column<string>(type: "nvarchar(1200)", maxLength: 1200, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeToTenantMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeToTenantMessages_Employees_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InternalMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderId = table.Column<int>(type: "int", nullable: true),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageText = table.Column<string>(type: "nvarchar(1200)", maxLength: 1200, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternalMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InternalMessages_Tenants_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Tenants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TenantToEmployeeMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderId = table.Column<int>(type: "int", nullable: true),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageText = table.Column<string>(type: "nvarchar(1200)", maxLength: 1200, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TenantToEmployeeMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TenantToEmployeeMessages_Tenants_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Tenants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeToTenantMessageTenant",
                columns: table => new
                {
                    EmployeeToTenantMessagesId = table.Column<int>(type: "int", nullable: false),
                    ReceiversId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeToTenantMessageTenant", x => new { x.EmployeeToTenantMessagesId, x.ReceiversId });
                    table.ForeignKey(
                        name: "FK_EmployeeToTenantMessageTenant_EmployeeToTenantMessages_EmployeeToTenantMessagesId",
                        column: x => x.EmployeeToTenantMessagesId,
                        principalTable: "EmployeeToTenantMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeToTenantMessageTenant_Tenants_ReceiversId",
                        column: x => x.ReceiversId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InternalMessageTenant",
                columns: table => new
                {
                    ReceivedInternalMessagesId = table.Column<int>(type: "int", nullable: false),
                    ReceiversId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternalMessageTenant", x => new { x.ReceivedInternalMessagesId, x.ReceiversId });
                    table.ForeignKey(
                        name: "FK_InternalMessageTenant_InternalMessages_ReceivedInternalMessagesId",
                        column: x => x.ReceivedInternalMessagesId,
                        principalTable: "InternalMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InternalMessageTenant_Tenants_ReceiversId",
                        column: x => x.ReceiversId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTenantToEmployeeMessage",
                columns: table => new
                {
                    ReceiversId = table.Column<int>(type: "int", nullable: false),
                    TenantToEmployeeMessagesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTenantToEmployeeMessage", x => new { x.ReceiversId, x.TenantToEmployeeMessagesId });
                    table.ForeignKey(
                        name: "FK_EmployeeTenantToEmployeeMessage_Employees_ReceiversId",
                        column: x => x.ReceiversId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeTenantToEmployeeMessage_TenantToEmployeeMessages_TenantToEmployeeMessagesId",
                        column: x => x.TenantToEmployeeMessagesId,
                        principalTable: "TenantToEmployeeMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTenantToEmployeeMessage_TenantToEmployeeMessagesId",
                table: "EmployeeTenantToEmployeeMessage",
                column: "TenantToEmployeeMessagesId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeToTenantMessages_SenderId",
                table: "EmployeeToTenantMessages",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeToTenantMessageTenant_ReceiversId",
                table: "EmployeeToTenantMessageTenant",
                column: "ReceiversId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalMessages_SenderId",
                table: "InternalMessages",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalMessageTenant_ReceiversId",
                table: "InternalMessageTenant",
                column: "ReceiversId");

            migrationBuilder.CreateIndex(
                name: "IX_TenantToEmployeeMessages_SenderId",
                table: "TenantToEmployeeMessages",
                column: "SenderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeTenantToEmployeeMessage");

            migrationBuilder.DropTable(
                name: "EmployeeToTenantMessageTenant");

            migrationBuilder.DropTable(
                name: "InternalMessageTenant");

            migrationBuilder.DropTable(
                name: "TenantToEmployeeMessages");

            migrationBuilder.DropTable(
                name: "EmployeeToTenantMessages");

            migrationBuilder.DropTable(
                name: "InternalMessages");
        }
    }
}
