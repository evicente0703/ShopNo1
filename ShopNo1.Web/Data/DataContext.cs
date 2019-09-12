using Microsoft.EntityFrameworkCore;
using ShopNo1.Web.Data.Entities;


namespace ShopNo1.Web.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

    }
}
