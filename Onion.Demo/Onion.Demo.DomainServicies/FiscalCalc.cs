using System.Collections.Generic;
using Onion.Demo.DM;
using Onion.Demo.DomainInterface;

namespace Onion.Demo.DomainServicies
{
    public class FiscalCalc : IFiscalCalc
    {
        public double CalculateTax(IList<Employee> employees)
        {
            double result = 0;
            foreach (var employee in employees)
            {
                if (employee.Salary < 1000)
                {
                    result += 0.1 * employee.Salary;
                    break;
                }

                if (employee.Salary > 10000)
                {
                    result += 0.35 * employee.Salary;
                    break;
                }

                result += 0.25 * employee.Salary;
            }

            return result;
        }
    }
}
