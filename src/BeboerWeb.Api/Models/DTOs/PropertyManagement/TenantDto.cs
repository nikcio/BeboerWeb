namespace BeboerWeb.Api.Models.DTOs.PropertyManagement
{
    public class TenantDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Phone { get; set; }

        public double Balance { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
