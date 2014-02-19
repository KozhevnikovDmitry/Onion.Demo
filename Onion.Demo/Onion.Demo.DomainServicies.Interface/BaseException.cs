using System;

namespace Onion.Demo.DomainServicies.Interface
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
