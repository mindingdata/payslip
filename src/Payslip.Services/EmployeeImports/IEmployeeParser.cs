using Payslip.Domain;

namespace Payslip.Services.EmployeeImports
{
    public interface IEmployeeParser
    {
        void Process(string[] employeeLineParts, Employee employee);
    }
}
