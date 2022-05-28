using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internship.Data
{
    public class ProductXAttributeConfiguration : IEntityTypeConfiguration<ProductXAttribute>
    {
        public void Configure(EntityTypeBuilder<ProductXAttribute> builder)
        {
            builder.ToTable(name: nameof(ProductXAttribute));
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Product).WithMany().HasForeignKey(x => x.ProductId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Attribute).WithMany().HasForeignKey(x => x.AttributeId).OnDelete(DeleteBehavior.NoAction);
            builder.Property(x => x.Value).IsRequired();

        }
    }
}
