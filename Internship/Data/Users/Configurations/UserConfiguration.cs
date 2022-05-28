using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internship.Data
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(name: nameof(User));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Password).IsRequired();
            builder.HasOne(x => x.UserType).WithMany().HasForeignKey(x => x.UserTypeId).OnDelete(DeleteBehavior.NoAction);
            builder.Property(x =>x.PhoneNumber).IsRequired();
        }
    }
}

