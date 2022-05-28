using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internship.Data
{
    public class OrderConfiguration: IEntityTypeConfiguration<Order>
    {
       public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable(name: nameof(Order));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Date).IsRequired();
            builder.Property(x => x.TotalPrice).IsRequired();
            builder.Property(x => x.TotalVATPrice).IsRequired();
            builder.Property(x => x.DeliveryDate).IsRequired();
            builder.HasOne(x => x.Status).WithMany().HasForeignKey(x => x.StatusId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Address).WithMany().HasForeignKey(x => x.AddressId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction); 
        }
    }
}
