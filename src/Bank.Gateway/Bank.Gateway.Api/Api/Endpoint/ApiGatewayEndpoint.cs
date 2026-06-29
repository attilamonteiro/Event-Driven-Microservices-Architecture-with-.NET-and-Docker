using Microsoft.AspNetCore.Mvc;
using Bank.Gateway.Api.Application.Models;

namespace Bank.Gateway.Api.Api.Endpoint
{
    public class ApiGatewayEndpoint
    {
        public static void GatewayEndpoint(WebApplication app)
        {
            app.MapPost("/api-gateway", ([FromBody] EndPointModel modelRequest) =>
            {
                return modelRequest;
            });
        }
    }
}
