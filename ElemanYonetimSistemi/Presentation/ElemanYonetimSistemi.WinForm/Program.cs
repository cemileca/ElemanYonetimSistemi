using ElemanYonetimSistemi.Persistence;
using Microsoft.Extensions.Hosting;

namespace ElemanYonetimSistemi.WinForm
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

            builder.Build().Run();


            Application.Run(new ElemanYonetimSistemiAnaForm());
        }
    }
}