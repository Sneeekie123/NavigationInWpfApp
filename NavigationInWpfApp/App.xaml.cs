using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NavigationInWpfApp.Services;
using NavigationInWpfApp.ViewModels;
using NavigationInWpfApp.Views;
using System.Windows;

namespace NavigationInWpfApp;

public partial class App : Application
{
    private IHost? _host;

    public App()
    {
        _host = Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                services.AddSingleton<CustomerService>();

                services.AddSingleton<MainWindow>();
                services.AddSingleton<MainViewModel>();

                services.AddTransient<CustomerAddView>();
                services.AddTransient<CustomerAddViewModel>();  

                services.AddTransient<CustomerView>();
                services.AddTransient<CustomerViewModel>();
            })
            
            .Build();

    }

    protected override void OnStartup(StartupEventArgs e)
    {
        _host!.Start();

        var mainWindow = _host!.Services.GetRequiredService<MainWindow>();
        mainWindow.Show();
    }
}
