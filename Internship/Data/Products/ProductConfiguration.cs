using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internship.Data
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(name: nameof(Product));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.PriceWithVAT).IsRequired();
            builder.Property(x => x.Discount).IsRequired();
            builder.Property(x => x.PriceDiscount).IsRequired();
            builder.Property(x => x.VATValue).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Active).IsRequired();

            builder.HasOne(x => x.ProductType).WithMany().HasForeignKey(x => x.ProductTypeId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.ProductCategory).WithMany().HasForeignKey(x => x.ProductCategoryId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Manufacturer).WithMany().HasForeignKey(x => x.ManufacturerId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.VAT).WithMany().HasForeignKey(x => x.VATId).OnDelete(DeleteBehavior.NoAction);


        }
    }
}
