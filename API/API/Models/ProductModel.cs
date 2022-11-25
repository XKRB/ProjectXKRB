// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.Models
{
    /// <summary>
    /// Products Model
    /// </summary>
    public class ProductModel
    {
        /// <summary>
        /// Product Id
        /// </summary>
        private int _id;

        /// <summary>
        /// Product Name
        /// </summary>
        private string _Name;

        /// <summary>
        /// Product price
        /// </summary>
        private int _price;


        /// <summary>
        /// Product Id
        /// </summary>
        public int id { get => _id; set { _id= value; } }

        /// <summary>
        /// Product Name
        /// </summary>
        public string Name { get => _Name; set { _Name= value; } }

        /// <summary>
        /// Product price
        /// </summary>
        public int price { get => _price; set { _price= value; } }

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="id">Product´s ID</param>
        /// /// <param name="name">Product's name</param>
        /// /// <param name="price">Product´s price</param>
        public ProductModel(int id, string name, int price)
        {
            _id = id;
            _Name= name;
            _price = price;
        }
    }
}
