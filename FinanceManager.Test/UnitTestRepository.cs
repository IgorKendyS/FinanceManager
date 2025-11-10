using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using FinanceManager.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bogus;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

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

        private static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                var builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        [TestMethod]
        public void SeedDatabaseWithRandomData()
        {
            using (var context = new FinanceDbContext())
            {
                // 1. Seed Categories (if they don't exist)
                if (!context.Categories.Any())
                {
                    var categories = new List<Category>
                    {
                        new Category { Name = "Salário", Type = "Entrada", Description = "Recebimento de salário" },
                        new Category { Name = "Freelance", Type = "Entrada", Description = "Trabalhos extras" },
                        new Category { Name = "Moradia", Type = "Saída", Description = "Aluguel, condomínio, etc." },
                        new Category { Name = "Alimentação", Type = "Saída", Description = "Supermercado, restaurantes" },
                        new Category { Name = "Transporte", Type = "Saída", Description = "Combustível, transporte público" },
                        new Category { Name = "Lazer", Type = "Saída", Description = "Cinema, shows, etc." },
                        new Category { Name = "Saúde", Type = "Saída", Description = "Farmácia, convênio" },
                        new Category { Name = "Educação", Type = "Saída", Description = "Cursos, livros" }
                    };
                    context.Categories.AddRange(categories);
                    context.SaveChanges();
                }

                // 2. Seed Users
                var existingUsers = context.Users.Count();
                if (existingUsers < 5)
                {
                    var userFaker = new Faker<User>("pt_BR")
                        .RuleFor(u => u.Name, f => f.Name.FullName())
                        .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.Name))
                        .RuleFor(u => u.PasswordHash, f => ComputeSha256Hash(f.Internet.Password()))
                        .RuleFor(u => u.Phone, f => f.Phone.PhoneNumber())
                        .RuleFor(u => u.Created, f => f.Date.Past(2))
                        .RuleFor(u => u.LastLogin, (f, u) => f.Date.Between(u.Created, DateTime.Now));

                    var newUsers = userFaker.Generate(5 - existingUsers);
                    context.Users.AddRange(newUsers);
                    context.SaveChanges();
                }

                var allUsers = context.Users.ToList();
                var expenseCategories = context.Categories.Where(c => c.Type == "Saída").ToList();
                var incomeCategories = context.Categories.Where(c => c.Type == "Entrada").ToList();

                // 3. Seed Payment Methods for each user
                foreach (var user in allUsers)
                {
                    if (!context.PaymentMethods.Any(p => p.UserId == user.Id))
                    {
                        var paymentMethodFaker = new Faker<PaymentMethod>("pt_BR")
                            .RuleFor(p => p.Name, f => f.Finance.AccountName())
                            .RuleFor(p => p.Type, "Crédito")
                            .RuleFor(p => p.UserId, user.Id);
                        
                        var pm1 = paymentMethodFaker.Generate();
                        var pm2 = new PaymentMethod { Name = "Débito", Type = "Débito", UserId = user.Id };
                        var pm3 = new PaymentMethod { Name = "Dinheiro", Type = "Dinheiro", UserId = user.Id };

                        context.PaymentMethods.AddRange(pm1, pm2, pm3);
                    }
                }
                context.SaveChanges();

                // 4. Seed Transactions for each user
                foreach (var user in allUsers)
                {
                    if (context.Transactions.Count(t => t.UserId == user.Id) > 100) continue;

                    var userPaymentMethods = context.PaymentMethods.Where(p => p.UserId == user.Id).ToList();
                    if (!userPaymentMethods.Any()) continue;

                    var transactionFaker = new Faker<Transaction>("pt_BR")
                        .RuleFor(t => t.Amount, f => f.Finance.Amount(5, 1000))
                        .RuleFor(t => t.Date, f => f.Date.Between(DateTime.Now.AddYears(-1), DateTime.Now))
                        .RuleFor(t => t.Description, f => f.Commerce.ProductName())
                        .RuleFor(t => t.UserId, user.Id)
                        .RuleFor(t => t.CategoryId, f => f.PickRandom(expenseCategories).Id)
                        .RuleFor(t => t.PaymentMethodId, f => f.PickRandom(userPaymentMethods).Id);
                    
                    var transactions = transactionFaker.Generate(150);
                    context.Transactions.AddRange(transactions);
                }
                context.SaveChanges();
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
                Assert.IsNotNull(user, "O usuário com Id=1 não foi encontrado no banco de dados de teste.");
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

                Assert.IsNotNull(user);
                Assert.IsNotNull(category);
                Assert.IsNotNull(paymentMethod);

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