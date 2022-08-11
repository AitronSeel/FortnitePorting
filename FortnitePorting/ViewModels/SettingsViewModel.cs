using CUE4Parse.UE4.Versions;
using FortnitePorting.Framework;

namespace FortnitePorting.ViewModels;

public class SettingsViewModel : ViewModel
{
    public bool ShouldRestart { get; set; }

    public bool IsLocalInstall => InstallType == EInstallType.Local;

    public EInstallType InstallType
    {
        get => UserSettings.Current.InstallType;
        set
        {
            UserSettings.Current.InstallType = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(IsLocalInstall));
            ShouldRestart = true;
        }
    }
    
    public string ArchivePath
    {
        get => UserSettings.Current.ArchivePath;
        set
        {
            UserSettings.Current.ArchivePath = value;
            OnPropertyChanged();
            ShouldRestart = true;
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