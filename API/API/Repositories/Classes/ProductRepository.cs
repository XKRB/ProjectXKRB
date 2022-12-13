
using API.Context.Context;
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
    /// <param name="product">user name</param>¿
    /// <returns> Product </returns>
    public async Task<ProductModel> GetProduct(int product) => await _productContext.Products.FindAsync(product);

    /// <summary>
    /// Create product
    /// </summary>
    /// <param name="product">user entity</param>
    /// <returns>user entity</returns>
    public async Task<ProductModel> CreateProduct(ProductModel product)
    {
        _ = _productContext.Products.Add(product);
        _ = await _productContext.SaveChangesAsync();

        return product;

    }

    /// <summary>
    /// Update product
    /// </summary>
    /// <param name="product">user entity</param>
    /// <returns>user entity</returns>
    public async Task<ProductModel> UpdateProduct(ProductModel product)
    {
        _ = _productContext.Update(product);
        _ = await _productContext.SaveChangesAsync();

        return product;
    }

    /// <summary>
    /// Delete product penanently
    /// </summary>
    /// <param name="product">User</param>
    public async Task DeleteProduct(ProductModel product)
    {
        _ = _productContext.Products.Remove(product);
        _ = await _productContext.SaveChangesAsync();

    }
}
