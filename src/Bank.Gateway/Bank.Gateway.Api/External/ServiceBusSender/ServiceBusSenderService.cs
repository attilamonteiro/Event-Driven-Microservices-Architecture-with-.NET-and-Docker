using Azure.Messaging.ServiceBus;
using System.Text.Json;

namespace Bank.Gateway.Api.External.ServiceBusSender
{
    public class ServiceBusSenderService
    {
        private readonly ServiceBusClient _client;
        private readonly string _topicName;
        public ServiceBusSenderService(IConfiguration _configuration)
        {
            _client = new ServiceBusClient(_configuration["SERVICEBUSCONSTR"]);
            _topicName = _configuration["SERVICEBUSTOPIC"];
        }
        public async Task Execute(object eventModel, string subscription)
        {
            await using var send = _client.CreateSender(_topicName);
            string messageBody = JsonSerializer.Serialize(eventModel);

            ServiceBusMessage message = new ServiceBusMessage(messageBody)
            {
              
            };
        }
    }
}
