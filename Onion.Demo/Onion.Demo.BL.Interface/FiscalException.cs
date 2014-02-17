using System;

namespace Onion.Demo.BL.Interface
{
    public class FiscalException : BaseException
    {
        public FiscalException(string message, Exception ex)
            :base(message, ex)
        {
            
        }
    }
}