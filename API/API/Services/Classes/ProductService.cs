using API.General.Classes.Configure;
using API.Models;
using API.Repositories.Interfaces;
using API.Services.Interfaces;
using MessagePack;
using Microsoft.AspNetCore.Http.HttpResults;

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
            return productModel;
    }

    /// <summary>
    /// Create product
    /// </summary>
    /// <param name="product"> Create product </param>
    public async Task<ProductModel> CreateProduct(ProductModel product)
    {
        ProductModel productModel = await _productRepository.GetProduct(product.IdProduct);
        if(productModel != null)
        {
            throw new ExceptionClass("Product already exist");
        }
        else
            await _productRepository.CreateProduct(product);
            return product;
    }

    /// <summary>
    /// Update product
    /// </summary>
    /// <param name="product"> Update product </param>
    public async Task<ProductModel> UpdateProduct(ProductModel product)
    {
        ProductModel productModel = await _productRepository.GetProduct(product.IdProduct);
        if (productModel == null)
        {
            throw new ExceptionClass("Product does not exist, you can´t modify");
        }
        else
            await _productRepository.UpdateProduct(product);
            return product;
    }

    /// <summary>
    /// Delete product permanently
    /// </summary>
    /// <param name="idProduct"> Delete product</param>
    public async Task DeleteProduct(int idProduct) => await _productRepository.DeleteProduct(new ProductModel { IdProduct = idProduct });  
}
