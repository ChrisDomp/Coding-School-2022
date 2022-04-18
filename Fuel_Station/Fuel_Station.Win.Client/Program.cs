using Fuel_Station.EF.Repositories;
using Fuel_Station.EF.Repository;
using Fuel_Station.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Fuel_Station.Win.Client
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
            var services = new ServiceCollection();

            ConfigureServices(services);

            using var serviceProvider = services.BuildServiceProvider();
            var mainForm = serviceProvider.GetRequiredService<MainForm>();
            Application.Run(mainForm);
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            //Actual Service
            services.AddDbContext<Fuel_Station.EF.Context.ApplicationContext>();
            services.AddSingleton<IEntityRepo<Customer>, CustomerRepo>()
                 .AddSingleton<IEntityRepo<Item>, ItemRepo>()
                 .AddSingleton<IEntityRepo<Transaction>,TransactionRepo>()
                 .AddSingleton<IEntityRepo<TransactionLine>, TransactionLineRepo>()
                .AddSingleton<MainForm>();


        }
    }
}
