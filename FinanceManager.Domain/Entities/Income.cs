using FinanceManager.Domain.Base;

namespace FinanceManager.Domain.Entities
{
    public class Income : BaseEntity<int>
    {
        public Income() { }

        public Income(decimal amount, DateTime date, string description, int userId, int categoryId)
        {
            Amount = amount;
            Date = date;
            Description = description;
            UserId = userId;
            CategoryId = categoryId;
        }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public int UserId { get; set; } 

        public int CategoryId { get; set; } 

        public User User { get; set; }
        public Category Category { get; set; }
    }
}