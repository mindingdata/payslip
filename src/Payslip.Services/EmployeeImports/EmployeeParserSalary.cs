using Payslip.Domain;

namespace Payslip.Services.EmployeeImports
{
    public class EmployeeParserSalary : IEmployeeParser
    {
        public void Process(string[] employeeLineParts, Employee employee)
        {
            employee.AnnualSalary = decimal.Parse(employeeLineParts[2]);
        }
    }
}
