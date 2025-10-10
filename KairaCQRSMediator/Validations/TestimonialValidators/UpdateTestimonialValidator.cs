using FluentValidation;
using KairaCQRSMediator.Features.CQRS.Commands.TestimonialCommands;

namespace KairaCQRSMediator.Validations.TestimonialValidators
{
    public class UpdateTestimonialValidator : AbstractValidator<UpdateTestimonialCommand>
    {
        public UpdateTestimonialValidator()
        {
            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("Ad Soyad boş geçilemez.");
            RuleFor(x => x.Comment).NotEmpty().WithMessage("Yorum boş geçilemez").MaximumLength(150).WithMessage("Yorum en fazla 150 karakter olabilir.");
        }
    }
}
