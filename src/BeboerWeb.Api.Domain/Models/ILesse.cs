namespace BeboerWeb.Api.Domain.Models
{
    public interface ILesse
    {
        string Apartment { get; set; }
        int Id { get; set; }
        System.Collections.Generic.IEnumerable<ILessePeriod> LessePeriods { get; set; }
        System.Collections.Generic.IEnumerable<IProperty> Properties { get; set; }
        int Story { get; set; }
    }
}