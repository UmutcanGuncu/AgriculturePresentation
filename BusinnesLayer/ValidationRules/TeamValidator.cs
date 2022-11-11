using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("Takım Arkadaşı İsmi Boş Geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görev Boş Geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim Url'ı Boş Geçilemez");
            RuleFor(x => x.PersonName).MaximumLength(60).WithMessage("İsim 60 Karakterden Uzun Olamaz");
            RuleFor(x => x.Title).MaximumLength(60).WithMessage("Görev 60 Karakterden Uzun Olamaz");
            RuleFor(x => x.PersonName).MinimumLength(3).WithMessage("En Az 3 Karakterlik İsim Giriniz");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("En Az 3 Karakterlik Görev Giriniz");

        }
    }
}
