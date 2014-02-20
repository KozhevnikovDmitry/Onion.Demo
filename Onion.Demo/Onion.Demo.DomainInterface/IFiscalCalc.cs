using System.Collections.Generic;
using Onion.Demo.DomainModel;

namespace Onion.Demo.DomainInterface
{
    public interface IFiscalCalc
    {
        double CalculateTax(IList<Employee> employees);
    }
}
