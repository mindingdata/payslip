using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Payslip.Domain;
using Payslip.Services.EmployeeImports;

namespace Payslip.Services.Test
{
    [TestFixture]
    public class EmployeeParserTests
    {
        [Test]
        public void When_EmployerParseFirstname_Called_With_Valid_CSV_Firstname_Is_Mapped()
        {
            EmployeeParserFirstname parserFirstName = new EmployeeParserFirstname();
            Employee employee = new Employee();

            parserFirstName.Process("firstname,".Split(','), employee);

            Assert.AreEqual("firstname", employee.Firstname);
        }

        [Test]
        public void When_EmployerParseLastname_Called_With_Valid_CSV_Lastname_Is_Mapped()
        {
            EmployeeParserLastname parserLastname = new EmployeeParserLastname();
            Employee employee = new Employee();

            parserLastname.Process("firstname,lastname".Split(','), employee);

            Assert.AreEqual("lastname", employee.Lastname);
        }

        [Test]
        public void When_EmployerParseSalary_Called_With_Valid_CSV_Salary_Is_Mapped()
        {
            EmployeeParserSalary parserSalary = new EmployeeParserSalary();
            Employee employee = new Employee();

            parserSalary.Process("firstname,lastname,9000".Split(','), employee);

            Assert.AreEqual(9000, employee.AnnualSalary);
        }

        [Test]
        public void When_EmployerParseSuper_Called_With_Valid_CSV_Super_Is_Mapped()
        {
            EmployeeParserSuper parserSuper = new EmployeeParserSuper();
            Employee employee = new Employee();

            parserSuper.Process("firstname,lastname,9000,89".Split(','), employee);

            Assert.AreEqual(89, employee.SuperRate);
        }
    }
}
