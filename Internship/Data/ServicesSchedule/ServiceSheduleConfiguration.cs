using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internship.Data
{
    public class ServiceSheduleConfiguration : IEntityTypeConfiguration<ServiceSchedule>
    {
        public void Configure(EntityTypeBuilder<ServiceSchedule> builder)
        {
           builder.ToTable(name: nameof(ServiceSchedule));
            builder.HasKey(x => x.Id);
            builder.Property(x=> x.Date).IsRequired();
            builder.HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x=>x.Product).WithMany().HasForeignKey(x=>x.ProductId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
