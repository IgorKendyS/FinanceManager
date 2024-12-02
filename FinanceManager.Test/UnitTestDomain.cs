
using FinanceManager.Domain.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FinanceManager.Test
{
    [TestClass]
    public class UnitTestDomain
    {
        [TestMethod]
        public void TestUser()
        {
            string Name = "Igor Kendy";
            string Phone = "5518997907790";
            string Email = "igor@email.com";
            string PasswordHash = "PAgdfut65hfWEfjolnmVBc35";

            var user = new User(Name, Phone, Email, PasswordHash);

            Assert.AreEqual(Name, user.Name, "O nome não foi atribuído corretamente.");
            Assert.AreEqual(Phone, user.Phone, "O telefone não foi atribuído corretamente.");
            Assert.AreEqual(Email, user.Email, "O email não foi atribuído corretamente.");
            Assert.AreEqual(PasswordHash, user.PasswordHash, "A senha não foi atribuída corretamente.");
            Assert.IsTrue(user.Created <= DateTime.UtcNow, "A data de criação não foi atribuída corretamente.");
            Assert.IsTrue(user.LastLogin <= DateTime.UtcNow, "A data do último login não foi atribuída corretamente.");
        }

        [TestMethod]
        public void TestCategory()
        {
            string Name = "Alimentação";
            string Type = "Expense";
            string Description = "Gastos com comida";

            var category = new Category(Name, Type, Description);

            Assert.AreEqual(Name, "Alimentação");
            Assert.AreEqual(Type, category.Type);
            Assert.AreEqual(Description, category.Description);
        }

        [TestMethod]
        public void TestPaymentMethod()
        {
            string Name = "Nubank";
            string Type = "Crédito/Débito";
            decimal CardLimit = 2000.00m;

            var paymentMethod = new PaymentMethod(Name, Type, CardLimit, 1);
        }

        [TestMethod]
        public void TestExpense()
        {
            decimal Amount = 200.00m;
            DateTime Date = DateTime.UtcNow.AddHours(-3);
            string Description = "Gasolina";
            int UserId = 1;
            int CategoryId = 1;
            int PaymentMethodId = 1;

            var expense = new Expense(Amount, Date, Description, UserId, CategoryId, PaymentMethodId);
        }

        [TestMethod]
        public void TestIncome()
        {
            decimal Amount = 2000.00m;
            DateTime Date = DateTime.UtcNow.AddHours(-3);
            string Description = "Salário";
            int UserId = 1;
            int CategoryId = 1;

            var income = new Income(Amount, Date, Description, UserId, CategoryId);
        }
    }
}