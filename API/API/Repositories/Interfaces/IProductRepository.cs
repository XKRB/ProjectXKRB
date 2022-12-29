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
    /// <param name="idProduct"></param>
    /// <returns></returns>
    Task ProductExist(int idProduct);

    /// <summary>
    /// Get a product from their product Id
    /// </summary>
    /// <param name="product"> product id </param>
    /// <returns>Products</returns>
    Task<ProductModel> GetProduct(int idProduct);

    /// <summary>
    /// Create a new product
    /// </summary>
    /// <param name="product"> created product </param>
    /// <returns> created product </returns>
    Task<ProductModel> CreateProduct(ProductModel product);

    /// <summary>
    /// Update an existing product
    /// </summary>
    /// <param name="product"> updated product </param>
    /// <returns> updated product </returns>
    Task<ProductModel> UpdateProduct(ProductModel product);

    /// <summary>
    /// Delete product penanently
    /// </summary>
    /// <param name="product"> deleted product </param>
    /// <returns>deleted product</returns>
    Task DeleteProduct(ProductModel idProduct);
}
