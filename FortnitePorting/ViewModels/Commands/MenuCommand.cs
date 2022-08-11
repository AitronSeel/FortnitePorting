using System.Diagnostics;
using System.IO;
using System.Windows;
using FortnitePorting.Framework;
using FortnitePorting.Views;

namespace FortnitePorting.ViewModels.Commands;

public class MenuCommand : ViewModelCommand<MainViewModel>
{
    public MenuCommand(MainViewModel viewModel) : base(viewModel) { }

    public override void Execute(object? parameter)
    {
        if (parameter is null) return;
        
        switch (parameter)
        {
            case "File_Exports":
                Process.Start(new ProcessStartInfo { FileName = Path.Combine(Directory.GetCurrentDirectory(), "Exports"), UseShellExecute = true });
                break;
            case "File_Assets":
                Process.Start(new ProcessStartInfo { FileName = Path.Combine(Directory.GetCurrentDirectory(), "Assets"), UseShellExecute = true });
                break;
            case "File_Restart":
                ApplicationView.Restart();
                break;
            case "File_Exit":
                Application.Current.Shutdown();
                break;
            case "Options_Settings":
                Helper.OpenWindow<SettingsView>();
                break;
            case "Tools_BundleDownloader":
                //Helper.OpenWindow<BundleDownloaderView>();
                break;
            case "Help_Discord":
                Process.Start(new ProcessStartInfo { FileName = Constants.DISCORD_URL, UseShellExecute = true });
                break;
            case "Help_GitHub":
                Process.Start(new ProcessStartInfo { FileName = Constants.GITHUB_URL, UseShellExecute = true });
                break;
            case "Help_About":
                //Helper.OpenWindow<AboutView>();
                break;
        }
    }
}