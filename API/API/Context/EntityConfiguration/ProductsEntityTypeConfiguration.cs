using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Context.EntityConfiguration;

public class ProductsEntityTypeConfiguration : IEntityTypeConfiguration<ProductModel>
{
    /// <summary>
    /// Configure appointment
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<ProductModel> builder)
    {
        _ = builder.Property(property => property.IdProduct);
        _ = builder.Property(property => property.ProductName);
        _ = builder.Property(property => property.ProductPrice);
    }
}
