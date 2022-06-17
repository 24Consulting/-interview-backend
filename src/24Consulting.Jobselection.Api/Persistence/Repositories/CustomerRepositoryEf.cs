using _24Consulting.JobSelection.Api.Domain.Models;
using _24Consulting.JobSelection.Api.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace _24Consulting.JobSelection.Api.Persistence.Repositories;

public class CustomerRepositoryEf : ICustomerRepository
{
    private readonly ApplicationContext _context;

    public CustomerRepositoryEf(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<CustomerModel>> GetCustomersAsync()
    {
        return await _context.Customers.ToListAsync();
    }

    public async Task<CustomerModel?> GetCustomerAsync(int customerId)
    {
        return await _context.Customers.FindAsync(customerId);
    }

    public async Task<int> AddCustomerAsync(CustomerModel customer)
    {
        _context.Customers.Add(customer);
        await _context.SaveChangesAsync();

        return customer.Id;
    }

    public Task UpdateCustomerAsync(CustomerModel customer)
    {
        throw new NotImplementedException();
    }

    public Task DeleteCustomerAsync(CustomerModel customer)
    {
        throw new NotImplementedException();
    }
}