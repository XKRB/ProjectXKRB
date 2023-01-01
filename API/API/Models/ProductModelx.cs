// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.Models;

/// <summary>
/// Products Model
/// </summary>
public class ProductModelx
{
    /// <summary>
    /// Product Name
    /// </summary>
    private string _productName;

    /// <summary>
    /// Product price
    /// </summary>
    private double _productPrice;

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
    public ProductModelx() { }

    /// <summary>
    /// Constructor 
    /// </summary>
    /// /// <param name="productName">Product's name</param>
    /// /// <param name="productPrice">Product´s price</param>
    public ProductModelx(string productName, double productPrice)
    {
        _productName = productName;
        _productPrice = productPrice;
    }
}
