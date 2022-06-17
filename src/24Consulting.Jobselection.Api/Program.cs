using _24Consulting.JobSelection.Api.Domain.Repositories;
using _24Consulting.JobSelection.Api.Persistence;
using _24Consulting.JobSelection.Api.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();

// Add swagger
builder.Services.AddSwaggerGen();

// Add controllers
builder.Services.AddControllers();

// Add Db context
builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Register repository
builder.Services.AddScoped<ICustomerRepository, CustomerRepositoryEf>();

// Build application
var app = builder.Build();

// Use swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Use routing
app.UseRouting();

// Use controllers endpoint
app.UseEndpoints(endpoints => endpoints.MapControllers());

// Run app
app.Run();