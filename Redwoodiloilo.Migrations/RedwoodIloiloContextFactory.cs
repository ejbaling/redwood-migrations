using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Redwoodiloilo.Migrations
{
    public class RedwoodiloiloContextFactory : IDesignTimeDbContextFactory<RedwoodiloiloContext>
    {
        public RedwoodiloiloContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<RedwoodiloiloContext>();
            optionsBuilder.UseNpgsql("Host=webhook.tailc2bda.ts.net;Port=5432;Database=redwoodiloilo;Username=admin;Password=R!QaX4ybyvzS5R");

            return new RedwoodiloiloContext(optionsBuilder.Options);
        }
    }
}

