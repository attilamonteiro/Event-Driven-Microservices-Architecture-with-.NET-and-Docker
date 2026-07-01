using Bank.Notification.Api.Application.Database;
using Bank.Notification.Api.Domain.Entities.Notification;
using Bank.Notification.Api.Persistence.Database;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IDatabaseService, DatabaseService>();
var app = builder.Build();

app.MapGet("/notification", async ([FromServices] IDatabaseService databaseService) =>
{
    var entity = new NotificationEntity
    {
        CorrelationId = Guid.NewGuid().ToString(),
        Content = "mensaje de prueba",
        TransactionState = true,
        Type = "email",
        CustomerId = 1
    };
    await databaseService.AddAsync(entity);
    var data = await databaseService.GetAllAsync();
    return data;
});

app.Run();