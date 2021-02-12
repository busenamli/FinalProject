using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        public Result(bool success, string message)
        {
            Message = message;
            Success = success;
        }

        //get --> Readonly, sadece constructer'da set edilebilir
        public bool Success { get; }

        public string Message { get; } 
    }
}
