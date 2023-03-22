using EcomDotNet.Entities.Product;
using Infrastructure.Data.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories.Impl;

public class ProductTypeRepository:IProductTypeRepository
{
    private readonly DataContext _context ;

    public ProductTypeRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<ProductType> getProductTypeById(long id)
    {
        return await _context.ProductTypes.FindAsync(id) ;
    }

    public async Task<IReadOnlyList<ProductType>> getProductTypes()
    {
        var productTypes =await  _context.ProductTypes.ToListAsync() ;
        return productTypes ;
    }
}