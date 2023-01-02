using API.Context.Context;
using API.Models;
using API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

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
    /// Validate if the product exist
    /// </summary>
    /// <param name="idProduct"> product id </param>
    /// <returns> bool </returns>
    public async Task<bool> ProductExist(int idProduct) => await _productContext.Products.AnyAsync(x => x.IdProduct == idProduct);

    /// <summary>
    /// Get a product from their product Id
    /// </summary>
    /// <param name="idProduct"> product id </param>¿
    /// <returns> Product </returns>
    public async Task<ProductModel> GetProduct(int idProduct) => await _productContext.Products.FindAsync(idProduct);

    /// <summary>
    /// Create a new product
    /// </summary>
    /// <param name="product"> product </param>
    /// <returns> product </returns>
    public async Task<ProductModel> CreateProduct(ProductModel product)
    {
        _ = _productContext.Products.Add(product);
        _ = await _productContext.SaveChangesAsync();
        return product;
    }

    /// <summary>
    /// Update an existing product
    /// </summary>
    /// <param name="product"> product </param>
    /// <returns> product </returns>
    public async Task<ProductModel> UpdateProduct(ProductModel product)
    {
        _ = _productContext.Products.Update(product);
        _ = await _productContext.SaveChangesAsync();
        return product;
    }

    /// <summary>
    /// Delete product penanently
    /// </summary>
    /// <param name="idProduct"> product id </param>
    /// <returns>task</returns>
    public async Task DeleteProduct(ProductModel idProduct)
    {
        _ = _productContext.Products.Remove(idProduct);
        _ = await _productContext.SaveChangesAsync();
    }
}
