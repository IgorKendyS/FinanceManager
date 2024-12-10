using FinanceManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceManager.Repository.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("categories"); // Nome da tabela no banco

            builder.HasKey(c => c.Id); // Chave primária

            builder.Property(c => c.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("varchar(50)");

            builder.Property(c => c.Type)
                .IsRequired()
                .HasColumnName("Type")
                .HasColumnType("enum('Expense', 'Income')");

            builder.Property(c => c.Description)
                .HasColumnName("Description")
                .HasColumnType("varchar(255)");
        }
    }
}
