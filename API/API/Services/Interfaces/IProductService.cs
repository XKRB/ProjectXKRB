﻿using API.Models;

// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.Services.Interfaces;

/// <summary>
/// To manage product service
/// </summary>
public interface IProductService
{
    /// <summary>
    /// Get a product from their product Id
    /// </summary>
    /// <param name="product"> product id </param>
    /// <returns> Product ID, Product Name and Product Price </returns>
    Task<ProductModel> GetProduct(int idProduct);

    /// <summary>
    /// Create a new Product
    /// </summary>
    /// <param name="product"> createProduct object </param>
    Task<ProductModel> CreateProduct(ProductModel product);

    /// <summary>
    /// Update an existing Product
    /// </summary>
    /// <param name="product"> update product </param>
    Task<ProductModel> UpdateProduct(ProductModel product);

    /// <summary>
    /// Delete product permanently
    /// </summary>
    /// <param name="idProduct"> product id</param>
    Task DeleteProduct(int idProduct);
}
