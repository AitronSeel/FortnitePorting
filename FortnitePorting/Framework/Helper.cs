using System.Linq;
using System.Windows;
using FortnitePorting.Views;
using Ookii.Dialogs.Wpf;

namespace FortnitePorting.Framework;

public class Helper
{
    public static void OpenWindow<T>() where T : Window, new()
    {
        if (IsWindowOpen<T>())
        {
            var window = GetWindow<T>();
            window.Show();
            window.Focus();
            return;
        }

        var newWindow = new T();
        newWindow.Show();
        newWindow.Focus();
    }
    
    public static bool IsWindowOpen<T>() where T : Window
    {
        return Application.Current.Windows.OfType<T>().Any();
    }

    private static T GetWindow<T>() where T : Window 
    {
        return Application.Current.Windows.OfType<T>().First();
    }
    
    public static bool TrySelectFolder(out string selectedPath)
    {
        var fileExplorer = new VistaFolderBrowserDialog { ShowNewFolderButton = true };

        if (fileExplorer.ShowDialog() == true)
        {
            selectedPath = fileExplorer.SelectedPath;
            return true;
        }

        selectedPath = string.Empty;
        return false;
    }
}