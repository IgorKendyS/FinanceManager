
using FinanceManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;

namespace FinanceManager.Test
{
    [TestClass]
    public class UnitTestRepository
    {
        public partial class MyDbContext : DbContext
        {
            public DbSet<User> Users { get; set; }
            public DbSet<Category> Categories { get; set; }
            public DbSet<Income> Incomes { get; set; }
            public DbSet<PaymentMethod> PaymentMethods { get; set; }
            public DbSet<Expense> Expenses { get; set; }

            public MyDbContext()
            {
                Database.EnsureCreated(); // Garante que o banco será criado
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "localhost";
                var port = "3306";
                var database = "Financas";
                var username = "root";
                var password = "ifsp2024";
                var strCon = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password};";
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }
        }

        [TestMethod]
        public void TestInsertUser()
        {
            using (var context = new MyDbContext())
            {
                var user = new User
                {
                    Name = "Igor Sakaguchi",
                    Phone = "18997907790",
                    Email = "s.kendy@aluno.ifsp.edu.br",
                    PasswordHash = "A1b2C3e4",
                    Created = DateTime.Now,
                    LastLogin = DateTime.Now
                };
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListUsers()
        {
            using (var context = new MyDbContext())
            {
                foreach (var user in context.Users)
                {
                    Console.WriteLine(JsonSerializer.Serialize(user));
                }
            }
        }

        [TestMethod]
        public void TestInsertCategory()
        {
            using (var context = new MyDbContext())
            {
                var category = new Category
                {
                    Name = "Comida",
                    Type = "Expense",
                    Description = "Gastos com comida"
                };
                context.Categories.Add(category);

                category = new Category
                {
                    Name = "Salário",
                    Type = "Income",
                    Description = "Pagamento do trabalho"
                };
                context.Categories.Add(category);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListCategories()
        {
            using (var context = new MyDbContext())
            {
                foreach (var category in context.Categories)
                {
                    Console.WriteLine(JsonSerializer.Serialize(category));
                }
            }
        }

        [TestMethod]
        public void TestInsertPaymentMethod()
        {
            using (var context = new MyDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Name == "Igor Sakaguchi");

                if (user != null)
                {
                    var paymentMethod = new PaymentMethod
                    {
                        Name = "Nubank",
                        Type = "Credit",
                        CardLimit = 10000.00M,
                        User = user
                    };
                    context.PaymentMethods.Add(paymentMethod);
                    context.SaveChanges();
                }
            }
        }

        [TestMethod]
        public void TestListPaymentMethods()
        {
            using (var context = new MyDbContext())
            {
                foreach (var paymentMethod in context.PaymentMethods)
                {
                    Console.WriteLine(JsonSerializer.Serialize(paymentMethod));
                }
            }
        }

        [TestMethod]
        public void TestInsertIncome()
        {
            using (var context = new MyDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Name == "Igor Sakaguchi");
                var category = context.Categories.FirstOrDefault(c => c.Name == "Salário");

                if (user != null && category != null)
                {
                    var income = new Income
                    {
                        Amount = 5000.00M,
                        Date = DateTime.Now,
                        Description = "Salário Mensal",
                        User = user,
                        Category = category
                    };
                    context.Incomes.Add(income);
                    context.SaveChanges();
                }
            }
        }

        [TestMethod]
        public void TestListIncomes()
        {
            using (var context = new MyDbContext())
            {
                foreach (var income in context.Incomes)
                {
                    Console.WriteLine(JsonSerializer.Serialize(income));
                }
            }
        }

        

        [TestMethod]
        public void TestInsertExpense()
        {
            using (var context = new MyDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Name == "Igor Sakaguchi");
                var category = context.Categories.FirstOrDefault(c => c.Name == "Comida");
                var paymentMethod = context.PaymentMethods.FirstOrDefault(pm => pm.Name == "Nubank");

                if (user != null && category != null && paymentMethod != null)
                {
                    var expense = new Expense
                    {
                        Amount = 150.00M,
                        Date = DateTime.Now,
                        Description = "Jantar em um restaurante",
                        User = user,
                        Category = category,
                        PaymentMethod = paymentMethod
                    };
                    context.Expenses.Add(expense);
                    context.SaveChanges();
                }
            }
        }

        [TestMethod]
        public void TestListExpenses()
        {
            using (var context = new MyDbContext())
            {
                foreach (var expense in context.Expenses)
                {
                    Console.WriteLine(JsonSerializer.Serialize(expense));
                }
            }
        }
    }
}
