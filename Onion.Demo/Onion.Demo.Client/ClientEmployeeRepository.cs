using System.Collections.Generic;
using Onion.Demo.BL.Interface;
using Onion.Demo.Client.EmployeeService;
using Onion.Demo.DM;

namespace Onion.Demo.Client
{
    internal class ClientEmployeeRepository : IEmployeeRepository
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