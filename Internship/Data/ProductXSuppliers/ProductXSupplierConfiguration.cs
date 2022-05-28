using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internship.Data
{
    public class ProductXSupplierConfiguration : IEntityTypeConfiguration<ProductXSupplier>
    {
        public void Configure(EntityTypeBuilder<ProductXSupplier> builder)
        {
            builder.ToTable(name: nameof(ProductXSupplier));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Price).IsRequired();
            builder.HasOne(x => x.Product).WithMany().HasForeignKey(x => x.ProductId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Supplier).WithMany().HasForeignKey(x => x.SupplierId).OnDelete(DeleteBehavior.NoAction);    

        }
    }
}
