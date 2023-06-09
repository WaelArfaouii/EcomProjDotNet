using EcomDotNet.Entities.Product;
using Infrastructure.Data.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories.Impl
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context ;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }
    

        async Task<Product> IProductRepository.getProductByIdAsync(long id)
        {
            return await _context.Products
                .Include(p => p.productBrand)
                .Include(p => p.productType)
                .SingleOrDefaultAsync(p => p.Id == id);

        }

        async Task<IReadOnlyList<Product>> IProductRepository.getProductsAsync()
        {
            var products =await  _context.Products
                .Include(p=> p.productBrand)
                .Include(p=> p.productType)
                .ToListAsync() ;
            return products ;
        }
    }
}