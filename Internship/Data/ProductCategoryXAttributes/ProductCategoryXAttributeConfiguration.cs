using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internship.Data
{
    public class ProductCategoryXAttributeConfiguration : IEntityTypeConfiguration<ProductCategoryXAttribute>
    {
        public void Configure(EntityTypeBuilder<ProductCategoryXAttribute> builder)
        {
           builder.ToTable(name:nameof(ProductCategoryXAttribute));
           builder.HasOne(x=>x.ProductCategory).WithMany().HasForeignKey(x=>x.ProductCategoryId).OnDelete(DeleteBehavior.NoAction);
           builder.HasOne(x=>x.Attribute).WithMany().HasForeignKey(x=>x.AttributeId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
