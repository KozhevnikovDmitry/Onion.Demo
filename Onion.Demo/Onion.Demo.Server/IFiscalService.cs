using System.ServiceModel;

namespace Onion.Demo.Server
{
    [ServiceContract]
    public interface IFiscalService
    {
        [OperationContract]
        double CalculateAllTax();
    }
}
