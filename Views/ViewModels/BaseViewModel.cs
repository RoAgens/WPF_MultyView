using WPF_MultyView.Enums;
using WPF_MultyView.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WPF_MultyView.Views.ViewModels;

public abstract partial class BaseViewModel : ObservableObject, IBaseViewModel
{
    public ViewType ViewType { get; protected set; }
}
