using EcomDotNet.Entities.Product;

namespace Infrastructure.Data.Repositories.IRepositories
{
    public interface IProductRepository
    {
        Task<Product> getProductByIdAsync(long id) ;
        Task<IReadOnlyList<Product>> getProductsAsync() ;
    }
}