using Bank.Balance.Api.Domain.Entities.Balance;
using Microsoft.EntityFrameworkCore;

namespace Bank.Transaction.Api.Application.Database
{
    public interface IDatabaseService
    {
        public DbSet<BalanceEntity> Balance { get; set; }
        public Task<bool> SaveAsync();
    }
}
