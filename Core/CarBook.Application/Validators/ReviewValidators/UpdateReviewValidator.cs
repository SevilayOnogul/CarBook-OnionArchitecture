using CarBook.Application.Features.Mediator.Commands.ReviewCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Validators.ReviewValidators
{
    public class UpdateReviewValidator:AbstractValidator<UpdateReviewCommand>
    {
        public UpdateReviewValidator()
        {
            RuleFor(x => x.CustomerName).NotEmpty().WithMessage("Lütfen müşteri adını boş geçmeyiniz!");
            RuleFor(x => x.CustomerName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapınız!");
            RuleFor(x => x.RaytingValue).NotEmpty().WithMessage("Lütfen puan değerini boş geçmeyiniz");
            RuleFor(x => x.Comment).NotEmpty().WithMessage("Lütfen yorum değerini boş geçmeyiniz.");
            RuleFor(x => x.Comment).MinimumLength(10).WithMessage("Lütfen yorum kısmına en az 10 karakter veri girişi yapınız");
            RuleFor(x => x.Comment).MaximumLength(500).WithMessage("Lütfen yorum kısmına en fazla 500 karakter veri girişi yapınız");
            RuleFor(x => x.ReviewId).NotEmpty().WithMessage("Güncellenecek yorumun ID değeri boş olamaz!");
            RuleFor(x => x.RaytingValue).InclusiveBetween(1, 5).WithMessage("Puan değeri 1 ile 5 arasında olmalıdır!");


        }
    }
}
