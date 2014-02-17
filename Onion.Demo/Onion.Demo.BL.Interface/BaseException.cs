using System;

namespace Onion.Demo.BL.Interface
{
    public class BaseException : ApplicationException
    {
        public BaseException(string message)
            :base(message)
        {
            
        }

        public BaseException(string message, Exception ex)
            : base(message, ex)
        {

        }
    }
}
