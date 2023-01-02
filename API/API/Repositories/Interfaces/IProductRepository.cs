using API.Models;
// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.Repositories.Interfaces;

/// <summary>
/// To manage product database data
/// </summary>
public interface IProductRepository
{
    /// <summary>
    /// Validate if the product exist
    /// </summary>
    /// <param name="idProduct">product id</param>
    /// <returns>bool</returns>
    Task<bool> ProductExist(int idProduct);

    /// <summary>
    /// Get a product from their product Id
    /// </summary>
    /// <param name="product"> product id </param>
    /// <returns> product </returns>
    Task<ProductModel> GetProduct(int idProduct);

    /// <summary>
    /// Create a new product
    /// </summary>
    /// <param name="product"> product </param>
    /// <returns> product </returns>
    Task<ProductModel> CreateProduct(ProductModel product);

    /// <summary>
    /// Update an existing product
    /// </summary>
    /// <param name="product"> product </param>
    /// <returns> product </returns>
    Task<ProductModel> UpdateProduct(ProductModel product);

    /// <summary>
    /// Delete product penanently
    /// </summary>
    /// <param name="product"> product </param>
    /// <returns>task</returns>
    Task DeleteProduct(ProductModel idProduct);
}
