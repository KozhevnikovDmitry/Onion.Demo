﻿using FluentNHibernate.Mapping;
using Onion.Demo.DomainModel;

namespace Onion.Demo.NH
{
    internal class EmployeeMap : ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Table("EMPLOYEE");
            Id(t => t.Id).Column("EMPLOYEE_ID").GeneratedBy.GuidComb();
            Map(t => t.Name).Column("NAME");
            Map(t => t.Surname).Column("SURNAME");
            Map(t => t.Patronymic).Column("PATRONYMIC");
            Map(t => t.IsInStaff).Column("ISINSTAFF");
            Map(t => t.Salary).Column("SALARY");
        }
    }
}
