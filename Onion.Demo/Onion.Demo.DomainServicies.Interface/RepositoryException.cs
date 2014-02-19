using System;

namespace Onion.Demo.DomainServicies.Interface
{
    public class RepositoryException : BaseException
    {
        public RepositoryException(string message, Exception ex) : base(message, ex)
        {
        }
    }
}
