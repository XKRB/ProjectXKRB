using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Context.EntityConfiguration
{
    public class ProductsEntityTypeConfiguration
    {
        public void Configure(EntityTypeBuilder<ProductModel> builder)
        {
            builder.Property(property => property.IdProduct);
            builder.Property(property => property.ProductName);
            builder.Property(property => property.ProductPrice);
        }
    }
}
