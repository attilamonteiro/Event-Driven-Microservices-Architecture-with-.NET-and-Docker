using Bank.Transfer.Api.Domain.Entities.Transfer;
using Microsoft.EntityFrameworkCore;

namespace Bank.Transfer.Api.Application.Database
{
    public interface IDatabaseService
    {
        public DbSet<TransferEntity> Transfer { get; set; }
        public Task<bool> SaveAsync();
    }
}
