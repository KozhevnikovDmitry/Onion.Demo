using System;
using Onion.Demo.DM;
using Onion.Demo.DomainInterface;

namespace Onion.Demo.ConsoleUI
{
    public class OnionDemo
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IFiscalFacade _fiscalFacade;

        public OnionDemo(IEmployeeRepository employeeRepository, IFiscalFacade fiscalFacade)
        {
            _employeeRepository = employeeRepository;
            _fiscalFacade = fiscalFacade;
        }

        public void Demo()
        {
            var coder = new Employee
            {
                Name = "Dmitry",
                Surname = "Kozhevnikov",
                Patronymic = "Olegovich",
                Salary = 1000,
                IsInStaff = true
            };

            var middleManager = new Employee
            {
                Name = "Alexei",
                Surname = "Volkov",
                Patronymic = "Genadievich",
                Salary = 2000,
                IsInStaff = true
            };

            var owner = new Employee
            {
                Name = "Smith",
                Surname = "John",
                Patronymic = "John",
                Salary = 10000,
                IsInStaff = true
            };

            _employeeRepository.Save(coder);
            _employeeRepository.Save(middleManager);
            _employeeRepository.Save(owner);

            foreach (var employee in _employeeRepository.SelectStaff())
            {
                Console.WriteLine(employee);
            }

            var tax = _fiscalFacade.CalculateAllTax();

            Console.WriteLine("The tax is [{0}]", tax.ToString("C"));
            Console.ReadLine();
        }
    }
}