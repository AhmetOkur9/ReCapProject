using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Ürün eklendi";
        public static string CarNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarListed = "Ürün listelendi";
        public static string CarUpdated = "Ürün güncellendi";
        public static string CarDeleted = "Araba Silindi";

        public static string RentalSuccess = "Araba kiralama başarılı";
        public static string RentalFailed = "Araba kiralama başarısız";
        public static string RentalUpdated = "Araba kiralama bilgileri güncellendi";
        public static string RentalCarListed = "Seçtiğiniz Id ye uyan araba listelendi";
        public static string CarIsRented = "Seçtiğiniz araba şuan başkası tarafından kiralanmış halde";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserIdListed = "Kullanıcı Id'si listenlendi";
        public static string UserListed = "Kullanıcı listelendi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserDeleted = "Kullanıcı Silindi";

        public static string ClaimSuccess = "Talep Başarılı";
        public static string AccessTokenCreated = "Access Token başarı ile oluşturuldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre Hatalı";
        public static string UserAlreadyExist = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kayıt edildi";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
    }
}
