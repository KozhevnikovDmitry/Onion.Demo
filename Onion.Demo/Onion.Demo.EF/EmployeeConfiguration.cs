﻿using System.Data.Entity.ModelConfiguration;
using Onion.Demo.DM;

namespace Onion.Demo.EF
{
    public class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            HasKey(t => t.Id);
            ToTable("EMPLOYEE");
        }
    }
}