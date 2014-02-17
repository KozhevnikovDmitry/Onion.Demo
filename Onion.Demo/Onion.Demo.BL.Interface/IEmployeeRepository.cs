﻿using System.Collections.Generic;
using Onion.Demo.DM;

namespace Onion.Demo.BL.Interface
{
    public interface IEmployeeRepository
    {
        IList<Employee> SelectAll();

        IList<Employee> SelectStaff();

        Employee Save(Employee employee);

        void Remove(Employee employee);
    }
}
