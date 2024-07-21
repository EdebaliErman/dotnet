using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductApi.Models;

namespace ProductApi.Controllers
{
    [ApiController]//* Controller sınıfını tanımladık
    [Route("api/[controller]")]//* Kontrolerı tanımladık
    public class ProductController : ControllerBase
    {

        private readonly ProductContext _context;
        public ProductController(ProductContext context)
        {
            _context = context;
        }

        //TODO: Burada Actionlar tanımlanır
        //* Get https://localhost:7198/api/product => GET İsteği
        [HttpGet]
        public async Task<IActionResult> GetProducts() //productları liste halinde döndük
        {
            var products = await _context.Products.ToListAsync();
         
            return Ok(products);
        }

        //* Get https://localhost:7198/api/product/1 => GET İsteği {id} 'yi parametre olarak alır  
        [HttpGet("{id}")] //! Eşleştirilicek method burası 
        public async Task<IActionResult> GetProductId(int? id) //Product'ın id'sini döndürür ve null değer olabilir 
        {
            if (id == null)
            {
                return NotFound();
            }

            var p = await _context.Products.FirstOrDefaultAsync(x => x.ProductId == id); // product listesinden id ile eşleşen productı döndürür
            if (p == null)
            {
                return NotFound();
            }
            return Ok(p);
        }
         
         //* POST http://localhost:7198/api/product => POST İsteği
        [HttpPost]
        public async Task<IActionResult> AddProduct(Product entity)
        {
            _context.Products.Add(entity);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProductId), new { id = entity.ProductId }, entity);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int? id, Product entity)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (id != entity.ProductId)
            {
                return BadRequest();
            }
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }
       
    }
}
