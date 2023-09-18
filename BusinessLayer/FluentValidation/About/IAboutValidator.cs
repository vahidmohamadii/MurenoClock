

using BusinessLayer.Dtos.About;
using FluentValidation;

namespace BusinessLayer.FluentValidation.About;

public class IAboutValidator:AbstractValidator<AboutDto>
{
    public IAboutValidator()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("")
                                  .NotNull().WithMessage("")
                                  .MaximumLength(50).WithMessage("");


        RuleFor(x => x.Description).MaximumLength(500).WithMessage("");
    }
}
