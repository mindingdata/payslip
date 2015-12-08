using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payslip.Domain;

namespace Payslip.Services
{
    public interface IPayslipService
    {
        Domain.Payslip GeneratePayslip(Employee employee, DateTime month);
    }
}
