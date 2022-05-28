using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Internship.Data
{
    public class ManufacturerConfiguration: IEntityTypeConfiguration<Manufacturer>
    {
        public void Configure(EntityTypeBuilder<Manufacturer> builder)
        {
            builder.ToTable(name: nameof(Manufacturer));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.HeadquartersLocation).IsRequired();
            builder.Property(x => x.Active).IsRequired();

        }
    }
}
