using Bank.Notification.Api.Domain.Entities.Notification;
using Microsoft.EntityFrameworkCore;

namespace Bank.Notification.Api.Application.Database
{
    public interface IDatabaseService
    {
        public DbSet<NotificationEntity> Notifications { get; set; }
    }
}
