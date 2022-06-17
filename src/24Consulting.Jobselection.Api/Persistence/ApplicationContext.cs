using _24Consulting.JobSelection.Api.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace _24Consulting.JobSelection.Api.Persistence;

public sealed class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
        if (Database.GetPendingMigrations().Any())
            Database.Migrate();
    }

    public DbSet<CustomerModel> Customers => Set<CustomerModel>();
}