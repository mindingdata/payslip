using AutoMapper;
using Payslip.Web.Models.Home;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Payslip.Web.App_Start.AutomapperConfiguration), "Configure")]


namespace Payslip.Web.App_Start
{

    public static class AutomapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Domain.Payslip, PayslipViewModel>();
        }
    }
}