using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using FinanceManager.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FinanceManager.Test
{
    [TestClass]
    public class UnitTestRepository
    {
        public partial class FinanceDbContext : DbContext
        {
            public DbSet<User> Users { get; set; }
            public DbSet<Category> Categories { get; set; }
            public DbSet<PaymentMethod> PaymentMethods { get; set; }
            public DbSet<Transaction> Transactions { get; set; }

            public FinanceDbContext()
            {
                Database.EnsureCreated();
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "localhost";
                var port = "3306";
                var database = "financas";
                var username = "root";
                var password = "ifsp2024";
                var strCon = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password}";
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }
        }

        [TestMethod]
        public void TestInsertUsers()
        {
            using (var context = new FinanceDbContext())
            {
                var user1 = new User
                {
                    Name = "Alice Silva",
                    Email = "alice@teste.com",
                    Phone = "+5511999999999",
                    PasswordHash = "senha123"
                };
                context.Users.Add(user1);

                var user2 = new User
                {
                    Name = "Bob Santos",
                    Email = "bob@teste.com",
                    Phone = "+5511988888888",
                    PasswordHash = "senha456"
                };
                context.Users.Add(user2);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListUsers()
        {
            using (var context = new FinanceDbContext())
            {
                foreach (var user in context.Users)
                {
                    Console.WriteLine(JsonSerializer.Serialize(user));
                }
            }
        }

        [TestMethod]
        public void TestInsertCategories()
        {
            using (var context = new FinanceDbContext())
            {
                var category1 = new Category
                {
                    Name = "Aluguel",
                    Type = "Expense",
                    Description = "Despesa mensal com aluguel"
                };
                context.Categories.Add(category1);

                var category2 = new Category
                {
                    Name = "Salário",
                    Type = "Income",
                    Description = "Recebimento de salário"
                };
                context.Categories.Add(category2);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListCategories()
        {
            using (var context = new FinanceDbContext())
            {
                foreach (var category in context.Categories)
                {
                    Console.WriteLine(JsonSerializer.Serialize(category));
                }
            }
        }

        [TestMethod]
        public void TestInsertPaymentMethods()
        {
            using (var context = new FinanceDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Id == 1);
                var paymentMethod1 = new PaymentMethod
                {
                    Name = "Cartão de Crédito",
                    Type = "Credit",
                    CardLimit = 5000.00m,
                    UserId = user.Id
                };
                context.PaymentMethods.Add(paymentMethod1);

                var paymentMethod2 = new PaymentMethod
                {
                    Name = "Dinheiro",
                    Type = "Cash",
                    UserId = user.Id
                };
                context.PaymentMethods.Add(paymentMethod2);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListPaymentMethods()
        {
            using (var context = new FinanceDbContext())
            {
                foreach (var payment in context.PaymentMethods)
                {
                    Console.WriteLine(JsonSerializer.Serialize(payment));
                }
            }
        }

        [TestMethod]
        public void TestInsertTransactions()
        {
            using (var context = new FinanceDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Id == 1);
                var category = context.Categories.FirstOrDefault(c => c.Id == 1);
                var paymentMethod = context.PaymentMethods.FirstOrDefault(p => p.Id == 1);

                var transaction1 = new Transaction
                {
                    Amount = 1500.00m,
                    Date = DateTime.Now,
                    Description = "Pagamento de aluguel",
                    UserId = user.Id,
                    CategoryId = category.Id,
                    PaymentMethodId = paymentMethod.Id
                };
                context.Transactions.Add(transaction1);

                var transaction2 = new Transaction
                {
                    Amount = 3500.00m,
                    Date = DateTime.Now,
                    Description = "Recebimento de salário",
                    UserId = user.Id,
                    CategoryId = 2
                };
                context.Transactions.Add(transaction2);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListTransactions()
        {
            using (var context = new FinanceDbContext())
            {
                foreach (var transaction in context.Transactions)
                {
                    Console.WriteLine(JsonSerializer.Serialize(transaction));
                }
            }
        }
    }
}
