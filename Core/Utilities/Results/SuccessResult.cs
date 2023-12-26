using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //İşlemin başarılı olma durumu mevcut
    public class SuccessResult : Result
    {
        //Sadece mesaj geçilme durumu, zaten işlem başarılı
        public SuccessResult(string message) : base(true, message)
        {

        }

        //Hiç parametrenin geçilmediği durum
        public SuccessResult() : base(true)
        {

        }
    }
}