using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payslip.Domain;

namespace Payslip.Services.EmployeeImports
{
    public class EmployeeParserLastname : IEmployeeParser
    {
        public void Process(string[] employeeLineParts, Employee employee)
        {
            employee.Lastname = employeeLineParts[1];
        }
    }
}
