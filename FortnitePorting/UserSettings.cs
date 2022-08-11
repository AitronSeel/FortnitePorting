using System;
using System.IO;
using CUE4Parse.UE4.Versions;
using FortnitePorting.Framework;
using Newtonsoft.Json;

namespace FortnitePorting;

public class UserSettings : ViewModel
{
    public static UserSettings Current { get; set; }
    public static readonly string FilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FortnitePorting", "Settings.json");
    
    public static void Load()
    {
        if (File.Exists(FilePath))
        {
            Current = JsonConvert.DeserializeObject<UserSettings>(File.ReadAllText(FilePath));
        }
        
        Current ??= new UserSettings();
    }

    public static void Save()
    {
        Current.FirstStartup = false;
        File.WriteAllText(FilePath, JsonConvert.SerializeObject(Current, Formatting.Indented));
    }

    private bool _firstStartup = true;
    public bool FirstStartup
    {
        get => _firstStartup;
        set => SetField(ref _firstStartup, value);
    }
    
    private ELanguage _language;
    public ELanguage Language
    {
        get => _language;
        set => SetField(ref _language, value);
    }
    
    private EInstallType _installType;
    public EInstallType InstallType
    {
        get => _installType;
        set => SetField(ref _installType, value);
    }
    
    private string _archivePath;
    public string ArchivePath
    {
        get => _archivePath;
        set => SetField(ref _archivePath, value);
    }

}