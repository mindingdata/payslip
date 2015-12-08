using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payslip.Services.TaxCalculators.IncomeTaxCalculators;

namespace Payslip.Services.TaxCalculators
{
    public class IncomeTaxCalculator : IIncomeTaxCalculator
    {
        private readonly IEnumerable<IIncomeTax> _incomeTaxes;

        public IncomeTaxCalculator(IEnumerable<IIncomeTax> incomeTaxes)
        {
            _incomeTaxes = incomeTaxes;
        }

        public decimal Calculate(decimal salary)
        {
            var incomeTax = _incomeTaxes.First(x => x.IncomeLowerThreshold <= salary && x.IncomeUpperThreshold >= salary);
            return Math.Round(incomeTax.BaseTax + (salary - incomeTax.IncomeLowerThreshold)*incomeTax.TaxRate/100, 0, MidpointRounding.ToEven);
        }
    }
}
