using Bank.Transaction.Api.Application.Database;
using Bank.Transaction.Api.Persistence.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DatabaseService>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("BALANCESQLDBCONSTR"));
});
builder.Services.AddScoped<IDatabaseService, DatabaseService>();

var app = builder.Build();

app.MapGet("/balance", async ([FromServices] IDatabaseService _databaseServices) =>
{
    var data = await _databaseServices.Balance.ToListAsync();
    return data;
});

app.Run();