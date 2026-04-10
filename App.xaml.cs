using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using WPF_MultyView.Views;

namespace WPF_MultyView;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        var services = new ServiceCollection();

        services.AddSingleton<MainWindow>();

        var provider = services.BuildServiceProvider();

        provider.GetRequiredService<MainWindow>().Show();
    }
}

