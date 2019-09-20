
namespace ShopNo1.Web.Data
{
    using System.Linq;
    using Entities;
    using Microsoft.EntityFrameworkCore;

    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly DataContext context;

        public ProductRepository(DataContext context) : base(context)
        {
            this.context = context;
        }

        public IQueryable GetAllwithUsers()
        {
            return this.context.Products.Include(p => p.User);
        }
    }
}
