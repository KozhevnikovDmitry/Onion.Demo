using System.Collections.Generic;
using Onion.Demo.DM;

namespace Onion.Demo.DomainInterface
{
    public interface IFiscalCalc
    {
        double CalculateTax(IList<Employee> employees);
    }
}
