using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip.Services.TaxCalculators.IncomeTaxCalculators
{
    public class IncomeTax37000 :IIncomeTax
    {
        public decimal IncomeLowerThreshold
        {
            get { return 18201; }
        }

        public decimal IncomeUpperThreshold
        {
            get { return 37000; }
        }

        public decimal TaxRate
        {
            get { return 15M; }
        }

        public decimal BaseTax
        {
            get { return 0; }
        }
    }
}
