using Bank.Transaction.Api.Domain.Entities.Transaction;
using Microsoft.EntityFrameworkCore;

namespace Bank.Transaction.Api.Application.Database
{
    public interface IDatabaseService
    {
        public DbSet<TransactionEntity> Transaction { get; set; }
        public Task<bool> SaveAsync();
    }
}
