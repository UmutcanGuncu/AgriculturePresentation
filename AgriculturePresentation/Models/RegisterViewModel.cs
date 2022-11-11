using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Giriniz")]
        public string userName { get; set; }
        [Required(ErrorMessage ="Lütfen Şifrenizi Giriniz")]
        public string password { get; set; }
        [Required(ErrorMessage ="Lütfen Şifrenizi Tekrar Giriniz")]
        [Compare("password",ErrorMessage ="Girdiğiniz Şifreler Birbiri İle Eşleşmiyor")]
        public string confirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen E Posta Adresinizi Giriniz")]
        public string mail { get; set; }
    }
}
