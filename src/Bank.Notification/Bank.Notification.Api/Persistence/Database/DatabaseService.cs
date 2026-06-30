using Bank.Notification.Api.Domain.Entities.Notification;
using Bank.Notification.Api.Application.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Azure.Cosmos;

namespace Bank.Notification.Api.Persistence.Database
{
    public class DatabaseService: IDatabaseService
    {
        private readonly CosmosClient cosmosClient;
        private readonly Container container;
        public DbSet<NotificationEntity> Notifications {  get; set; }
        public DatabaseService(IConfiguration configuration)
        { 
            string connectionString = configuration["NOTIFICATIONDBCONTR"];
            string dataBase = configuration["NOTIFICATIONDBNAME"];
            string containerName = configuration["NOTIFICATIONDBCONTAINER"];
            cosmosClient = new CosmosClient(connectionString);
            container = cosmosClient.GetContainer(dataBase, containerName);
        }

    }
}
