using Microsoft.EntityFrameworkCore;

namespace Gone.Database
{
    public class GoneContext: DbContext
    {
        public GoneContext(DbContextOptions<GoneContext> options): base(options)
        {

        }


        public DbSet <User> Users { get; set; }
    }
}
