using System.Windows.Controls;
using WPF_MultyView.Views.ViewModels;

namespace WPF_MultyView.Views;

public partial class View_2 : UserControl
{
    public View_2()
    {
        InitializeComponent();
    }

    public View_2(View_2ViewModel viewModel) : this()
    {
        DataContext = viewModel;
    }
}
