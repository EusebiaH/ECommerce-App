using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internship.Data.Statuses
{
    public class StatusConfiguration : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.ToTable(name: nameof(Status));
            builder.HasKey(x => x.Id);  
            builder.Property(x => x.Name).IsRequired(); 
        }


    }
}
