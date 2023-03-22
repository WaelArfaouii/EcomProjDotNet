using EcomDotNet.Entities.Product;
using Infrastructure.Data;
using Infrastructure.Data.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories.Impl ;

public class ProductBrandRepository:IProductBrandRepository
{
    private readonly DataContext _context;

    public ProductBrandRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<ProductBrand> getProductBrandById(long id)
    {
        return await _context.ProductBrands.FindAsync(id) ;
    }

    public async Task<IReadOnlyList<ProductBrand>> getProductBrands()
    {
        var productBrands =await  _context.ProductBrands.ToListAsync() ;
        return productBrands ;
    }
}