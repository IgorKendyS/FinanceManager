using FinanceManager.Domain.Base;

namespace FinanceManager.Domain.Entities
{
    public class Expense : BaseEntity<int>
    {
        public Expense() { }

        public Expense(decimal amount, DateTime date, string description, int userId, int categoryId, int? paymentMethodId)
        {
            Amount = amount;
            Date = date;
            Description = description;
            UserId = userId;
            CategoryId = categoryId;
            PaymentMethodId = paymentMethodId;
        }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public int UserId { get; set; }

        public int CategoryId { get; set; }

        public int? PaymentMethodId { get; set; }

        public User User { get; set; }
        public Category Category { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
