using System.Windows.Controls;
using WPF_MultyView.Views.ViewModels;

namespace WPF_MultyView.Views;

public partial class View_1 : UserControl
{
    public View_1()
    {
        InitializeComponent();
    }

    public View_1(View_1ViewModel viewModel) : this()
    {
        DataContext = viewModel;
    }
}
