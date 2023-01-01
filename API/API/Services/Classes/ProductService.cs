using API.General.Classes.Configure;
using API.Models;
using API.Repositories.Interfaces;
using API.Services.Interfaces;

// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.Services.Classes;

/// <summary>
/// To manage product service
/// </summary>
public class ProductService : IProductService
{
    /// <summary>
    /// To manage products's table data
    /// </summary>
    private readonly IProductRepository _productRepository;

    /// <summary>
    /// Parameters are passed via dependency injection to manage tables data
    /// </summary>
    public ProductService(IProductRepository productRepository) => _productRepository = productRepository;

    /// <summary>
    /// Get a product from their product Id
    /// </summary>
    /// <param name="idProduct"> product id </param>
    /// <returns> product id, product name and product price </returns>
    public async Task<ProductModel> GetProduct(int idProduct)
    {
        await _productRepository.ProductExist(idProduct);
        return await _productRepository.GetProduct(idProduct);
    }

    /// <summary>
    /// Create a new product
    /// </summary>
    /// <param name="product"> Create product </param>
    public async Task<ProductModel> CreateProduct(ProductModel product)
    {
        //await _productRepository.ProductExist(product.IdProduct);
        return await _productRepository.CreateProduct(product);
    }

    /// <summary>
    /// Update an existing product
    /// </summary>
    /// <param name="product"> Update product </param>
    public async Task<ProductModel> UpdateProduct(ProductModel product) => await _productRepository.UpdateProduct(product);

    /// <summary>
    /// Delete product permanently
    /// </summary>
    /// <param name="idProduct"> Delete product</param>
    public async Task DeleteProduct(int idProduct) => await _productRepository.DeleteProduct(new ProductModel(idProduct));
}
