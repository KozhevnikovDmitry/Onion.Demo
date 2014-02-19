using System.Collections.Generic;
using System.ServiceModel;
using Onion.Demo.DM;

namespace Onion.Demo.Server
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