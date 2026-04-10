using WPF_MultyView.Enums;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WPF_MultyView.Interfaces;

public interface IViewModelManager
{
    IBaseViewModel GetView(ViewType value);
}
