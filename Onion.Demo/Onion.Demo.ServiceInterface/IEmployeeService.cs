using System.Collections.Generic;
using System.ServiceModel;
using Onion.Demo.DomainModel;

namespace Onion.Demo.ServiceInterface
{
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        IList<Employee> SelectAll();

        [OperationContract]
        IList<Employee> SelectStaff();

        [OperationContract]
        Employee Save(Employee employee);

        [OperationContract]
        void Remove(Employee employee);
    }
}