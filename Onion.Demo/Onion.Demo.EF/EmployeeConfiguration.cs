using System.Data.Entity.ModelConfiguration;
using Onion.Demo.DomainModel;

namespace Onion.Demo.EF
{
    internal class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            ToTable("EMPLOYEE");
            HasKey(t => t.Id);
            Property(em => em.Id).HasColumnName("EMPLOYEE_ID");
            Property(em => em.Name).HasColumnName("NAME");
            Property(em => em.Surname).HasColumnName("SURNAME");
            Property(em => em.Patronymic).HasColumnName("PATRONYMIC");
            Property(em => em.IsInStaff).HasColumnName("ISINSTAFF");
            Property(em => em.Salary).HasColumnName("SALARY");
        }
    }
}