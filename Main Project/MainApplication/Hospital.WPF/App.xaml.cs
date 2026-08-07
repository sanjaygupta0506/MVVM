using Hospital.WPF.Data;
using Hospital.WPF.Services;
using Hospital.WPF.Services.Interface;
using Hospital.WPF.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Hospital.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IHost Host { get; } =
        Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder()
        .ConfigureServices((context, services) =>
        {
            services.AddDbContext<HospitalPatientDbContext>(options =>
            {
                options.UseSqlServer(
                    "Server=Sanjay-PC\\MSSQLSERVER2022;Database=HospitalDB;Trusted_Connection=True;TrustServerCertificate=True;");
            });
            services.AddSingleton<IPatientRepository, PatientRepository>();

            services.AddSingleton<IPatientService, PatientService>();

            services.AddSingleton<PatientViewModel>();

            services.AddSingleton<MainWindow>();
        })
        .Build();

        protected override async void OnStartup(StartupEventArgs e)
        {
            await Host.StartAsync();

            var window = Host.Services.GetRequiredService<MainWindow>();
            window.Show();

            base.OnStartup(e);
        }
    }

}
