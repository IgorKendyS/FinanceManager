using FinanceManager.Domain.Base;

namespace FinanceManager.Domain.Entities
{
    public class User : BaseEntity<int>
    {
        public User()
        {
        }

        public User(int id, string name, string email, string passwordHash, DateTime created, DateTime lastLogin, string? phone = null) : base(id)
        {
            Name = name;
            Email = email;
            PasswordHash = passwordHash;
            Created = created;
            LastLogin = lastLogin;
            Phone = phone;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string? Phone { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
