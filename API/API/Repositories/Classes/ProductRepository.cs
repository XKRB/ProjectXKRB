using API.Context.Context;
using API.General.Classes.Configure;
using API.Models;
using API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.Repositories.Classes;

/// <summary>
/// To manage product database data
/// </summary>
public class ProductRepository : IProductRepository
{
    /// <summary>
    /// To query product's tables
    /// </summary>
    private readonly ProductContext _productContext;

    /// <summary>
    /// Parameters are passed via dependency injection to query tables
    /// </summary>
    public ProductRepository(ProductContext productContext) => _productContext = productContext;

    /// <summary>
    /// Validate if the product exist
    /// </summary>
    /// <param name="idProduct"></param>
    /// <returns></returns>
    public async Task ProductExist(int idProduct)
    {
        if (! await _productContext.Products.AnyAsync(x => x.IdProduct == idProduct))
        {
            throw new ExceptionClass(ConstantsClass.ProductDoesNotExist);
        }
    }

    /// <summary>
    /// Get a product from their product Id
    /// </summary>
    /// <param name="idProduct">get product</param>¿
    /// <returns> Product </returns>
    public async Task<ProductModel> GetProduct(int idProduct) => await _productContext.Products.FindAsync(idProduct);

    /// <summary>
    /// Create a new product
    /// </summary>
    /// <param name="product">create product</param>
    /// <returns>create product</returns>
    public async Task<ProductModel> CreateProduct(ProductModel product)
    {
        if (await _productContext.Products.AnyAsync(x => x.IdProduct == product.IdProduct))
        {
            throw new ExceptionClass(ConstantsClass.ProductAlreadyExist);
        }
        else
        {
            _ = _productContext.Products.Update(product);
            _ = await _productContext.SaveChangesAsync();
            return product;
        }
    }

    /// <summary>
    /// Update an existing product
    /// </summary>
    /// <param name="product">product updated</param>
    /// <returns>product updated</returns>
    public async Task<ProductModel> UpdateProduct(ProductModel product)
    {
        if (!await _productContext.Products.AnyAsync(x => x.IdProduct == product.IdProduct))
        {
            throw new ExceptionClass(ConstantsClass.ProductCanNotModify);
        }
        else
        {
            _ = _productContext.Products.Update(product);
            _ = await _productContext.SaveChangesAsync();
            return product;
        }
    }

    /// <summary>
    /// Delete product penanently
    /// </summary>
    /// <param name="idProduct">product deleted</param>
    /// <returns>product deleted</returns>
    public async Task DeleteProduct(ProductModel idProduct)
    {
        if (!await _productContext.Products.AnyAsync(x => x.IdProduct == idProduct.IdProduct))
        {
            throw new ExceptionClass(ConstantsClass.ProductCanNotDelete);
        }
        else
        {
            _ = _productContext.Products.Remove(idProduct);
            _ = await _productContext.SaveChangesAsync();
        }
    }
}
