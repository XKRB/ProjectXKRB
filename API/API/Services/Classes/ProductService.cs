using API.Models;
using API.Repositories.Interfaces;
using API.Services.Interfaces;

// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.Services.Classes;

public class ProductService : IProductService
{
    /// <summary>
    /// User Model
    /// </summary>

    private readonly ProductModel? _product = null;

    /// <summary>
    /// To manage products's table data
    /// </summary>
    private readonly IProductRepository _productRepository;

    /// <summary>
    /// Parameters are passed via dependency injection to manage tables data
    /// </summary>
    public ProductService(IProductRepository productRepository) => _productRepository = productRepository;

    /// <summary>
    /// Get product
    /// </summary>
    /// <param name="idProduct"> product id </param>
    /// <returns> product id, product name and product price </returns>
    public async Task<ProductModel> GetProduct(int idProduct)
    {
        ProductModel product = await _productRepository.GetProduct(idProduct);
        return product;
    }
    //await _productRepository.GetProduct(getProduct);

    /// <summary>
    /// Create product
    /// </summary>
    /// <param name="createProduct"> CreateProductInput object </param>
    public async Task<ProductModel> CreateProduct(ProductModel idProduct) => await _productRepository.CreateProduct(idProduct);

    /// <summary>
    /// Update product
    /// </summary>
    /// <param name="updateProduct"> name and email </param>
    /// <returns> Task </returns>
    public async Task<ProductModel> UpdateProduct(ProductModel idProduct) =>
        await _productRepository.UpdateProduct(idProduct);

    /// <summary>
    /// Delete product permanently
    /// </summary>
    /// <param name="idProduct">User name</param>
    public async Task DeleteProduct(int idProduct) => await _productRepository.DeleteProduct(new ProductModel { IdProduct = idProduct });
}
