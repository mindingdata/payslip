using System.Collections.Generic;

namespace Payslip.Web.Models.Home
{
    public class IndexViewModel
    {
        public string Input { get; set; }
        public List<PayslipViewModel> Payslips { get; set; }
        public bool ErrorParsing { get; set; }
    }
}