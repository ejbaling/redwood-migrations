using Microsoft.EntityFrameworkCore;
using RedwoodIloilo.Common.Entities;

namespace Redwoodiloilo.Migrations
{
    public class RedwoodiloiloContext : DbContext
    {
        public RedwoodiloiloContext(DbContextOptions<RedwoodiloiloContext> options)
            : base(options) { }

        public DbSet<GuestMessage> GuestMessages { get; set; }
        public DbSet<GuestResponse> GuestResponses { get; set; }
        public DbSet<Config> Configs { get; set; }

        public DbSet<RuleCategory> RuleCategories { get; set; }

        public DbSet<Rule> Rules { get; set; }
    }
}

// dotnet ef migrations add AddGuestResponse
// dotnet ef database update
