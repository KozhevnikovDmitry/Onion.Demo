using System.Collections.Generic;
using NUnit.Framework;
using Moq;
using Onion.Demo.DM;
using Onion.Demo.DomainInterface;

namespace Onion.Demo.DomainServices.Tests
{
    [TestFixture]
    public class FiscalFacadeTests
    {
        [Test]
        public void CalculateAllTax_Test()
        {
            // Arrange
            var employees = new List<Employee>();
            var employeeRepository = Mock.Of<IEmployeeRepository>(t => t.SelectStaff() == employees);
            var fiscalCalc = Mock.Of<IFiscalCalc>(t => t.CalculateTax(employees) == 100500);
            var fiscalFacade = new FiscalFacade(employeeRepository, fiscalCalc);

            // Act
            var tax = fiscalFacade.CalculateAllTax();

            // Assert
            Assert.AreEqual(tax, 100500);
        }
    }
}