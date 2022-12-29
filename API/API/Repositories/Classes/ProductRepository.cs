
using API.Context.Context;
using API.General.Classes.Configure;
using API.Models;
using API.Repositories.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.EntityFrameworkCore;
using System.Data;

// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.Repositories.Classes;

/// <summary>
/// To manage product database data
/// </summary>
public class ProductRepository : IProductRepository
{
    /// <summary>
    /// To query product's tables
    /// </summary>
    private readonly ProductContext _productContext;

    /// <summary>
    /// Parameters are passed via dependency injection to query tables
    /// </summary>
    public ProductRepository(ProductContext productContext) => _productContext = productContext;

    /// <summary>
    /// Get a product from their product Id
    /// </summary>
    /// <param name="product">get product</param>¿
    /// <returns> Product </returns>
    public async Task<ProductModel> GetProduct(int product) => await _productContext.Products.FindAsync(product);

    /// <summary>
    /// Create a new product
    /// </summary>
    /// <param name="product">create product</param>
    /// <returns>create product</returns>
    public async Task<ProductModel> CreateProduct(ProductModel product)
    {
        _ = _productContext.Products.Add(product);
        _ = await _productContext.SaveChangesAsync();
        return product;
    }

    /// <summary>
    /// Update an existing product
    /// </summary>
    /// <param name="product">product updated</param>
    /// <returns>product updated</returns>
    public async Task<ProductModel> UpdateProduct(ProductModel product)
    {
        if (!await _productContext.Products.AnyAsync(x => x.IdProduct == product.IdProduct))
        {
            throw new ExceptionClass("Product does not exist, you can´t modify");
        }
        else
        {
            _productContext.Products.Update(product);
            await _productContext.SaveChangesAsync();
            return product;
        }
    }

    /// <summary>
    /// Delete product penanently
    /// </summary>
    /// <param name="product">product deleted</param>
    /// <returns>product deleted</returns>
    public async Task DeleteProduct(ProductModel product)
    {
        if(! await _productContext.Products.AnyAsync(x => x.IdProduct == product.IdProduct))
        {
            throw new ExceptionClass("Product does not exist, you can´t eliminate");
        }
        else
        {
            _productContext.Products.Remove(product);
            await _productContext.SaveChangesAsync();
            //message = "The product was deleted";
            //return
        }
    }
}
