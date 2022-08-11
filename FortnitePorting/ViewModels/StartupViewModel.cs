using CUE4Parse.UE4.Versions;
using FortnitePorting.Framework;

namespace FortnitePorting.ViewModels;

public class StartupViewModel : ViewModel
{
    public string ArchivePath
    {
        get => UserSettings.Current.ArchivePath;
        set
        {
            UserSettings.Current.ArchivePath = value;
            OnPropertyChanged();
        }
    }
    
    public ELanguage Language
    {
        get => UserSettings.Current.Language;
        set
        {
            UserSettings.Current.Language = value;
            OnPropertyChanged();
        }
    }
}