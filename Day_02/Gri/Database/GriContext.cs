using Microsoft.EntityFrameworkCore;

namespace Gri.Database
{
    public class GriContext: DbContext //Microsoft.EntityFrameworkCore
    {
        public GriContext(DbContextOptions<GriContext> options): base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}
