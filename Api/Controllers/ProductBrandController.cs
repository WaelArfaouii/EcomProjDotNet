using EcomDotNet.Entities.Product;
using Infrastructure.Data.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/products/brands")]
    public class ProductBrandController : ControllerBase
    {   
        private readonly IProductBrandRepository _repo ;

        public ProductBrandController(IProductBrandRepository prod)
        {
            _repo = prod;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductBrand>>> getProductBrands(){
            var products = await _repo.getProductBrands() ;
            return Ok(products) ;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductBrand>> getProduct(long id){
            
            var product = await _repo.getProductBrandById(id) ;
            return Ok(product) ;
        } 
    }
}