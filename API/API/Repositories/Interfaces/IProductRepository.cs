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
    /// Get product
    /// </summary>
    /// <param name="idProduct"> product id </param>
    /// <returns>Products</returns>
    Task<ProductModel> GetProduct(int idProduct);

    /// <summary>
    /// Create product
    /// </summary>
    /// <param name="idProduct"> created product </param>
    /// <returns> created product </returns>
    Task<ProductModel> CreateProduct(ProductModel idProduct);

    /// <summary>
    /// Update product
    /// </summary>
    /// <param name="idProduct"> updated product </param>
    /// <returns> updated product </returns>
    Task<ProductModel> UpdateProduct(ProductModel idProduct);

    /// <summary>
    /// Delete product penanently
    /// </summary>
    /// <param name="idProduct"> deleted product </param>
    /// <returns>deleted product</returns>
    Task DeleteUser(ProductModel idProduct);
}
