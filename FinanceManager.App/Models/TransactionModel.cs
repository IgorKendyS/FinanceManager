namespace FinanceManager.App.Models
{
    public class TransactionModel
    {
        public TransactionModel()
        {
            PaymentMethod = new PaymentMethodModel();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string? Description { get; set; }
        public bool IsRecurring { get; set; }

        public int UserId { get; set; }
        public string? User { get; set; }

        public int CategoryId { get; set; } 
        public string? Category { get; set; }

        public int PaymentMethodId { get; set; }
        public PaymentMethodModel PaymentMethod { get; set; }
    }
}
