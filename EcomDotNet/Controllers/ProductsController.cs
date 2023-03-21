using Infrastructure.Data;
using EcomDotNet.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Interfaces;

namespace EcomDotNet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {   
        private readonly IProductRepository _repo ;

        public ProductsController(IProductRepository productRepository)
        {
            _repo = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> getProducts(){
            var products = await _repo.getProductsAsync() ;
            return Ok(products) ;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> getProduct(long id){
            
            var product = await _repo.getProductByIdAsync(id) ;
            return Ok(product) ;
        } 
    }
}