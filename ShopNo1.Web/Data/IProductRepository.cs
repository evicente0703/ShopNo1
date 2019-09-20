
namespace ShopNo1.Web.Data
{
    using Entities;
    using System.Linq;

    public interface IProductRepository : IGenericRepository<Product>
    {
        //
        IQueryable GetAllwithUsers();
    }
}
