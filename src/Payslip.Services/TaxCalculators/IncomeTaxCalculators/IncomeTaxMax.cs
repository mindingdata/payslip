using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip.Services.TaxCalculators.IncomeTaxCalculators
{
    public class IncomeTaxMax : IIncomeTax
    {
        public decimal IncomeLowerThreshold
        {
            get { return 180001; }
        }

        public decimal IncomeUpperThreshold
        {
            get {return decimal.MaxValue; }
        }

        public decimal TaxRate
        {
            get { return 45; }
        }

        public decimal BaseTax
        {
            get { return 54547; }
        }
    }
}
