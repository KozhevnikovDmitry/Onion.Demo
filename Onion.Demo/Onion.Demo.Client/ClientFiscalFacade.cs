using Onion.Demo.Client.FiscalService;
using Onion.Demo.DomainInterface;

namespace Onion.Demo.Client
{
    public class ClientFiscalFacade : IFiscalFacade
    {
        private readonly IFiscalService _fiscalService;

        public ClientFiscalFacade(IFiscalService fiscalService)
        {
            _fiscalService = fiscalService;
        }

        public double CalculateAllTax()
        {
            return _fiscalService.CalculateAllTax();
        }
    }
}
