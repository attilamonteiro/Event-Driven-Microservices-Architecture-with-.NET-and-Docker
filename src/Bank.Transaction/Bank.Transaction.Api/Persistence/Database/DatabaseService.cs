using Microsoft.EntityFrameworkCore;

namespace Bank.Transaction.Api.Persistence.Database
{
    public class DatabaseService: DbContext
    {
        public DatabaseService(DbContextOptions options) : base(options) 
        { 
        }

    }
}
