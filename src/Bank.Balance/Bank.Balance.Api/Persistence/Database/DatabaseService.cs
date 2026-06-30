using Bank.Balance.Api.Domain.Entities.Balance;
using Bank.Transaction.Api.Application.Database;
using Microsoft.EntityFrameworkCore;

namespace Bank.Transaction.Api.Persistence.Database
{
    public class DatabaseService: DbContext, IDatabaseService
    {
        public DatabaseService(DbContextOptions options) : base(options) 
        { 
        }
        public DbSet<BalanceEntity> Balance {  get; set; }
        public async Task<bool> SaveAsync()
        {
            return await base.SaveChangesAsync() > 0;

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
}
}
