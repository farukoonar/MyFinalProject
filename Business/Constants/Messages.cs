using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi!";
        public static string ProductNameInvalid = "Ürün ismi geçersiz!";
        public static string MaintenanceTime = "Sistem bakımda!";
        public static string ProductListed = "Ürünler listelendi!";
        public static string ProductCountOfCategoryError="Kategorideki ürün limiti aşıldı!";
        public static string ProductUpdated="Ürün güncellendi!";
        public static string ProductNameAlreadyExists = "Bu isimde zaten bir ürün bulunmakta!";
        public static string CategoryLimitExceded="Kategori limiti aşıldı!";
        public static string AuthorizationDenied="Yetkiniz yok!";
        public static string UserRegistered="Kayıt olundu!";
        public static string UserNotFound = "Kullanıcı bulunamadı!";
        public static string PasswordError = "Hatalı şifre!";
        public static string SuccessfulLogin = "Giriş başarılı!";
        public static string UserAlreadyExists = "Kullanıcı mevcut!";
        public static string AccessTokenCreated = "Token oluşturuldu!";
    }
}
