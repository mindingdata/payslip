using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip.Services.TaxCalculators
{
    public interface IIncomeTaxCalculator
    {
        decimal Calculate(decimal salary);
    }
}
