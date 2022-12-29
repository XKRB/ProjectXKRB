using API.General.Classes.Configure;
using API.Models;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.OpenApi.Writers;

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
    /// <summary>
    /// Manage product busines logic
    /// </summary>
    private readonly IProductService _productService;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="productService"></param>
    public ProductController(IProductService productService) => _productService = productService;

    /// <summary>
    /// Get product data
    /// </summary>
    /// <param name="idProduct"> product Id </param>
    /// <returns> product Id, product name and product price </returns>
    [HttpGet("{idProduct}")]
    //[ProducesResponseType(StatusCodes.Status200OK)]
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
    /// <param name="CreateProduct"> product Id, product name and product price</param>
    /// <returns> product Id, product name and product price </returns>
    [HttpPost]
    public async Task<ActionResult<ProductModel>> PostProduct(ProductModel CreateProduct)
    {
        try
        {
            return Ok(await _productService.CreateProduct(CreateProduct));
        }
        catch (ExceptionClass ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Put product data
    /// </summary>
    /// <param name="UpdateProduct"> product Id, product name and product price</param>
    /// <returns> product Id, product name and product price </returns>
    [HttpPut]
    public async Task<ActionResult<ProductModel>> PutProduct(ProductModel UpdateProduct)
    {
        try
        {
            return Ok(await _productService.UpdateProduct(UpdateProduct));
        }
        catch (ExceptionClass ex)
        {
            return BadRequest(ex.Message);
        }
    }


    /// <summary>
    /// Delete product data
    /// </summary>
    /// <param name="idProduct"> product Id</param>
    [HttpDelete("{idProduct}")]
    //[ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult> DeleteProduct(int idProduct)
    {
        try
        {
            await _productService.DeleteProduct(idProduct);
            return Ok();
        }
        catch (ExceptionClass ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
