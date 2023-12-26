using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //İşlemin başarısız olma durumu mevcut
    public class ErrorDataResult<T> : DataResult<T>
    {
        //İşlem başarısız olarak kabul edileceğinden, bool success parametresi geçilmeyecektir.
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }

        //Bool success ve mesaj parametresiz hali.
        public ErrorDataResult(T data) : base(data, false)
        {

        }

        //Sadece mesajın geçildiği durum.
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }

        //Hiç parametrenin geçilmediği durum
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}