using _24Consulting.JobSelection.Api.Domain.Models;

namespace _24Consulting.JobSelection.Api.Domain.Repositories;

public interface ICustomerRepository
{
    public Task<IEnumerable<CustomerModel>> GetCustomersAsync();

    public Task<CustomerModel?> GetCustomerAsync(int customerId);

    public Task<int> AddCustomerAsync(CustomerModel customer);

    public Task UpdateCustomerAsync(CustomerModel customer);

    public Task DeleteCustomerAsync(CustomerModel customer);
}