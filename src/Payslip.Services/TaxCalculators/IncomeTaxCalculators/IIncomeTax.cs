using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip.Services.TaxCalculators.IncomeTaxCalculators
{
    public interface IIncomeTax
    {
        decimal IncomeLowerThreshold { get; }
        decimal IncomeUpperThreshold { get; }
        decimal TaxRate { get; }
        decimal BaseTax { get; }
    }
}
