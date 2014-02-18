using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using NHibernate.Linq;
using Onion.Demo.BL.Interface;
using Onion.Demo.DM;

namespace Onion.Demo.NH
{
    internal class NhEmployeeRepository : IEmployeeRepository
    {
        private readonly ISessionFactory _sessionFactory;

        public NhEmployeeRepository(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
        }

        public IList<Employee> SelectAll()
        {
            try
            {
                using (var session = _sessionFactory.OpenSession())
                {
                    return session.Query<Employee>().ToList();
                }
            }
            catch (Exception ex)
            {
                throw new RepositoryException("Error occurs during select employees", ex);
            }
        }

        public IList<Employee> SelectStaff()
        {
            try
            {
                using (var session = _sessionFactory.OpenSession())
                {
                    return session.Query<Employee>().Where(t => t.IsInStaff).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new RepositoryException("Error occurs during select employees", ex);
            }
        }

        public Employee Save(Employee employee)
        {
            try
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
            catch (Exception ex)
            {
                throw new RepositoryException("Error occurs during save employee", ex);
            }
        }

        public void Remove(Employee employee)
        {
            try
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
            catch (Exception ex)
            {
                throw new RepositoryException("Error occurs during rempve employee", ex);
            }

        }
    }
}
