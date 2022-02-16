namespace FlowerShopProject.DataAccess
{
    using FlowerShopProject.Data;
    using Microsoft.EntityFrameworkCore;


    public class FlowerShopDbContext : DbContext
    {
        
        public FlowerShopDbContext(DbContextOptions<FlowerShopDbContext> options) : base(options)
        {

        }
        
        
        
        
        
        public DbSet<Flower> Flowers { get; set; }

        
    }
}
