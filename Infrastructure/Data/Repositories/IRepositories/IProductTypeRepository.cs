using EcomDotNet.Entities.Product;

namespace Infrastructure.Data.Repositories.IRepositories;

public interface IProductTypeRepository
{
    Task<ProductType> getProductTypeById(long id);
    Task<IReadOnlyList<ProductType>> getProductTypes();
}