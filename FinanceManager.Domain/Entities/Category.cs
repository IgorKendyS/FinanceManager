using FinanceManager.Domain.Base;

namespace FinanceManager.Domain.Entities
{
    public class Category : BaseEntity<int>
    {
        public Category() { }

        public Category(string name, string type, string description)
        {
            Name = name;
            Type = type;
            Description = description;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}