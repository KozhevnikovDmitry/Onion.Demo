using Onion.Demo.BL.Interface;

namespace Onion.Demo.Server
{
    public class FiscalService : IFiscalService
    {
        private readonly IFiscalFacade _fiscalFacade;

        public FiscalService(IFiscalFacade fiscalFacade)
        {
            _fiscalFacade = fiscalFacade;
        }

        public double CalculateAllTax()
        {
            return _fiscalFacade.CalculateAllTax();
        }
    }
}