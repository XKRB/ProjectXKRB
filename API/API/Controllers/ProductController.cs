using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using API.Context;
using API.Services.Clases;

// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.Controllers
{
    /// <summary>
    /// Products controllers
    /// </summary>
    [Route("/Products")]
    [ApiController]
    public class ProductController:ControllerBase
    {
        private readonly ProductContext _context;

        public ProductController(ProductContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get product data
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<ProductItem>> GetProductItem(int id)
        {
            var productItem = await _context.ProductItems.FindAsync(id);

            if (productItem == null)
            {
                return NotFound();
            }
            return productItem;
        }

        /// <summary>
        /// Post product data
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<ProductItem>> PostProductItem(ProductItem productItem)
        {

            _context.ProductItems.Add(productItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProductItem), new { id = productItem.Id }, productItem);
        }

        /// <summary>
        /// Put product data
        /// </summary>
        [HttpPut]
        public async Task<IActionResult> PutProductItem(int id,ProductItem productItem)
        {
            if (id != productItem.Id)
            {
                return BadRequest();    
            }

            _context.Entry(productItem).State= EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            //return NoContent();
            return CreatedAtAction(nameof(GetProductItem), new { id = productItem.Id }, productItem);

        }

        
        private bool ProductExists(int id)
        {
            return _context.ProductItems.Any(x => x.Id == id);
        }

        /// <summary>
        /// Delete product data
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductItem(int id)
        {
            var productItem = await _context.ProductItems.FindAsync(id);
            if (productItem == null)
            {
                return NotFound();
            }
            _context.ProductItems.Remove(productItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
