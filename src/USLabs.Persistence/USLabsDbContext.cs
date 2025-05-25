using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace USLabs.Persistence
{
    public class USLabsDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=LocalDatabase.db")
            .LogTo(
                Console.WriteLine,
                new [] {DbLoggerCategory.Database.Command.Name},
                LogLevel.Information
            ).EnableSensitiveDataLogging();
        }
    }
}