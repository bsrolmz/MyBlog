using Microsoft.AspNetCore.Identity;

namespace MyBlog.PresentationLayer.Models
{
    public class CustomIdentityErrorValidator:IdentityErrorDescriber
    {
        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError()
            {
                Code = "DuplicateEmail",
                Description = "Bu Email Adresi Sistemde Zaten Kayıtlı!"
            };
        }
        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresDigit",
                Description = "Lütfen En Az 1 Tane Rakam Giriniz!"
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description = "Lütfen En Az 1 Tane Küçük Harf Girişi Yapınız!"
            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = "Lütfen En Az 1 Tane Büyük Harf Girişi Yapınız!"
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Lütfen En Az 1 Tane Sembol Girişi Yapınız!"
            };
        }
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = "Lütfen En Az 6 Karakter Girişi Yapınız!"
            };
        }
    }
} 
