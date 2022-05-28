using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Internship.Data;

namespace Internship.Data
{
    public class StockConfiguration: IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.ToTable(name: nameof(Stock));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.InvoiceDate).IsRequired();
            builder.Property(x => x.Quantity).IsRequired();
            builder.Property(x => x.PurchasePrice).IsRequired();
            builder.HasOne(x => x.Product).WithMany().HasForeignKey(x => x.ProductId).OnDelete(DeleteBehavior.NoAction);
        }

    }
}
