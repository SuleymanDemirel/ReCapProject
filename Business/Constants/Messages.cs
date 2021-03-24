using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarsListed = "Arabalar Listelendi";
        public static string CarNotBeRented = "Araba kiralamaya uygun değil";
        public static string CarRentedSuccessfull = "Araba kiralandı";
        public static string CustomerInformationListed = "Kiralanan araba bilgileri listelendi.";
        public static string CarUpdated = "Araç başarıyla güncellendi!";
        public static string CarPriceInvalid = "Araç fiyatı 0'dan büyük olmalıdır.";
        public static string CarNameAlreadyExists = "Bu isimde başka bir ürün var";
        public static string CarAddedError = "Lütfen araba ismini 2 karakter dahil olmak üzere üstünde ve günlük fiyatı da 0'dan fazla olacak şekilde giriniz!!!";
        public static string CarDeleted = "Araba silindi";
        public static string CarGetById = "Araba getirildi";
        public static string CarGetAll = "Arabalar getirildi";
        public static string CarGetDetailsDTO = "Detaylı araba bilgisi getirildi";
        public static string CarGetBrandId = "Seçilen markaya göre arabalar getirildi";
        public static string CarGetColorId = "Seçilen renge göre arabalar getirildi";

        public static string RentalAddedError = "Rental Added error";
        public static string RentalAdded = "Rental Added";
        public static string RentalUpdated = "Rental Updated";
        public static string RentalUpdatedReturnDateError = "Rental updated return data error";
        public static string RentalUpdatedReturnDate = "Rental uptadet return date";

        

            
        public static string CarImagesListed = "Araç görselleri listelendi!";
        public static string CarImageUpdated = "Araç görseli güncellendi!";
        public static string CarImageDeleted = "Araç görseli silindi!";
        public static string CarImageAdded = "Araç görseli eklendi!";
        public static string CarImageLimitExceded = "Bir araç için yalnızca 5 adet resim yükleyebilirsiniz!";
        public static string CarImageCarIdEmpty = "Geçersiz ID!";

        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatalı";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten var ";
        public static string AccessTokenCreated = "Access Token Created";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UsersListed = "Kullanıcılar listelendi.";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandGet = "Marka getirildi";
        public static string BrandGetAll = "Markalar getirildi";
        public static string BrandListed = "Markalar listelendi";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerGet = "Müşter getirildii";
        public static string CustomerGetAll = "Müşteriler getirildi";
        public static string CustomerGetByUserId = "Müşteri, Kullanıcıya göre getirildi";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorGet = "Renk getirildi";
        public static string ColorGetAll = "Renkler getirildi";

    }
}
