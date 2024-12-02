using FinanceManager.Domain.Entities;
using FluentValidation;

namespace FinanceManager.Service.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator() { 
            
        }
    }
}
