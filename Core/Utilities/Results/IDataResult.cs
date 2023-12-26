using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<out T> : IResult //out kullanmasaydık da olurdu.
    {
        //Gönderilecek data aşağıdaki Data ile döndürülecektir.
        T Data { get; } 
    }
}