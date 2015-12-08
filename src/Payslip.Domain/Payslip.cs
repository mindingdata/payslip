using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip.Domain
{
    public class Payslip
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime PaymentMonth { get; set; }
        public decimal GrossIncome { get; set; }
        public decimal IncomeTax { get; set; }
        public decimal Super { get; set; }

        public decimal NetIncome
        {
            get { return GrossIncome - IncomeTax; }
        }
    }
}
