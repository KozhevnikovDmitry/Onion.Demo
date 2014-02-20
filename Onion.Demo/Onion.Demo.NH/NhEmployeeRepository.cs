using System.Collections.Generic;
using System.Linq;
using NHibernate;
using NHibernate.Linq;
using Onion.Demo.DomainModel;
using Onion.Demo.DomainInterface;

namespace Onion.Demo.NH
{
    public class NhEmployeeRepository : IEmployeeRepository
    {
        private readonly ISessionFactory _sessionFactory;

        public NhEmployeeRepository(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
        }

        public IList<Employee> SelectAll()
        {
            using (var session = _sessionFactory.OpenSession())
            {
                return session.Query<Employee>().ToList();
            }
        }

        public IList<Employee> SelectStaff()
        {
            using (var session = _sessionFactory.OpenSession())
            {
                return session.Query<Employee>().Where(t => t.IsInStaff).ToList();
            }
        }

        public Employee Save(Employee employee)
        {
            using (var session = _sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(employee);
                    transaction.Commit();
                    return employee;
                }
            }
        }

        public void Remove(Employee employee)
        {
            using (var session = _sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(employee);
                    transaction.Commit();
                }
            }

        }
    }
}
