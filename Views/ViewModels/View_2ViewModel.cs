using WPF_MultyView.Enums;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WPF_MultyView.Views.ViewModels;

public partial class View_2ViewModel : BaseViewModel
{
    [ObservableProperty] string _text = "View_2";

    public View_2ViewModel()
    {
        ViewType = ViewType.View2;
    }
}
