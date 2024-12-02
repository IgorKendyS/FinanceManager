using FinanceManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceManager.Repository.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("varchar(50)");

            builder.Property(x => x.Type)
                .IsRequired()
                .HasColumnName("Type")
                .HasColumnType("enum('Expense', 'Income')");

            builder.Property(x => x.Description)
                .HasColumnName("Description")
                .HasColumnType("varchar(255)");
        }
    }
}
