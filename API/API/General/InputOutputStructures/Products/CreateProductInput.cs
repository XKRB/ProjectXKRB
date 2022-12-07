namespace API.General.InputOutputStructures.Products;

public class CreateProductInput
{
    /// <summary>
    /// Product´s Id
    /// </summary>
    public int IdProduct { get; set; }

    /// <summary>
    /// Product Name
    /// </summary>
    public string? ProductName { get; set; }

    /// <summary>
    /// Product Price
    /// </summary>
    public int ProductPrice { get; set; }
}
