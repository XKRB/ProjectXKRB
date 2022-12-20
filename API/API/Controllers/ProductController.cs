using API.General.Classes;
using API.General.Classes.Configure;
using API.Models;
using API.Services.Classes;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using System.Net;

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
        try
        {
            ProductModel product = await _productService.GetProduct(idProduct);
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
    public async Task<ActionResult<ProductModel>> PostProduct(ProductModel idProduct)
    {
        try
        {
            ProductModel product = await _productService.CreateProduct(idProduct);
            return Ok(product);
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
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<ProductModel>> PutProduct(ProductModel idProduct)
    {
        try
        {
            ProductModel product = await _productService.UpdateProduct(idProduct);
            return Ok(product);
        }
        catch (ExceptionClass ex)
        {
            return BadRequest(ex.Message);
        }
    }
   

    /// <summary>
    /// Delete product data
    /// </summary>
    [HttpDelete("{idProduct}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult> DeleteProduct(int idProduct) 
    {
        try
        {
            await _productService.DeleteProduct(idProduct);
            return Ok("the product was deleted");
        }
        catch (ExceptionClass ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
