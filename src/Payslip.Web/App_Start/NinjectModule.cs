using Ninject;
using Ninject.Extensions.Conventions;
using Payslip.Services.EmployeeImports;

namespace Payslip.Web.App_Start
{
    public static class NinjectModule
    {
        public static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(
                x => 
                    x.FromAssemblyContaining(typeof(IEmployeeParser))
                    .SelectAllClasses()
                    .BindAllInterfaces()
            );
        }
    }
}