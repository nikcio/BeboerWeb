namespace BeboerWeb.Api.Models.DTOs.Documents
{
    public class DocumentDto
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
