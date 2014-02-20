using System.Collections.Generic;
using Onion.Demo.DM;

namespace Onion.Demo.DomainInterface
{
    public interface IEmployeeService
    {
        IList<Employee> SelectAll();

        IList<Employee> SelectStaff();

        Employee Save(Employee employee);

        void Remove(Employee employee);
    }
}