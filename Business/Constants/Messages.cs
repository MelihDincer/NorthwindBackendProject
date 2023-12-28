using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //Bir kere newlendikten sonra bellekte dursun ve herkes onu kullansın diye 'static' keywordü kullanıldı.
    public static class Messages
    {
        public static string ProductAdded = "Ürün başarıyla eklendi."; //Business.Concrete içerisindeki ProductManager'da ilk kez kullandık.
        public static string ProductDeleted = "Ürün başarıyla silindi."; //Business.Concrete içerisindeki ProductManager'da ilk kez kullandık.
        public static string ProductUpdated = "Ürün başarıyla güncellendi."; //Business.Concrete içerisindeki ProductManager'da ilk kez kullandık.
        public static string UserNotFound = "Kullanıcı bulunamadı."; //Business.Concrete içerisindeki AuthManager'da ilk kez kullandık.
        public static string PasswordError = "Şifre hatalı."; //Business.Concrete içerisindeki AuthManager'da ilk kez kullandık.
        public static string SuccessfulLogin = "Sisteme giriş başarılı."; //Business.Concrete içerisindeki AuthManager'da ilk kez kullandık.
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut."; //Business.Concrete içerisindeki AuthManager'da ilk kez kullandık.
        public static string UserRegistred = "Kullanıcı başarıyla kaydedildi."; //Business.Concrete içerisindeki AuthManager'da ilk kez kullandık.
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu"; //Business.Concrete içerisindeki AuthManager'da ilk kez kullandık.
    }
}
