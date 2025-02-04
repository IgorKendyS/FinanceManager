namespace FinanceManager.App.Models
{
    public class PaymentMethodModel
    {
        public PaymentMethodModel()
        {
            User = new UserModel();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; } // Ex: "Credit", "Debit", "Cash"
        public decimal? CardLimit { get; set; }

        public int UserId { get; set; }
        public UserModel User { get; set; }
    }
}
