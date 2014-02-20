using System.ServiceModel;
using Onion.Demo.DomainInterface;

namespace Onion.Demo.Server
{
    [ServiceContract]
    public class FiscalService : IFiscalService
    {
        private readonly IFiscalFacade _fiscalFacade;

        public FiscalService(IFiscalFacade fiscalFacade)
        {
            _fiscalFacade = fiscalFacade;
        }

        [OperationContract]
        public double CalculateAllTax()
        {
            return _fiscalFacade.CalculateAllTax();
        }
    }
}