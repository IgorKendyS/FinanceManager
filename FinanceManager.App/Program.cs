using FinanceManager.App.Infra;
using FinanceManager.App.Outros;
using FinanceManager.Domain.Base;
using FinanceManager.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace FinanceManager.App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ConfigureDI.ConfiguraServices();
            ApplicationConfiguration.Initialize();

            var userService = ConfigureDI.ServicesProvider!.GetRequiredService<IBaseService<User>>();

            var loginForm = new Login(userService);
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FormPrincipal());
            }
        }
    }
}