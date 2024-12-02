using FinanceManager.Domain.Base;

namespace FinanceManager.Domain.Entities
{
    public class User : BaseEntity<int>
    {
        public User() { }

        public User(string name, string phone, string email, string passwordHash)
        {
            Name = name;
            Phone = phone;
            Email = email;
            PasswordHash = passwordHash;
            Created = DateTime.UtcNow;
            LastLogin = DateTime.UtcNow;
        }

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
