using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.ValidationRules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x => x.ImageTitle).NotEmpty().WithMessage("Görsel Başlığı Boş Geçilemez");
            RuleFor(x => x.ImageTitle).MaximumLength(30).WithMessage("Görsel Başlığı En Fazla 30 Karakter Olmalı");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Görsel Açıklaması Boş Geçilemez");
            RuleFor(x => x.Description).MaximumLength(50).WithMessage("Görsel Açıklaması En Fazla 50 Karakter Olmalı");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel Linki Boş Geçilemez");
        }
    }
}
