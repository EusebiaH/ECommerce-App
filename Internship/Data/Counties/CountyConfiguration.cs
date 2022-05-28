using Internship.Data.Counties.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internship.Data
{
    public class CountyConfiguration : IEntityTypeConfiguration<County>
    {
        public void Configure(EntityTypeBuilder<County> builder)
        {
            builder.ToTable(name:nameof(County));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.HasOne(x => x.Country)
                   .WithMany()
                   .HasForeignKey(x => x.CountryId).OnDelete(DeleteBehavior.NoAction);
            builder.HasData(CountyData.GetData());
        }
    }
}
