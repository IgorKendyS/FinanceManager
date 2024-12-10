using FinanceManager.Domain.Base;

namespace FinanceManager.Domain.Entities
{
    public class Category : BaseEntity<int>
    {
        public Category()
        {
        }

        public Category(int id, string name, string type, string? description = null) : base(id)
        {
            Name = name;
            Type = type;
            Description = description;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public string? Description { get; set; }
    }
}
