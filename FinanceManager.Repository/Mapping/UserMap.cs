using FinanceManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceManager.Repository.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("users"); 

            builder.HasKey(u => u.Id); 

            builder.Property(u => u.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("varchar(50)");

            builder.Property(u => u.Email)
                .IsRequired()
                .HasColumnName("Email")
                .HasColumnType("varchar(100)");

            builder.Property(u => u.PasswordHash)
                .IsRequired()
                .HasColumnName("PasswordHash")
                .HasColumnType("varchar(255)");

            builder.Property(u => u.Phone)
                .HasColumnName("Phone")
                .HasColumnType("varchar(16)");

            builder.Property(u => u.Created)
                .HasColumnName("Created")
                .HasColumnType("datetime(0)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");


            builder.Property(u => u.LastLogin)
                .HasColumnName("LastLogin")
                .HasColumnType("datetime(0)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}
