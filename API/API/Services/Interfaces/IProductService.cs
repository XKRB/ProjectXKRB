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
    /// <param name="idProduct"> product id </param>
    /// <returns> Product ID, Product Name and Product Price </returns>
    Task<ProductModel> GetProduct(int idProduct);

    /// <summary>
    /// Create Product
    /// </summary>
    /// <param name="idProduct"> createProduct object </param>
    Task<ProductModel> CreateProduct(ProductModel idProduct);

    /// <summary>
    /// Update Product
    /// </summary>
    /// <param name="idProduct"> update product </param>
    Task<ProductModel> UpdateProduct(ProductModel idProduct);

    /// <summary>
    /// Delete product permanently
    /// </summary>
    /// <param name="idProduct"> product id</param>
    Task DeleteProduct(int idProduct);
}
