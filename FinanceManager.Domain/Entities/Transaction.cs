using FinanceManager.Domain.Base;

namespace FinanceManager.Domain.Entities
{
    public class Transaction : BaseEntity<int>
    {
        public Transaction()
        {
        }

        public Transaction(
            int id,
            decimal amount,
            DateTime date,
            int userId,
            int categoryId,
            string? description = null,
            int? paymentMethodId = null
        ) : base(id)
        {
            Amount = amount;
            Date = date;
            UserId = userId;
            CategoryId = categoryId;
            Description = description;
            PaymentMethodId = paymentMethodId;
        }

        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public int? PaymentMethodId { get; set; }

        // Propriedades de Navegação (opcional)
        public User? User { get; set; }
        public Category? Category { get; set; }
        public PaymentMethod? PaymentMethod { get; set; }
    }
}
