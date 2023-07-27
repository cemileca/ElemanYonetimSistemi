using ElemanYonetimSistemi.Persistence;
using ElemanYonetimSistemi.WinForm;
using Microsoft.Extensions.Hosting;

namespace ElemanYonetimSistemi.DesktopForm
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

            ApplicationConfiguration.Initialize();

            var builder = Host.CreateDefaultBuilder();
            builder.ConfigureServices(services => services.AddPersistenceServices());
            builder.Build();

            Application.Run(new Form1());
        }
    }
}