
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
    /// Get product
    /// </summary>
    /// <param name="idProduct">user name</param>¿
    /// <returns> Product </returns>
    public async Task<ProductModel> GetProduct(int idProduct)
    {
        ProductModel productModel = await _productContext.Products.FindAsync(idProduct);

        return productModel;
    }
    /// <summary>
    /// Create product
    /// </summary>
    /// <param name="idProduct">user entity</param>
    /// <returns>user entity</returns>
    public async Task<ProductModel> CreateProduct(ProductModel idProduct)
    {
        //We can,t have two products with the same idProduct
        if (await _productContext.Products.CountAsync(products => products.IdProduct == idProduct.IdProduct) == 0)
        {
            _ = _productContext.Products.Add(idProduct);
            _ = await _productContext.SaveChangesAsync();

            return idProduct;
        }

        return null;
    }

    /// <summary>
    /// Update product
    /// </summary>
    /// <param name="idProduct">user entity</param>
    /// <returns>user entity</returns>
    public async Task<ProductModel> UpdateProduct(ProductModel idProduct)
    {
        _ = _productContext.Update(idProduct);
        _ = await _productContext.SaveChangesAsync();

        return idProduct;
    }

    /// <summary>
    /// Delete product penanently
    /// </summary>
    /// <param name="idProduct">User</param>
    /// <returns>Task</returns>
    public async Task DeleteUser(ProductModel idProduct)
    {
        _ = _productContext.Products.Remove(idProduct);
        _ = await _productContext.SaveChangesAsync();

    }
}
