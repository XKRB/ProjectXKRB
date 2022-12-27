using API.General.Classes.Configure;
using API.Models;
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
    /// <param name="GetProduct"> product Id </param>
    /// <returns> product Id  </returns>
    [HttpGet("{GetProduct}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<ProductModel>> GetProduct(int GetProduct)
    {
        try
        {
            ProductModel product = await _productService.GetProduct(GetProduct);
            return Ok(product);
        }
        catch (ExceptionClass ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Post product data
    /// </summary>
    [HttpPost]
    public async Task<ActionResult<ProductModel>> PostProduct(ProductModel PostProduct)
    {
        try
        {
            await _productService.CreateProduct(PostProduct);
            return Ok(PostProduct);
        }
        catch (ExceptionClass ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Put product data
    /// </summary>
    [HttpPut]
    public async Task<ActionResult<ProductModel>> PutProduct(ProductModel PutProduct)
    {
        try
        {

            return Ok(await _productService.UpdateProduct(PutProduct));
        }
        catch (ExceptionClass ex)
        {
            //return BadRequest(ex.Message);
            return BadRequest("Product does not exist, you can´t modify");
        }
    }


    /// <summary>
    /// Delete product data
    /// </summary>
    [HttpDelete("{DeleteProduct}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult> DeleteProduct(int DeleteProduct)
    {
        try
        {
            await _productService.DeleteProduct(DeleteProduct);
            return Ok("The product was deleted");
        }
        catch (ExceptionClass ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
