using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Payslip.Services.EmployeeImports;
using Payslip.Web.Models.Home;

namespace Payslip.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeParserService _employeeParserService;

        public HomeController(IEmployeeParserService employeeParserService)
        {
            _employeeParserService = employeeParserService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            IndexViewModel viewModel = new IndexViewModel();
            viewModel.Input = "Wade,Gausden,125000,9,March";
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
                    employeeList.ToList();

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
