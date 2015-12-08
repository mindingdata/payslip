using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payslip.Domain;
using Payslip.Services.TaxCalculators;

namespace Payslip.Services
{
    public class PayslipService : IPayslipService
    {
        private readonly IIncomeTaxCalculator _incomeTaxCalculator;

        public PayslipService(IIncomeTaxCalculator incomeTaxCalculator)
        {
            _incomeTaxCalculator = incomeTaxCalculator;
        }

        public Domain.Payslip GeneratePayslip(Employee employee, DateTime month)
        {
            Domain.Payslip payslip = new Domain.Payslip();

            payslip.Firstname = employee.Firstname;
            payslip.Lastname = employee.Lastname;
            payslip.GrossIncome = Math.Round(employee.AnnualSalary/12, 0, MidpointRounding.ToEven);
            payslip.IncomeTax = Math.Round(_incomeTaxCalculator.Calculate(employee.AnnualSalary)/12, 0, MidpointRounding.ToEven);
            payslip.PaymentMonth = month;
            payslip.Super = Math.Round(payslip.GrossIncome*employee.SuperRate/100, 0, MidpointRounding.ToEven);

            return payslip;
        }
    }
}
