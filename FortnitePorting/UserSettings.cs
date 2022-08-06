using System;
using System.IO;
using FortnitePorting.Framework;
using Newtonsoft.Json;

namespace FortnitePorting;

public class UserSettings : ViewModel
{
    public static UserSettings? Current { get; set; }
    public static readonly string FilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FortnitePorting", "Settings.json");
    
    public static void Load()
    {
        if (File.Exists(FilePath)) 
            Current = JsonConvert.DeserializeObject<UserSettings>(File.ReadAllText(FilePath));
        Current ??= new UserSettings();
    }

    public static void Save()
    {
        File.WriteAllText(FilePath, JsonConvert.SerializeObject(Current, Formatting.Indented));
    }
    
}