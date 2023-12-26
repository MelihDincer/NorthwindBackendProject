using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //İşlemin başarılı olma durumu mevcut
    public class SuccessDataResult<T> : DataResult<T>
    {
        //İşlem başarılı olarak kabul edileceğinden, bool success parametresi geçilmeyecektir.
        public SuccessDataResult(T data, string message) : base(data, true)
        {

        }

        //Bool success ve mesaj parametresiz hali.
        public SuccessDataResult(T data) : base(data, true)
        {

        }

        //Sadece mesajın geçildiği durum.
        public SuccessDataResult(string message) : base(default, true, message)
        {

        }

        //Hiç parametrenin geçilmediği durum
        public SuccessDataResult() : base(default, true)
        {

        }
    }
}