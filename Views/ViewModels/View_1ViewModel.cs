using WPF_MultyView.Enums;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WPF_MultyView.Views.ViewModels;

public partial class View_1ViewModel : BaseViewModel
{
    [ObservableProperty] string _text = "View_1";

    public View_1ViewModel()
    {
        ViewType = ViewType.View1;
    }
}
