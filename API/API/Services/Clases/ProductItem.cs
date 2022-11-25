using API.Models;
using API.Services.Interfaces;

// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.Services.Clases
{
    public class ProductItem : IProductItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Iva => Price + Price * .16;

        public Task<ProductModel> CreateProduct(ProductModel create)
        {
            throw new NotImplementedException();
        }
    }
}
