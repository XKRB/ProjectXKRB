
using API.Context.Context;
using API.General.Classes.Configure;
using API.Models;
using API.Repositories.Interfaces;

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
    /// Get product
    /// </summary>
    /// <param name="product">get product</param>¿
    /// <returns> Product </returns>
    public async Task<ProductModel> GetProduct(int product) => await _productContext.Products.FindAsync(product);

    /// <summary>
    /// Create product
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
    /// Update product
    /// </summary>
    /// <param name="product">product updated</param>
    /// <returns>product updated</returns>
    public async Task<ProductModel> UpdateProduct(ProductModel product)
    {
        _ = _productContext.Update(product);
        _ = await _productContext.SaveChangesAsync();

        return product;
    }

    /// <summary>
    /// Delete product penanently
    /// </summary>
    /// <param name="product">product deleted</param>
    /// <returns>product deleted</returns>
    public async Task DeleteProduct(ProductModel product)
    {
        _ = _productContext.Products.Remove(product);
        _ = await _productContext.SaveChangesAsync();

    }
}
