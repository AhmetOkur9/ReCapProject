﻿using Core.Entities.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //Car Manager
        public static string CarAdded = "Ürün eklendi";
        public static string CarNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarListed = "Ürün listelendi";
        public static string CarUpdated = "Ürün güncellendi";
        public static string CarDeleted = "Araba Silindi";

        //Rental Manager
        public static string RentalSuccess = "Araba kiralama başarılı";
        public static string RentalFailed = "Araba kiralama başarısız";
        public static string RentalUpdated = "Araba kiralama bilgileri güncellendi";
        public static string RentalCarListed = "Seçtiğiniz Id ye uyan araba listelendi";
        public static string CarIsRented = "Seçtiğiniz araba şuan başkası tarafından kiralanmış halde";
        public static string RentalDtoListed = "Kiralama biligileri listelendi";
        public static string ThisCarAlreadyRented ="Araba belirtilen tarhilerde kiralı";
        public static string CarSuccessRented = "Kullanıcı ödeme sayfasına yönlendiriliyor";


        //User Manager
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserIdListed = "Kullanıcı Id'si listenlendi";
        public static string UserListed = "Kullanıcı listelendi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserDeleted = "Kullanıcı Silindi";

        //Claim
        public static string ClaimSuccess = "Talep Başarılı";
        public static string AccessTokenCreated = "Access Token başarı ile oluşturuldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre Hatalı";
        public static string UserAlreadyExist = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kayıt edildi";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";

        //Color Manager
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorListed = "Renkler listelendi";

        //Brand Manager
        public static string BrandListed = "Markalar listelendi";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";

        //Customer Manager
        public static string CustomerListed = "Müşteriler listelendi";
        public static string CustomerAdded = "Müşteriler eklendi";
        public static string CustomerDeleted = "Müşteriler silindi";
        public static string CustomerUpdated = "Müşteriler güncellendi";
        internal static string CarDetailListed = "Arabalar tüm detayları ile listelendi";

        public static string Succeed = "Başarılı";
        public static string CarNotFound = "Araba bulunamadı";

        //CarImageManager
        public static string CarImageAdded = "Araba Resmi eklendi";
        public static string Error = "Araba Resmi Yüklenemedi";
        public static string CarImagesLimitExceded = "Resim Yükleme Limitine Ulaşıldı";

        //PaymentManager
        public static string CreditCardAdded ="Kredi kartı eklendi";
        public static string CreditCardDeleted = "Kredi kartı silindi";
        public static string CreditCardListed = "Kredi kartı listelendi";
        public static string CreditCardUpdated = "Kredi kartı güncellendi";

        //BankPaymentManager
        public static string PaymentSuccess = "Ödeme başarı ile gerçekleşti";
    }
}
