using System.Collections.Generic;
using Onion.Demo.DM;

namespace Onion.Demo.BL.Interface
{
    public interface IFiscalCalc
    {
        double CalculateTax(IList<Employee> employees);
    }
}
