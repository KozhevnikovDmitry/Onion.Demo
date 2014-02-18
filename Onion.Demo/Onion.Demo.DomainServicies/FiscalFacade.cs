using System;
using Onion.Demo.BL.Interface;

namespace Onion.Demo.DomainServicies
{
    internal class FiscalFacade : IFiscalFacade
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IFiscalCalc _fiscalCalc;

        public FiscalFacade(IEmployeeRepository employeeRepository, IFiscalCalc fiscalCalc)
        {
            _employeeRepository = employeeRepository;
            _fiscalCalc = fiscalCalc;
        }

        public double CalculateAllTax()
        {
            try
            {
                var employees = _employeeRepository.SelectStaff();
                return _fiscalCalc.CalculateTax(employees);
            }
            catch (BaseException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new FiscalException("Error occurs during calculate tax", ex);
            }
        }
    }
}
