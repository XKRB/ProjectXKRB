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
    /// <returns> product </returns>
    public async Task<ProductModel> GetProduct(int idProduct) => await _productRepository.ProductExist(idProduct)
            ? await _productRepository.GetProduct(idProduct)
            : throw new ExceptionClass(ConstantsClass.ProductNotFound);

    /// <summary>
    /// Create a new product
    /// </summary>
    /// <param name="product"> product </param>
    /// <returns> product </returns>
    public async Task<ProductModel> CreateProduct(ProductModel product) => await _productRepository.ProductExist(product.IdProduct)
            ? throw new ExceptionClass(ConstantsClass.ProductAlreadyExist)
            : await _productRepository.CreateProduct(product);

    /// <summary>
    /// Update an existing product
    /// </summary>
    /// <param name="product"> product </param>
    /// <returns> product </returns>
    public async Task<ProductModel> UpdateProduct(ProductModel product) => await _productRepository.ProductExist(product.IdProduct)
            ? await _productRepository.UpdateProduct(product)
            : throw new ExceptionClass(ConstantsClass.ProductCanNotModify);

    /// <summary>
    /// Delete product permanently
    /// </summary>
    /// <param name="idProduct"> product id </param>
    /// <returns> task </returns>
    public async Task DeleteProduct(int idProduct)
    {
        if (!await _productRepository.ProductExist(idProduct))
        {
            throw new ExceptionClass(ConstantsClass.ProductCanNotDelete);
        }
        else
        {
            await _productRepository.DeleteProduct(new ProductModel(idProduct));
        }
    }
}
