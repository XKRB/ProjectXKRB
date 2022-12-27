using API.General.Classes.Configure;
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

    //private readonly ProductModel? _product = null;

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
    /// <param name="product"> product id </param>
    /// <returns> product id, product name and product price </returns>
    public async Task<ProductModel> GetProduct(int product)
    {
        ProductModel productModel = await _productRepository.GetProduct(product);
        if (productModel == null)
        {
            throw new ExceptionClass("Product was not found");
        }
        else
        {
            return productModel;
        }

    }

    /// <summary>
    /// Create product
    /// </summary>
    /// <param name="product"> Create product </param>
    public async Task<ProductModel> CreateProduct(ProductModel product)
    {
        ProductModel productModel = await _productRepository.GetProduct(product.IdProduct);
        if (productModel != null)
        {
            throw new ExceptionClass("Product already exist");
        }
        else
        {
            await _productRepository.CreateProduct(product);
            return productModel;
        }
    }

    /// <summary>
    /// Update product
    /// </summary>
    /// <param name="product"> Update product </param>
    public async Task<ProductModel> UpdateProduct(ProductModel product)
    {
        return await _productRepository.UpdateProduct(product);
    }

    /// <summary>
    /// Delete product permanently
    /// </summary>
    /// <param name="product"> Delete product</param>
    public async Task DeleteProduct(int product)=> await _productRepository.DeleteProduct(new ProductModel { IdProduct = product });
}
