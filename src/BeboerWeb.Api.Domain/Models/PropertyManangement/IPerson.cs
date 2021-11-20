namespace BeboerWeb.Api.Domain.Models.PropertyManangement
{
    public interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }
        string Phone { get; set; }
        byte[] RowVersion { get; set; }
    }
}