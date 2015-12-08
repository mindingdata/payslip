using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payslip.Domain;

namespace Payslip.Services.EmployeeImports
{
    public class EmployeeParserSuper : IEmployeeParser
    {
        public void Process(string[] employeeLineParts, Employee employee)
        {
            employee.SuperRate = decimal.Parse(employeeLineParts[3]);
        }
    }
}
