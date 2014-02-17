using System;

namespace Onion.Demo.BL.Interface
{
    public class RepositoryException : BaseException
    {
        public RepositoryException(string message, Exception ex) : base(message, ex)
        {
        }
    }
}
