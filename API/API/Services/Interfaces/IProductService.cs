using API.General.InputOutputStructures.Products;
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
    Task<GetProductOutput> IGetProduct(int idProduct);

    /// <summary>
    /// Create Product
    /// </summary>
    /// <param name="createProduct"> createProduct object </param>
    Task<ProductModel> ICreateProduct(ProductModel createProduct);

    /// <summary>
    /// Update Product
    /// </summary>
    /// <param name="updateProduct"> update product </param>
    Task UpdateProduct(UpdateProductInput updateProduct);

    /// <summary>
    /// Delete product permanently
    /// </summary>
    /// <param name="idProduct"> product id</param>
    Task IDeleteProduct(int idProduct);

    /// <summary>
    /// Get all products 
    /// </summary>
    /// <param name="idProduct"> product id </param>
    /// <param name="productname"> product name </param>
    /// <param name="productPrice"> product price </param>
    /// <returns> list of prodcut Id, product name and product price </returns>
    Task<List<GetProductOutput>> IGetAllProduct(int idProduct, string productname, int productPrice);

    ///// <summary>
    ///// Delete User
    ///// </summary>
    ///// <param name="idProduct"> product id </param>
    //Task DisableProduct(int idProduct);

    ///// <summary>
    ///// Active user
    ///// </summary>
    ///// <param name="idProduct"> product id </param>
    //Task ActiveUser(int idProduct);
}
