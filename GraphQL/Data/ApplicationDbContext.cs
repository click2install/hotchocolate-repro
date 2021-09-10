using Microsoft.EntityFrameworkCore;

namespace ConferencePlanner.GraphQL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Session> Sessions { get; set; } = default!;

        public DbSet<Track> Tracks { get; set; } = default!;
    }
}