﻿using System;
using System.Collections.Generic;
using Onion.Demo.BL.Interface;
using Onion.Demo.DM;

namespace Onion.Demo.BL
{
    public class FiscalCalc : IFiscalCalc
    {
        public double CalculateTax(IList<Employee> employees)
        {
            if (employees == null) 
                throw new ArgumentNullException("employees");

            try
            {
                double result = 0;
                foreach (var employee in employees)
                {
                    if (employee.Salary < 1000)
                    {
                        result += 0.1 * employee.Salary;
                        break;
                    }

                    if (employee.Salary > 10000)
                    {
                        result += 0.35 * employee.Salary;
                        break;
                    }

                    result += 0.25 * employee.Salary;
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new FiscalException("Error occurs during calculate tax", ex);
            }
        }
    }
}