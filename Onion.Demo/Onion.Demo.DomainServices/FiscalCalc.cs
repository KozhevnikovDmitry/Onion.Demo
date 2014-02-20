using System.Collections.Generic;
using Onion.Demo.DM;
using Onion.Demo.DomainInterface;

namespace Onion.Demo.DomainServices
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
                    continue;
                }

                if (employee.Salary > 10000)
                {
                    result += 0.35 * employee.Salary;
                    continue;
                }

                result += 0.25 * employee.Salary;
            }

            return result;
        }
    }
}
