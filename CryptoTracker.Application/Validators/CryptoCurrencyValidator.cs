using CryptoTracker.Application.Dto;
using FluentValidation;

namespace CryptoTracker.Application.Validators
{
    public class CryptoCurrencyValidator : AbstractValidator<CryptoCurrencyDto>
    {
        public CryptoCurrencyValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(x => x.Symbol).NotEmpty().WithMessage("Symbol cannot be empty");
            RuleFor(x => x.CurrentPrice).GreaterThan(0).WithMessage("Price must be greater than zero");
        }
    }
}
