using FluentValidation;
using FinanceManager.Domain.Entities;

namespace FinanceManager.Service.Validators
{
    public class PaymentMethodValidator : AbstractValidator<PaymentMethod>
    {
        public PaymentMethodValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .MaximumLength(50).WithMessage("O nome pode ter no máximo 50 caracteres.");

            RuleFor(p => p.Type)
                .NotNull().WithMessage("Por favor selecione um tipo válido.");

            RuleFor(p => p.CardLimit)
                .GreaterThan(0).When(p => p.CardLimit.HasValue)
                .WithMessage("O limite do cartão deve ser maior que zero.");

            RuleFor(p => p.UserId)
                .GreaterThan(0).WithMessage("ID de usuário inválido.");
        }
    }
}
