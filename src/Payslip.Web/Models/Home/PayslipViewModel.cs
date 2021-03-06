﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Payslip.Web.Models.Home
{
    public class PayslipViewModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime PaymentMonth { get; set; }
        public decimal GrossIncome { get; set; }
        public decimal IncomeTax { get; set; }
        public decimal NetIncome { get; set; }
        public decimal Super { get; set; }
    }
}