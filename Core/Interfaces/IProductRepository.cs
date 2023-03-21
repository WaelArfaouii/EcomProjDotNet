using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcomDotNet.Entities.Product;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> getProductByIdAsync(long id) ;
        Task<IReadOnlyList<Product>> getProductsAsync() ;
    }
}