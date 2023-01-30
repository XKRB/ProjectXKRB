using API.General.Classes;
using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

// <summary>
// Developer....: Karla Ramos Benitez       USER ID: XKRB
// </summary>
namespace API.Context.EntityConfiguration;

/// <summary>
/// Products Entity type Configuration
/// </summary>
public class ProductsEntityTypeConfiguration : IEntityTypeConfiguration<ProductModel>
{
    /// <summary>
    /// Configure appointment
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<ProductModel> builder)
    {
        _ = builder.ToTable(ProductConstants.TableNames.Products);
        _ = builder.HasKey(x => x.IdProduct);
        _ = builder.Property(property => property.ProductName);
        _ = builder.Property(property => property.ProductPrice);
    }
}
