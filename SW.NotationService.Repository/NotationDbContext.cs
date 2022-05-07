namespace SW.NotationService.Repository
{
    using Microsoft.EntityFrameworkCore;
    using SW.NotationService.Repository.Models;

    public class NotationDbContext : DbContext
    {
        public NotationDbContext(DbContextOptions<NotationDbContext> contextOptions)
            : base(contextOptions)
        {
        }

        public DbSet<NotationDb> Notations { get; set; }
    }
}
