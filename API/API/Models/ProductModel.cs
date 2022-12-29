// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.Models;

/// <summary>
/// Products Model
/// </summary>
public class ProductModel
{
    /// <summary>
    /// Product Id
    /// </summary>
    private int _idProduct;

    /// <summary>
    /// Product Name
    /// </summary>
    private string _productName;

    /// <summary>
    /// Product price
    /// </summary>
    private double _productPrice;

    /// <summary>
    /// Product Id
    /// </summary>
    public int IdProduct { get => _idProduct; set => _idProduct = value; }

    /// <summary>
    /// Product Name
    /// </summary>
    public string ProductName { get => _productName; set => _productName = value; }

    /// <summary>
    /// Product price
    /// </summary>
    public double ProductPrice { get => _productPrice; set => _productPrice = value; }

    /// <summary>
    /// Constructor 
    /// </summary>
    public ProductModel() { }

    /// <summary>
    /// Constructor 
    /// </summary>
    /// <param name="idProduct">Product´s ID</param>
    /// /// <param name="productName">Product's name</param>
    /// /// <param name="productPrice">Product´s price</param>
    public ProductModel(int idProduct, string productName, double productPrice)
    {
        _idProduct = idProduct;
        _productName = productName;
        _productPrice = productPrice;
    }

    /// <summary>
    /// Constructor 
    /// </summary>
    /// <param name="idProduct">Product´s ID</param>
    public ProductModel(int idProduct) => _idProduct = idProduct;

    /// <summary>
    /// Constructor 
    /// </summary>
    /// /// <param name="productName">Product's name</param>
    /// /// <param name="productPrice">Product´s price</param>
    public ProductModel(string productName, double productPrice)
    {
        _productName = productName;
        _productPrice = productPrice;
    }
}
