using System.Collections.Generic;
using Onion.Demo.DomainModel;
using Onion.Demo.DomainInterface;
using Onion.Demo.ServiceInterface;

namespace Onion.Demo.Server
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IList<Employee> SelectAll()
        {
            return _employeeRepository.SelectAll();
        }

        public IList<Employee> SelectStaff()
        {
            return _employeeRepository.SelectStaff();
        }

        public Employee Save(Employee employee)
        {
            return _employeeRepository.Save(employee);
        }

        public void Remove(Employee employee)
        {
            _employeeRepository.Remove(employee);
        }
    }
}