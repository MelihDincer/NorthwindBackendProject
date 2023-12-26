using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IResult
    {
        //İşlem Başarılı mı Değil mi?
        bool Success { get; }

        //Hatalı veya başarılı mesajı geçilecek.
        string Message { get; }
    }
}
