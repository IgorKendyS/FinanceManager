using FinanceManager.Domain.Entities;
using FinanceManager.Repository.Mapping;
using Microsoft.EntityFrameworkCore;

namespace FinanceManager.Repository.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options)
            : base(options)
        {
            Database.EnsureCreated(); // Cria o banco caso não exista
        }

        // DbSets para as entidades
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuração do mapeamento das entidades
            modelBuilder.Entity<User>(new UserMap().Configure);
            modelBuilder.Entity<Category>(new CategoryMap().Configure);
            modelBuilder.Entity<PaymentMethod>(new PaymentMethodMap().Configure);
            modelBuilder.Entity<Transaction>(new TransactionMap().Configure);
        }
    }
}
