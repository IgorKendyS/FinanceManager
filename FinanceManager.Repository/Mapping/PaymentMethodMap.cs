using FinanceManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceManager.Repository.Mapping
{
    public class PaymentMethodMap : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.ToTable("paymentmethods"); // Nome da tabela no banco

            builder.HasKey(pm => pm.Id); // Chave primária

            builder.Property(pm => pm.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("varchar(50)");

            builder.Property(pm => pm.Type)
                .IsRequired()
                .HasColumnName("Type")
                .HasColumnType("enum('Credit', 'Debit', 'Cash')");

            builder.Property(pm => pm.CardLimit)
                .HasColumnName("CardLimit")
                .HasColumnType("decimal(10,2)");

            // Relacionamento com a tabela de usuários (UserId -> Users.Id)
            builder.HasOne(pm => pm.User)
                .WithMany()
                .HasForeignKey(pm => pm.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
