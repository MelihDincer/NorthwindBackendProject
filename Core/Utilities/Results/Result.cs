using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //Genellikle Constructor üzerinden yönetilir.

        //Kullanıcı işlem başarılı mı ve bu işlemin mesajını geçmek isteyebilir.
        public Result(bool success, string message):this(success) //this(success) yapmasaydık Message gibi yeşil renkte yazılan kodu yazmamız gerekirdi. Aynı şeyi gerçekleştirmiş olduk.
        {
            Message = message;
            //Success = success;
        }

        //Kullanıcı sadece işlem başarılı mı değil mi bunu geçmek isteyebilir.
        public Result(bool success)
        {
            Success = success;
        } 
        public bool Success { get; }
        public string Message { get; }
    }
}