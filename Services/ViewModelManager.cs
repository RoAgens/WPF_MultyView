using WPF_MultyView.Enums;
using WPF_MultyView.Interfaces;

namespace WPF_MultyView.Services;

public class ViewModelManager(IEnumerable<IBaseViewModel> vms) : IViewModelManager
{
    private Dictionary<ViewType, IBaseViewModel> _map = vms.ToDictionary(vm => vm.ViewType);
    public IBaseViewModel GetView(ViewType value)
    {
        return _map[value] as IBaseViewModel;
    }
}