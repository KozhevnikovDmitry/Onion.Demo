using NUnit.Framework;
using Onion.Demo.DomainModel;

namespace Onion.Demo.DomainServices.Tests
{
    [TestFixture]
    public class FiscalCalcTests
    {
        [Test]
        public void CalculateTax_SalaryLessThen1000_TaxIs10perc_Test()
        {
            // Arrange
            var employee = new Employee
            {
                Salary = 900
            };
            var calc = new FiscalCalc();

            // Act
            var tax = calc.CalculateTax(new[] {employee});

            // Assert
            Assert.AreEqual(tax, 90);
        }

        [Test]
        public void CalculateTax_SalaryMoreThen10000_TaxIs35perc_Test()
        {
            // Arrange
            var employee = new Employee
            {
                Salary = 100000
            };
            var calc = new FiscalCalc();

            // Act
            var tax = calc.CalculateTax(new[] { employee });

            // Assert
            Assert.AreEqual(tax, 35000);
        }
        
        [Test]
        public void CalculateTax_SalarymoreThen1000LessThen10000_TaxIs25perc_Test()
        {
            // Arrange
            var employee = new Employee
            {
                Salary = 5000
            };
            var calc = new FiscalCalc();

            // Act
            var tax = calc.CalculateTax(new[] { employee });

            // Assert
            Assert.AreEqual(tax, 1250);
        }

        [Test]
        public void CalculateTax_SumDifferentTaxes_Test()
        {
            // Arrange
            var junior = new Employee { Salary = 900 };
            var middle = new Employee { Salary = 5000 };
            var senior = new Employee { Salary = 100000 };

            var calc = new FiscalCalc();

            // Act
            var tax = calc.CalculateTax(new[] { junior, middle, senior });

            // Assert
            Assert.AreEqual(tax, 36340);
        }
    }
}