using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //Bir kere newlendikten sonra bellekte dursun ve herkes onu kullansın diye 'static' keywordü kullanıldı.
    public static class Messages
    {
        public static string ProductAdded = "Ürün başarıyla eklendi.";
        public static string ProductDeleted = "Ürün başarıyla silindi.";
        public static string ProductUpdated = "Ürün başarıyla güncellendi.";
    }
}
