using System.Collections.Generic;
using System.ServiceModel;
using Onion.Demo.DM;
using Onion.Demo.DomainInterface;

namespace Onion.Demo.Server
{
    [ServiceContract]
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [OperationContract]
        public IList<Employee> SelectAll()
        {
            return _employeeRepository.SelectAll();
        }

        [OperationContract]
        public IList<Employee> SelectStaff()
        {
            return _employeeRepository.SelectStaff();
        }

        [OperationContract]
        public Employee Save(Employee employee)
        {
            return _employeeRepository.Save(employee);
        }

        [OperationContract]
        public void Remove(Employee employee)
        {
            _employeeRepository.Remove(employee);
        }
    }
}