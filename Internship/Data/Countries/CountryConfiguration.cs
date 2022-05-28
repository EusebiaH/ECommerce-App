using Internship.Data.Countries.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internship.Data
{
    public class CountryConfiguration:IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable(name:nameof(Country));
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).IsRequired();
            builder.HasData(CountryData.GetData());
        }
    }
}
