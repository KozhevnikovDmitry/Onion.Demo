using System.Collections.Generic;
using Onion.Demo.Client.EmployeeService;
using Onion.Demo.DomainModel;
using Onion.Demo.DomainInterface;

namespace Onion.Demo.Client
{
    public class ClientEmployeeRepository : IEmployeeRepository
    {
        private readonly IEmployeeService _employeeService;

        public ClientEmployeeRepository(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IList<Employee> SelectAll()
        {
            return _employeeService.SelectAll();
        }

        public IList<Employee> SelectStaff()
        {
            return _employeeService.SelectStaff();
        }

        public Employee Save(Employee employee)
        {
            return _employeeService.Save(employee);
        }

        public void Remove(Employee employee)
        {
            _employeeService.Remove(employee);
        }
    }
}