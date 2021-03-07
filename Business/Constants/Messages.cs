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

        public static string CarNameAlreadyExists = "Bu isimde başka bir ürün var";
        
        public static string CarImagesListed = "Araç görselleri listelendi!";
        public static string CarImageUpdated = "Araç görseli güncellendi!";
        public static string CarImageDeleted = "Araç görseli silindi!";
        public static string CarImageAdded = "Araç görseli eklendi!";
        public static string CarImageLimitExceded = "Bir araç için yalnızca 5 adet resim yükleyebilirsiniz!";
        public static string CarImageCarIdEmpty = "Geçersiz ID!";
    }
}
