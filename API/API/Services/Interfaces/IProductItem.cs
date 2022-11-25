using API.Models;

// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.Services.Interfaces
{
    public interface IProductItem
    {
        /// <summary>
        /// Add Product
        /// </summary>
        /// <param name="create"> CreateProduct object </param>
        /// <returns> Task </returns>
        Task<ProductModel> CreateProduct(ProductModel create);

        //// <summary>
        ///// Update Product
        ///// </summary>
        ///// <param name="userInputOutput"> name and email </param>
        ///// <returns> Task </returns>
        //Task UpdateProduct(produ userInputOutput);
    }
}
