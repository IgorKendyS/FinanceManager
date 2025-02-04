using FluentValidation;
using FinanceManager.Domain.Entities;

namespace FinanceManager.Service.Validators
{
    public class TransactionValidator : AbstractValidator<Transaction>
    {
        public TransactionValidator()
        {
            RuleFor(t => t.Amount)
                .GreaterThan(0).WithMessage("O valor deve ser maior que zero.");

            RuleFor(t => t.Date)
                .NotEmpty().WithMessage("Por favor informe a data.");

            RuleFor(t => t.Description)
                .MaximumLength(255).WithMessage("A descrição pode ter no máximo 255 caracteres.");

            RuleFor(t => t.UserId)
                .GreaterThan(0).WithMessage("ID de usuário inválido.");

            RuleFor(t => t.CategoryId)
                .GreaterThan(0).WithMessage("ID de categoria inválido.");

            RuleFor(t => t.PaymentMethodId)
                .GreaterThan(0).When(t => t.PaymentMethodId.HasValue)
                .WithMessage("ID do método de pagamento inválido.");
        }
    }
}
