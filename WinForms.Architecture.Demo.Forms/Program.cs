using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Architecture.Demo.Application.Contract;
using WinForms.Architecture.Demo.Infra;
using SYSTEM = System.Windows.Forms;
namespace WinForms.Architecture.Demo.Forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SYSTEM.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            SYSTEM.Application.EnableVisualStyles();
            SYSTEM.Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            services.AddScoped<ICalculator, Calculator>();

            services.AddScoped<Form1>();

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<Form1>();
                SYSTEM.Application.Run(form1);
            }
        }

    }
}
