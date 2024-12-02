using FinanceManager.Domain.Entities;
using FinanceManager.Repository.Mapping;
using Microsoft.EntityFrameworkCore;

namespace FinanceManager.Repository.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            Database.EnsureCreated(); // Cria banco caso não exista
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Expense> Expenses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>(new UserMap().Configure);
            modelBuilder.Entity<Category>(new CategoryMap().Configure);
            modelBuilder.Entity<Income>(new IncomeMap().Configure);
            modelBuilder.Entity<PaymentMethod>(new PaymentMethodMap().Configure);
            modelBuilder.Entity<Expense>(new ExpenseMap().Configure);
        }
    }
}
