using System.Collections.Generic;
using Payslip.Domain;

namespace Payslip.Services.EmployeeImports
{
    public interface IEmployeeParserService
    {
        IEnumerable<Employee> ParseCSV(string csvInput);
        bool ValidateCsv(string csvInput);
    }
}
