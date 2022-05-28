using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internship.Data
{
        public class UserTypeConfiguration : IEntityTypeConfiguration<UserType>
        {
            public void Configure(EntityTypeBuilder<UserType> builder)
            {
                builder.ToTable(name: nameof(UserType));
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Name).IsRequired();
                builder.HasData(UserTypeData.GetData());

        }
        }
    }
