using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Payslip.Services;
using Payslip.Services.EmployeeImports;
using Payslip.Web.Models.Home;

namespace Payslip.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeParserService _employeeParserService;
        private readonly IPayslipService _payslipService;

        public HomeController(IEmployeeParserService employeeParserService, IPayslipService payslipService)
        {
            _employeeParserService = employeeParserService;
            _payslipService = payslipService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            IndexViewModel viewModel = new IndexViewModel();
            viewModel.Input = "David,Rudd,60050,9" + Environment.NewLine + 
                              "Ryan,Chen,120000,10";

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(IndexViewModel viewModel)
        {
            if (_employeeParserService.ValidateCsv(viewModel.Input))
            {
                try
                {
                    var employeeList = _employeeParserService.ParseCSV(viewModel.Input);
                    viewModel.Payslips = new List<PayslipViewModel>();

                    foreach (var employee in employeeList)
                    {
                        viewModel.Payslips.Add(Mapper.Map<PayslipViewModel>(_payslipService.GeneratePayslip(employee, DateTime.UtcNow)));
                    }
                }
                catch(Exception ex)
                {
                    viewModel.ErrorParsing = true;
                }
            }
            else
            {
                viewModel.ErrorParsing = true;
            }

            return View(viewModel);
        }
    }
}
