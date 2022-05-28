using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internship.Data
{
        public class VatConfiguration : IEntityTypeConfiguration<Vat>
        {
            public void Configure(EntityTypeBuilder<Vat> builder)
            {
                builder.ToTable(name: nameof(Vat));
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Name).IsRequired();
                builder.Property(x => x.Value).IsRequired();

            }
        }
    }
