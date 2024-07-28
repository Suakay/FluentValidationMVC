using FluentValidation;
using FluentValidationMVC.Models;
namespace FluentValidationMVC.Validators.PassengerValidators
{
    public class PassengerCreateValidation : AbstractValidator<PassengerCreateVM>
    {
        public PassengerCreateValidation()
        {
            RuleFor(p => p.FirstName).NotEmpty().WithMessage("lÜTFEN BOŞ BIRAKMAYIN")
                .MaximumLength(15).WithMessage("En fazla 15 karaktr girebilrsin")
                .MinimumLength(3).WithMessage("Mininmum 3 karakter girebiliris.");
            RuleFor(p => p.LastName).NotEmpty().WithMessage("lÜTFEN BOŞ BIRAKMAYIN")
               .MaximumLength(15).WithMessage("En fazla 15 karakter girebilirsin")
               .MinimumLength(3).WithMessage("Mininmum 3 karakter girebilirsin.");
            RuleFor(p => p.TicketNumber).NotEmpty().WithMessage("lÜTFEN BOŞ BIRAKMAYIN")

             .Must(BeAnInt).WithMessage("tamsayı gir")
            .Matches(@"^\d+$");
            RuleFor(p => p.Gender).NotEmpty().WithMessage("Lütfen Boş Bırakmayın");

        }
        private bool BeAnInt(string ticketNumber)
        {
            return int.TryParse(ticketNumber, out _);
        }
    }

}
