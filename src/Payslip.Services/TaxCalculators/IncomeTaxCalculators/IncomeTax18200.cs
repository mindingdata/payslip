using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip.Services.TaxCalculators.IncomeTaxCalculators
{
    public class IncomeTax18200 : IIncomeTax
    {
        public decimal IncomeLowerThreshold
        {
            get { return 0; }
        }

        public decimal IncomeUpperThreshold 
        {
            get { return 18200; }
        }

        public decimal TaxRate 
        {
            get { return 0; }
        }

        public decimal BaseTax 
        {
            get { return 0; }
        }

    }
}
