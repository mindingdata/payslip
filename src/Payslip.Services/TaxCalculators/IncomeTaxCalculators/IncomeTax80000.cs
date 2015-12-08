using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip.Services.TaxCalculators.IncomeTaxCalculators
{
    public class IncomeTax80000 :IIncomeTax
    {
        public decimal IncomeLowerThreshold
        {
            get { return 37001; }
        }

        public decimal IncomeUpperThreshold
        {
            get { return 80000; }
        }

        public decimal TaxRate
        {
            get { return 32.5M; }
        }

        public decimal BaseTax
        {
            get{return 3572; }
        }
    }
}
