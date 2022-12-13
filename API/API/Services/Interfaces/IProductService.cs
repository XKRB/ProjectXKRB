using API.Models;

// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.Services.Interfaces;

public interface IProductService
{
    /// <summary>
    /// Get Product Data
    /// </summary>
    /// <param name="product"> product id </param>
    /// <returns> Product ID, Product Name and Product Price </returns>
    Task<ProductModel> GetProduct(int product);

    /// <summary>
    /// Create Product
    /// </summary>
    /// <param name="product"> createProduct object </param>
    Task<ProductModel> CreateProduct(ProductModel product);

    /// <summary>
    /// Update Product
    /// </summary>
    /// <param name="product"> update product </param>
    Task<ProductModel> UpdateProduct(ProductModel product);

    /// <summary>
    /// Delete product permanently
    /// </summary>
    /// <param name="idProduct"> product id</param>
    Task DeleteProduct(int idProduct);
}
