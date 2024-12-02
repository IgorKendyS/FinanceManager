using FinanceManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceManager.Repository.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("varchar(50)");

            builder.Property(x => x.Phone)
                .HasColumnName("Phone")
                .HasColumnType("varchar(16)");

            builder.Property(x => x.Email)
                .IsRequired()
                .HasColumnName("Email")
                .HasColumnType("varchar(100)");

            builder.HasIndex(x => x.Email)
                .IsUnique();

            builder.Property(x => x.PasswordHash)
                .IsRequired()
                .HasColumnName("PasswordHash")
                .HasColumnType("varchar(255)");

            builder.Property(x => x.Created)
                .HasColumnName("Created")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(x => x.LastLogin)
                .HasColumnName("Last_Login")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}
