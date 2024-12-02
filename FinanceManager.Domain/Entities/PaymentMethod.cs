using FinanceManager.Domain.Base;

namespace FinanceManager.Domain.Entities
{
    public class PaymentMethod : BaseEntity<int>
    {
        public PaymentMethod() { }

        public PaymentMethod(string name, string type, decimal? cardLimit, int userId)
        {
            Name = name;
            Type = type;
            CardLimit = cardLimit;
            UserId = userId;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public decimal? CardLimit { get; set; }
        
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
