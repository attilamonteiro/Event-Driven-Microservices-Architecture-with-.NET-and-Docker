using Bank.Transaction.Api.Persistence.Database;
using Bank.Transfer.Api.Application.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

builder.Services.AddDbContext<DatabaseService>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("TRANSACTIONSQLDBCONSTR"));
});

builder.Services.AddScoped<IDatabaseService, DatabaseService>();

app.MapGet("/transfer", async ([FromServices] IDatabaseService _databaseService) =>
{
    var data = await _databaseService.Transfer.ToListAsync();
    return data;
});

app.Run();