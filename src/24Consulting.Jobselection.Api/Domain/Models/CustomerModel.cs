namespace _24Consulting.JobSelection.Api.Domain.Models;

// https://stackoverflow.com/questions/70068796/deal-with-in-net-6s-nullable-and-entity-framework-entities
public class CustomerModel
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string CompanyVat { get; set; } = null!;

    public string? CompanyName { get; set; }
}