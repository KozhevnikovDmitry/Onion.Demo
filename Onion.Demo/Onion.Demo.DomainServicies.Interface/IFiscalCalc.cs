using System.Collections.Generic;
using Onion.Demo.DM;

namespace Onion.Demo.DomainServicies.Interface
{
    public interface IFiscalCalc
    {
        double CalculateTax(IList<Employee> employees);
    }
}
