using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internship.Data
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {


        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable(name: nameof(Address));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Street).IsRequired();
            builder.Property(x => x.OtherDetails).IsRequired();

            builder.HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Country).WithMany().HasForeignKey(x => x.CountryId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.County).WithMany().HasForeignKey(x => x.CountyId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.City).WithMany().HasForeignKey(x => x.CityId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
