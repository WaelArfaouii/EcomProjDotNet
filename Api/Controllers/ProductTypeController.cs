using Infrastructure.Data;
using EcomDotNet.Entities.Product;
using Infrastructure.Data.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/products/types")]
    public class ProductTypeController : ControllerBase
    {   
        private readonly IProductTypeRepository _repo ;

        public ProductTypeController(IProductTypeRepository prod)
        {
            _repo = prod;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductType>>> getProducts(){
            var products = await _repo.getProductTypes() ;
            return Ok(products) ;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductType>> getProduct(long id){
            
            var product = await _repo.getProductTypeById(id) ;
            return Ok(product) ;
        } 
    }
}