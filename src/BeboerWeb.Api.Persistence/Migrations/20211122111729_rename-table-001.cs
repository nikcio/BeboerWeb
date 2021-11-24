using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeboerWeb.Api.Persistence.Migrations
{
    public partial class renametable001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InternalMessageTenant");

            migrationBuilder.CreateTable(
                name: "TenantTenantToTenantMessage",
                columns: table => new
                {
                    ReceivedInternalMessagesId = table.Column<int>(type: "int", nullable: false),
                    ReceiversId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TenantTenantToTenantMessage", x => new { x.ReceivedInternalMessagesId, x.ReceiversId });
                    table.ForeignKey(
                        name: "FK_TenantTenantToTenantMessage_InternalMessages_ReceivedInternalMessagesId",
                        column: x => x.ReceivedInternalMessagesId,
                        principalTable: "InternalMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TenantTenantToTenantMessage_Tenants_ReceiversId",
                        column: x => x.ReceiversId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TenantTenantToTenantMessage_ReceiversId",
                table: "TenantTenantToTenantMessage",
                column: "ReceiversId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TenantTenantToTenantMessage");

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

            migrationBuilder.CreateIndex(
                name: "IX_InternalMessageTenant_ReceiversId",
                table: "InternalMessageTenant",
                column: "ReceiversId");
        }
    }
}
