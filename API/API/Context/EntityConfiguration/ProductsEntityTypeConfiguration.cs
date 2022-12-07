using API.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Context.EntityConfiguration;

public class ProductsEntityTypeConfiguration
{
    public void Configure(EntityTypeBuilder<ProductModel> builder)
    {
        _ = builder.Property(property => property.IdProduct);
        _ = builder.Property(property => property.ProductName);
        _ = builder.Property(property => property.ProductPrice);
    }
}
