using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using EcomDotNet.Entities.Product;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context ;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Product> getProductByIdAsync(long id)
        {
            return await _context.Products.FindAsync(id) ;
        }

        public async Task<IReadOnlyList<Product>> getProductsAsync()
        {
            
            var products =await  _context.Products.ToListAsync() ;
            return products ;
        }
    }
}