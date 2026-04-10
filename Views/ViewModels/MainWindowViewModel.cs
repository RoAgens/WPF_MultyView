using WPF_MultyView.Enums;
using WPF_MultyView.Interfaces;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WPF_MultyView.ViewModels;

public partial class MainWindowViewModel(IViewModelManager vmm) : ObservableValidator
{
    [ObservableProperty] ObservableCollection<ViewType> _viewTypes =  new ObservableCollection<ViewType>(Enum.GetValues<ViewType>().Skip(1));
    [ObservableProperty] ViewType _selectedViewType;

    [ObservableProperty] IBaseViewModel _currentViewModel;

    internal void Init()
    {
        SelectedViewType = ViewTypes.First();
    }

    partial void OnSelectedViewTypeChanged(ViewType value)
    {
        CurrentViewModel = vmm.GetView(value);
    }
}
