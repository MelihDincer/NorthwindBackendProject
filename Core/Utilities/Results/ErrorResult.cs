using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //İşlemin başarısız olma durumu mevcut
    public class ErrorResult : Result
    {
        //Sadece mesaj geçilme durumu, zaten işlem başarılı
        public ErrorResult(string message) : base(false, message)
        {

        }

        //Hiç parametrenin geçilmediği durum
        public ErrorResult() : base(false)
        {

        }
    }
}