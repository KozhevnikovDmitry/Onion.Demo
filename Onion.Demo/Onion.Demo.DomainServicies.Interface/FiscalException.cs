using System;

namespace Onion.Demo.DomainServicies.Interface
{
    public class FiscalException : BaseException
    {
        public FiscalException(string message, Exception ex)
            :base(message, ex)
        {
            
        }
    }
}