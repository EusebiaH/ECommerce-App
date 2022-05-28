using Microsoft.EntityFrameworkCore;

namespace Internship.Data
{
    public class AttributeConfiguration : IEntityTypeConfiguration<Attribute>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Attribute> builder)
        {
            builder.ToTable(name:nameof(Attribute));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x=>x.Active).IsRequired();
            builder.HasOne(x=>x.AttributeType).WithMany().HasForeignKey(x => x.AttributeTypeId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
