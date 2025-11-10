using FinanceManager.Domain.Base;

namespace FinanceManager.Domain.Entities
{
    public class PaymentMethod : BaseEntity<int>
    {
        public PaymentMethod()
        {
        }

        public PaymentMethod(int id, string name, string type, int userId, decimal? cardLimit = null) : base(id)
        {
            Name = name;
            Type = type;
            UserId = userId;
            CardLimit = cardLimit;
        }

        public string Name { get; set; } = null!;
        public string Type { get; set; } = null!; // Ex: "Credit", "Debit", "Cash"
        public decimal? CardLimit { get; set; }
        public int UserId { get; set; }

        public User? User { get; set; }
    }
}
