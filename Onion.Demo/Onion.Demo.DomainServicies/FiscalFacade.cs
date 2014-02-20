using Onion.Demo.DomainInterface;

namespace Onion.Demo.DomainServicies
{
    public class FiscalFacade : IFiscalFacade
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
            var employees = _employeeRepository.SelectStaff();
            return _fiscalCalc.CalculateTax(employees);
        }
    }
}
