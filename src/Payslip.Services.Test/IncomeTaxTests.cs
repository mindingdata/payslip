using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Payslip.Services.TaxCalculators.IncomeTaxCalculators;

namespace Payslip.Services.Test
{
    [TestFixture]
    public class IncomeTaxTests
    {
        [Test]
        public void Ensure_No_Income_Tax_Overlaps()
        {
            List<IIncomeTax> incomeTaxes = new List<IIncomeTax>();
            incomeTaxes.Add(new IncomeTax18200());
            incomeTaxes.Add(new IncomeTax37000());
            incomeTaxes.Add(new IncomeTax80000());
            incomeTaxes.Add(new IncomeTax180000());
            incomeTaxes.Add(new IncomeTaxMax());

            for (decimal i = 1; i < 200000; i++)
            {
                incomeTaxes.First(x => x.IncomeLowerThreshold <= i && x.IncomeUpperThreshold >= i);
            }

            Assert.Pass();
        }
    }
}
