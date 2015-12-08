using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payslip.Domain
{
    public class Employee
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public decimal AnnualSalary { get; set; }
        public decimal SuperRate { get; set; }
    }
}
