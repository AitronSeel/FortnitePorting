using System.ComponentModel;
using System.Windows;
using FortnitePorting.Framework;
using FortnitePorting.ViewModels;

namespace FortnitePorting.Views;

public partial class SettingsView
{
    public SettingsView()
    {
        InitializeComponent();
        
        ApplicationView.SettingsView = new SettingsViewModel();
        DataContext = ApplicationView.SettingsView;
    }

    private void OnClose(object? sender, CancelEventArgs e)
    {
        if (ApplicationView.SettingsView.ShouldRestart)
        {
            ApplicationView.RestartWithWarning();
        }
    }

    private void OnBrowseArchivePath(object sender, RoutedEventArgs e)
    {
        if (Helper.TrySelectFolder(out var path)) ApplicationView.SettingsView.ArchivePath = path;
    }
}