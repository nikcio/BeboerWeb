using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeboerWeb.Api.Persistence.Migrations
{
    public partial class fixspellinglesse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable("LessePeriodTenant", newName: "LeasePeriodTenant");
            migrationBuilder.RenameTable("LesseProperty", newName: "LeaseProperty");
            migrationBuilder.RenameTable("LessePeriods", newName: "LeasePeriods");
            migrationBuilder.RenameTable("Lesses", newName: "Leases");
            migrationBuilder.RenameIndex("IX_LessePeriods_LesseId", "IX_LeasePeriods_LeaseId", "LeasePeriods");
            migrationBuilder.RenameIndex("IX_LessePeriodTenant_TenantsId", "IX_LeasePeriodTenant_TenantsId", "LeasePeriodTenant");
            migrationBuilder.RenameIndex("IX_LesseProperty_PropertiesId", "IX_LeaseProperty_PropertiesId", "LeaseProperty");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable("LeasePeriodTenant", newName: "LessePeriodTenant");
            migrationBuilder.RenameTable("LeaseProperty", newName: "LesseProperty");
            migrationBuilder.RenameTable("LeasePeriods", newName: "LessePeriods");
            migrationBuilder.RenameTable("Leases", newName: "Lesses");
            migrationBuilder.RenameIndex("IX_LeasePeriods_LeaseId", "IX_LessePeriods_LesseId", "LeasePeriods");
            migrationBuilder.RenameIndex("IX_LeasePeriodTenant_TenantsId", "IX_LessePeriodTenant_TenantsId", "LeasePeriodTenant");
            migrationBuilder.RenameIndex("IX_LeaseProperty_PropertiesId", "IX_LesseProperty_PropertiesId", "LeaseProperty");
        }
    }
}
