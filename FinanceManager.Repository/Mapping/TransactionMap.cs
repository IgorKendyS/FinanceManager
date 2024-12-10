using FinanceManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceManager.Repository.Mapping
{
    public class TransactionMap : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("expenses"); // Nome da tabela no banco

            builder.HasKey(e => e.Id); // Chave primária

            builder.Property(e => e.Amount)
                .IsRequired()
                .HasColumnName("Amount")
                .HasColumnType("decimal(10,2)");

            builder.Property(e => e.Date)
                .IsRequired()
                .HasColumnName("Date")
                .HasColumnType("date");

            builder.Property(e => e.Description)
                .HasColumnName("Description")
                .HasColumnType("varchar(255)");

            // Relacionamento com User (UserId -> Users.Id)
            builder.HasOne(e => e.User)
                .WithMany()
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Relacionamento com Category (CategoryId -> Categories.Id)
            builder.HasOne(e => e.Category)
                .WithMany()
                .HasForeignKey(e => e.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relacionamento com PaymentMethod (PaymentMethodId -> PaymentMethods.Id)
            builder.HasOne(e => e.PaymentMethod)
                .WithMany()
                .HasForeignKey(e => e.PaymentMethodId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
