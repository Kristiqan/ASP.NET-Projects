using DataSkeleton.Data;
using Microsoft.EntityFrameworkCore;

namespace DataSkeleton.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options)
       {
            
       }
        public DbSet<Cars> Cars { get; set; }
    }
}
