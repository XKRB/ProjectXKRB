using API.General.Classes;
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

    //public var resourceManager = new ResourceManager("BaseController.en-US", Assembly.GetExecutingAssembly());

    /// <summary>
    /// Get a product from their product Id
    /// </summary>
    /// <param name="idProduct"> product id </param>
    /// <returns> product </returns>
    public async Task<ProductModel> GetProduct(int idProduct) => await _productRepository.ProductExist(idProduct)
            ? await _productRepository.GetProduct(idProduct)
            : throw new APIException(1);
    //: throw new ProductException(1);

    /// <summary>
    /// Create a new product
    /// </summary>
    /// <param name="product"> product </param>
    /// <returns> product </returns>
    public async Task<ProductModel> CreateProduct(ProductModel product) => await _productRepository.ProductExist(product.IdProduct)
            ? throw new APIException(2)
            : await _productRepository.CreateProduct(product);

    /// <summary>
    /// Update an existing product
    /// </summary>
    /// <param name="product"> product </param>
    /// <returns> product </returns>
    public async Task<ProductModel> UpdateProduct(ProductModel product) => await _productRepository.ProductExist(product.IdProduct)
            ? await _productRepository.UpdateProduct(product)
            : throw new APIException(3);

    /// <summary>
    /// Delete product permanently
    /// </summary>
    /// <param name="idProduct"> product id </param>
    /// <returns> task </returns>
    public async Task DeleteProduct(int idProduct)
    {
        if (!await _productRepository.ProductExist(idProduct))
        {
            throw new APIException(4);
        }
        else
        {
            await _productRepository.DeleteProduct(new ProductModel(idProduct));
        }
    }
}
