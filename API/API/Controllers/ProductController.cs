using API.Context.Context;
using API.Services.Clases;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.Controllers
{
    /// <summary>
    /// Products controllers
    /// </summary>
    [Route("/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        private readonly ProductContext _context;


        /// <summary>
        /// Get product data
        /// </summary>

        [HttpGet]
        public async Task<ActionResult<ProductService>> GetProductItem(int id)
        {
            //ProductService productService = await _context.Products.FindAsync(id);

            //if (productService == null)
            //{
            //    return NotFound();
            //}
            //return productService;

            return null;
        }

        /// <summary>
        /// Post product data
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<ProductService>> PostProductItem(ProductService productService)
        {

            //_context.ProductService.Add(productService);
            //await _context.SaveChangesAsync();

            //return CreatedAtAction(nameof(GetProductItem), new { id = ProductService.Id }, productService);
            return null;
        }

        /// <summary>
        /// Put product data
        /// </summary>
        [HttpPut]
        public async Task<IActionResult> PutProductItem(int id)
        {
            //if (id != productItem.Id)
            //{
            //    return BadRequest();    
            //}

            //_context.Entry(productItem).State= EntityState.Modified;

            //try
            //{
            //    await _context.SaveChangesAsync();
            //}
            //catch(DbUpdateConcurrencyException)
            //{
            //    if (!ProductExists(id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}
            ////return NoContent();
            //return CreatedAtAction(nameof(GetProductItem), new { id = productItem.Id }, productItem);
            return null;


        }


        private bool ProductExists(int id)
        {
            //return _context.ProductItems.Any(x => x.Id == id);
            return true;
        }

        /// <summary>
        /// Delete product data
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductItem(int id)
        {
            //var productItem = await _context.ProductItems.FindAsync(id);
            //if (productItem == null)
            //{
            //    return NotFound();
            //}
            //_context.ProductItems.Remove(productItem);
            //await _context.SaveChangesAsync();

            //return NoContent();

            return null;
        }
    }
}
