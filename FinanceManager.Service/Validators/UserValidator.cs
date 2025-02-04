using FluentValidation;
using FinanceManager.Domain.Entities;

namespace FinanceManager.Service.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Name)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .MaximumLength(50).WithMessage("O nome pode ter no máximo 50 caracteres.");

            RuleFor(u => u.Phone)
                .Matches(@"^\+?[0-9]{10,16}$").When(u => !string.IsNullOrEmpty(u.Phone))
                .WithMessage("Número de telefone inválido.");

            RuleFor(u => u.Email)
                .NotEmpty().WithMessage("Por favor informe o e-mail.")
                .EmailAddress().WithMessage("E-mail inválido.")
                .MaximumLength(100).WithMessage("O e-mail pode ter no máximo 100 caracteres.");

            RuleFor(u => u.PasswordHash)
                .NotEmpty().WithMessage("Por favor informe a senha.")
                .MaximumLength(255).WithMessage("A senha pode ter no máximo 255 caracteres.");
        }
    }
}
