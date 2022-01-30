using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(w => w.WriterName).NotEmpty().WithMessage("Adı Soyadı kısmı boş geçilemez!");
            RuleFor(w => w.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez!");
            RuleFor(w => w.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez!");
            RuleFor(w => w.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter giriniz!");
            RuleFor(w => w.WriterName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter giriniz!");
            RuleFor(w => w.WriterCity).NotEmpty().WithMessage("Lütfen şehir seçiniz!");
        }
    }
}
