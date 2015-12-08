using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip.Services.TaxCalculators.IncomeTaxCalculators
{
    public class IncomeTax180000 : IIncomeTax
    {
        public decimal IncomeLowerThreshold
        {
            get { return 80001; }
        }

        public decimal IncomeUpperThreshold
        {
            get { return 180000; }
        }

        public decimal TaxRate
        {
            get { return 37; }
        }

        public decimal BaseTax
        {
            get { return 17547; }
        }
    }
}
