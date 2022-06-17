using System.ComponentModel.DataAnnotations;

namespace _24Consulting.JobSelection.Api.Features.Customer.Request;

public class CustomerRequest
{
    [Required]
    public string FirstName { get; set; } = null!;

    [Required]
    public string LastName { get; set; } = null!;

    [Required]
    public string CompanyVat { get; set; } = null!;

    public string? CompanyName { get; set; }
}