using Infrastructure.Data;
using EcomDotNet.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcomDotNet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly DataContext _context ;

        public ProductsController(DataContext context)
        {   
                _context = context ;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> getProducts(){
            var products =await  _context.Products.ToListAsync() ;
            return Ok(products) ;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> getProduct(long id){
            return await _context.Products.FindAsync(id) ;
        } 
    }
}