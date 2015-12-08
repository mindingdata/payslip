using Payslip.Domain;

namespace Payslip.Services.EmployeeImports
{
    public class EmployeeParserFirstname : IEmployeeParser
    {
        public void Process(string[] employeeLineParts, Employee employee)
        {
            employee.Firstname = employeeLineParts[0];
        }
    }
}
