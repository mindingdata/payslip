using System;
using System.Collections.Generic;
using Payslip.Domain;

namespace Payslip.Services.EmployeeImports
{
    public class EmployeeParserService : IEmployeeParserService
    {
        private readonly IEnumerable<IEmployeeParser> _employeeParsers;

        public EmployeeParserService(IEnumerable<IEmployeeParser> employeeParsers)
        {
            _employeeParsers = employeeParsers;
        }

        public IEnumerable<Employee> ParseCSV(string csvInput)
        {
            var employeeLines = csvInput.Split(new[] { Environment.NewLine },StringSplitOptions.RemoveEmptyEntries);
            foreach (var employeeLine in employeeLines)
            {
                var employeeParts = employeeLine.Split(',');
                var employee = new Employee();
                foreach (var parser in _employeeParsers)
                {
                    parser.Process(employeeParts, employee);
                }

                yield return employee;
            }
        }

        public bool ValidateCsv(string csvInput)
        {
            var lines = csvInput.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                if (line.Split(',').Length != 4)
                    return false;
            }

            return true;
        }
    }
}
