using API.Models;
using API.Services.Classes;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

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

    private readonly IProductService? _productService;

    public ProductController(IProductService productService) => _productService = productService;

    /// <summary>
    /// Get product data
    /// </summary>
    /// <param name="idProduct"> product Id </param>
    /// <returns> product Id  </returns>
    [HttpGet("{idProduct}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<ProductModel>> GetProduct(int idProduct)
    {
        ProductModel product = await _productService.GetProduct(idProduct);
        return product;
        
    }

    /// <summary>
    /// Post product data
    /// </summary>
    [HttpPost]
    public async Task<ActionResult<ProductModel>> PostProduct(ProductModel idProduct) => await _productService.CreateProduct(idProduct);

    /// <summary>
    /// Put product data
    /// </summary>
    [HttpPut]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<ProductModel>> PutProduct(ProductModel idProduct) => await _productService.UpdateProduct(idProduct);

    /// <summary>
    /// Delete product data
    /// </summary>
    [HttpDelete("{idProduct}")]
    public async Task<ActionResult> DeleteProduct(int idProduct) 
    {
        await _productService.DeleteProduct(idProduct);

        return Ok("The value was removed");
    }
}
