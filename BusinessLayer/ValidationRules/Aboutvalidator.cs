using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class Aboutvalidator : AbstractValidator<About>
    {
        public Aboutvalidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmını boş geçiremezsiniz...!");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen Görsel Seçiniz...!");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Lütfen en az 50 karakterlik açıklama bilgisini giriniz...!");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Lütfen Açıklamayı Kısaltın...!");

        }
    }
}