using System.ServiceModel;

namespace Onion.Demo.ServiceInterface
{
    [ServiceContract]
    public interface IFiscalService
    {
        [OperationContract]
        double CalculateAllTax();
    }
}
