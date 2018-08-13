using Microsoft.EntityFrameworkCore;

namespace WineTableMaint.Models
{
    public class WineContext : DbContext
    {
        public WineContext(DbContextOptions<WineContext> options)
            : base(options)
        {
        }

        public DbSet<Climate> Climate { get; set; }
    }
}
