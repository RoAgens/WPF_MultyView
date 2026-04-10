using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using WPF_MultyView.Interfaces;
using WPF_MultyView.Services;
using WPF_MultyView.ViewModels;
using WPF_MultyView.Views;
using WPF_MultyView.Views.ViewModels;

namespace WPF_MultyView;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        var services = new ServiceCollection();

        services.AddTransient<MainWindow>();
        services.AddSingleton<MainWindowViewModel>();

        services.AddTransient<View_1>();
        services.AddSingleton<IBaseViewModel, View_1ViewModel>();
        services.AddTransient<View_2>();
        services.AddSingleton<IBaseViewModel, View_2ViewModel>();

        services.AddSingleton<IViewModelManager, ViewModelManager>();

        var provider = services.BuildServiceProvider();

        provider.GetRequiredService<MainWindow>().Show();
    }
}

