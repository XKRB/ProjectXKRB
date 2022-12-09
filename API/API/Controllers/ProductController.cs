using API.Context.Context;
using API.General.Classes;
using API.General.InputOutputStructures.Products;
using API.Services.Classes;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.Extensions.Localization;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.Controllers;

/// <summary>
/// Products controllers
/// </summary>
[Route("/products")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    private readonly ProductContext _context;

    public ProductController(IStringLocalizer<ProductController> localizer, IProductService productService) => _productService = productService;

    /// <summary>
    /// Get product data
    /// </summary>

    [HttpGet]
    public async Task<ActionResult<GetProductOutput>> GetProduct(int idProduct)
    {
        try
        {
            ProductService productService = await _productService.GetProduct(idProduct);
        }
        catch (Exception ax) 
        {
            return BadRequest(new Request { IdMessage = 31, Message = "Id incorrect" });
        }
    }
    //public ActionResult<GetProductOutput>? GetProductItem(int idProduct)
    //{
    //    ProductService productService = await _context.Products.FindAsync(idProduct);

    //    if (productService == null)
    //    {
    //        return NotFound();
    //    }
    //    return productService;
    //}


    //return getActionResult(_productService.IGetProduct(idProduct));

    //null;

    /// <summary>
    /// Post product data
    /// </summary>
    [HttpPost]
    public ActionResult<ProductService>? PostProductItem(ProductService productService)
    {

        //_context.ProductService.Add(productService);
        //_ = await _context.SaveChangesAsync();

        //return CreatedAtAction(nameof(GetProductItem), new { id = ProductService.Id }, productService);
        return null;
    }

    /// <summary>
    /// Put product data
    /// </summary>
    [HttpPut]
    public IActionResult? PutProductItem(int id) =>
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
        null;

    private bool ProductExists(int id) =>
        //return _context.ProductItems.Any(x => x.Id == id);
        true;

    /// <summary>
    /// Delete product data
    /// </summary>
    [HttpDelete("{id}")]
    public IActionResult? DeleteProductItem(int id) =>
        //var productItem = await _context.ProductItems.FindAsync(id);
        //if (productItem == null)
        //{
        //    return NotFound();
        //}
        //_context.ProductItems.Remove(productItem);
        //await _context.SaveChangesAsync();

        //return NoContent();

        null;
}
