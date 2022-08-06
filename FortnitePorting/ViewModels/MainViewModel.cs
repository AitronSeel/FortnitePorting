using FortnitePorting.Framework;
using MenuCommand = FortnitePorting.ViewModels.Commands.MenuCommand;

namespace FortnitePorting.ViewModels;

public class MainViewModel : ViewModel
{
    public MenuCommand MenuCommand => new(this);
}