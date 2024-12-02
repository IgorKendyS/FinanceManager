using FinanceManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceManager.Repository.Mapping
{
    public class PaymentMethodMap : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.ToTable("PaymentMethods");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("varchar(50)");

            builder.Property(x => x.Type)
                .IsRequired()
                .HasColumnName("Type")
                .HasColumnType("enum('Credit', 'Debit', 'Credit/Debit')");

            builder.Property(x => x.CardLimit)
                .HasColumnName("CardLimit")
                .HasColumnType("decimal(10, 2)");

            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
