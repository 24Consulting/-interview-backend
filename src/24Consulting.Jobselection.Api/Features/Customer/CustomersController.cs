using _24Consulting.JobSelection.Api.Domain.Models;
using _24Consulting.JobSelection.Api.Domain.Repositories;
using _24Consulting.JobSelection.Api.Features.Customer.Request;
using Microsoft.AspNetCore.Mvc;

namespace _24Consulting.JobSelection.Api.Features.Customer;

[Route("customers")]
[ApiController]
public class CustomersController : ControllerBase
{
    private readonly ICustomerRepository _customerRepository;

    public CustomersController(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    [HttpGet]
    public Task<IEnumerable<CustomerModel>> GetCustomersAsync() => _customerRepository.GetCustomersAsync();

}