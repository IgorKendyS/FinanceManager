using FluentValidation;
using FinanceManager.Domain.Entities;

namespace FinanceManager.Service.Validators
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator() { 
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.")
                .MaximumLength(50).WithMessage("Nome pode ter no máximo 50 caractreres.");

            RuleFor(c => c.Type)
                .NotNull().WithMessage("Por favor selecione um tipo válido.");

            RuleFor(c => c.Description)
                .MaximumLength(300).WithMessage("Descrição pode ter no máximo 300 caracteres.");
        }
    }
}
