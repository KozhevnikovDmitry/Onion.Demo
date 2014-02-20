using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Onion.Demo.DomainModel;
using Onion.Demo.DomainInterface;

namespace Onion.Demo.EF
{
    public class EfEmployeeRepository : IEmployeeRepository
    {
        private readonly DbContextFactory _dbContextFactory;

        public EfEmployeeRepository(DbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public IList<Employee> SelectAll()
        {
            using (var context = _dbContextFactory.Create())
            {
                return context.Employees.ToList();
            }
        }

        public IList<Employee> SelectStaff()
        {
            using (var context = _dbContextFactory.Create())
            {
                return context.Employees.Where(t => t.IsInStaff).ToList();
            }
        }

        public Employee Save(Employee employee)
        {
            using (var context = _dbContextFactory.Create())
            {
                if (employee.Id == new Guid())
                {
                    employee.Id = Guid.NewGuid();
                }

                context.Employees.AddOrUpdate(employee);
                context.SaveChanges();
                return employee;
            }
        }

        public void Remove(Employee employee)
        {
            using (var context = _dbContextFactory.Create())
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
        }
    }
}
