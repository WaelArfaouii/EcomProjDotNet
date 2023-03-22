using EcomDotNet.Entities.Product;

namespace Infrastructure.Data.Repositories.IRepositories;

public interface IProductBrandRepository
{
    Task<ProductBrand> getProductBrandById(long id);
    Task<IReadOnlyList<ProductBrand>> getProductBrands();
}