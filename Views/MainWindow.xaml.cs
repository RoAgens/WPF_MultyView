using System.Windows;
using WPF_MultyView.ViewModels;

namespace WPF_MultyView.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    public MainWindow(MainWindowViewModel viewModel) : this()
    {
        DataContext = viewModel;
        viewModel.Init();
    }
}
