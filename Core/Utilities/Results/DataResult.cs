using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        //Data ile birlikte mesaj ve durum da geçilecek ise;
        public DataResult(T data, bool success, string message) : base(success, message)
        {
            Data = data;
        }

        //Data ile sadece durum da geçilecek ise;
        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }

        public T Data { get; }
    }
}
