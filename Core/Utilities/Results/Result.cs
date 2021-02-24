using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        

        public Result(bool success, string message):this(success) //otomatik olarak aşağıdaki success kodları da çalışıyor
        {
            Message = message;            
        }

        public Result(bool success) // do not repeat yourself sebebiyle yukarıdaki kodlar yazıldı iki yere de success yazılmadı
        {            
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
