using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Onion.Demo.BL.Interface;
using Onion.Demo.DM;

namespace Onion.Demo.EF
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DbContextFactory _dbContextFactory;

        public EmployeeRepository(DbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public IList<Employee> SelectAll()
        {
            try
            {
                using (var context = _dbContextFactory.Create())
                {
                    return context.Employees.ToList();
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
                using (var context = _dbContextFactory.Create())
                {
                    return context.Employees.Where(t => t.IsInStaff).ToList();
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
                using (var context = _dbContextFactory.Create())
                {
                    context.Employees.AddOrUpdate(employee);
                    context.SaveChanges();
                    return employee;
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
                using (var context = _dbContextFactory.Create())
                {
                    context.Employees.Remove(employee);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new RepositoryException("Error occurs during rempve employee", ex);
            }

        }
    }
}
