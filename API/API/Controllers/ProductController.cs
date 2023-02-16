using API.General.Classes;
using API.Models;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.Controllers;

/// <summary>
/// Products controllers
/// </summary>
[Route("/products")]
[ApiController]
public class ProductController : BaseController
{
    /// <summary>
    /// Manage product busines logic
    /// </summary>
    private readonly IProductService _productService;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="productService"></param>
    public ProductController(IProductService productService, IStringLocalizer<BaseController> localizer) : base(localizer) => _productService = productService;
    
    /// <summary>
    /// Get product data
    /// </summary>
    /// <param name="idProduct"> product Id </param>
    /// <returns> product </returns>
    [HttpGet("{idProduct}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductModel))]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<ProductModel>> GetProduct(int idProduct)
    {
        try
        {
            ProductModel product = await _productService.GetProduct(idProduct);
            return Ok(product);
        }
        catch (APIException)
        {
            return BadRequest(new Request(1).GetActionResult());
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    /// <summary>
    /// Post product data
    /// </summary>
    /// <param name="Product"> product </param>
    /// <returns> product </returns>
    [HttpPost("{idProduct}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductModel))]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<ProductModel>> PostProduct(int idProduct, [FromBody] ProductModelInput product)
    {
        try
        {
            return Ok(await _productService.CreateProduct(new ProductModel(idProduct, product.ProductName, product.ProductPrice)));
        }
        catch (APIException)
        {
            return BadRequest(new Request(2).GetActionResult());
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    /// <summary>
    /// Put product data
    /// </summary>
    /// <param name="product"> product </param>
    /// <returns> product </returns>
    [HttpPut("{idProduct}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductModel))]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<ProductModel>> PutProduct(int idProduct, [FromBody] ProductModelInput product)
    {
        try
        {
            return Ok(await _productService.UpdateProduct(new ProductModel(idProduct, product.ProductName, product.ProductPrice)));
        }
        catch (APIException)
        {
            //return BadRequest(ex.Message);
            return BadRequest(new Request(3).GetActionResult());
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    /// <summary>
    /// Delete product data
    /// </summary>
    /// <param name="idProduct"> product Id</param>
    /// <returns> task </returns>
    [HttpDelete("{idProduct}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> DeleteProduct(int idProduct)
    {
        try
        {
            await _productService.DeleteProduct(idProduct);
            //return Ok(ProductConstants.ProductDeleted);
            return Ok(new Request(5).GetActionResult());
        }
        catch (APIException)
        {
            return BadRequest(new Request(4).GetActionResult());
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
