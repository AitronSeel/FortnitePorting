using System.IO;
using System.Windows;
using System.Windows.Threading;
using AdonisUI.Controls;
using MessageBox = AdonisUI.Controls.MessageBox;
using MessageBoxImage = AdonisUI.Controls.MessageBoxImage;

namespace FortnitePorting;

public partial class App
{
    public static readonly DirectoryInfo ExportPath = new(Path.Combine(Directory.GetCurrentDirectory(), "Exports"));
    public static readonly DirectoryInfo AssetsPath = new(Path.Combine(Directory.GetCurrentDirectory(), "Assets"));
    public static readonly DirectoryInfo DataPath = new(Path.Combine(Directory.GetCurrentDirectory(), ".data"));
    
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        
        Directory.CreateDirectory(Path.GetDirectoryName(UserSettings.FilePath)!);
        Directory.CreateDirectory(ExportPath.FullName);
        Directory.CreateDirectory(AssetsPath.FullName);
        Directory.CreateDirectory(DataPath.FullName);
        UserSettings.Load();
    }
    
    private void OnExit(object sender, ExitEventArgs e)
    {
        UserSettings.Save();
    }

    private void OnUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
    {
        var messageBox = new MessageBoxModel
        {
            Caption = "Unhandled Exception",
            Text = $"An unhandled exception occurred: {e.Exception.Message}{e.Exception.StackTrace}",
            IsSoundEnabled = false,
            Icon = MessageBoxImage.Error,
            Buttons = new[] { MessageBoxButtons.Ok() }
        };

        MessageBox.Show(messageBox);
        e.Handled = true;
    }
}