using System;
using System.Diagnostics;
using System.Windows;
using AdonisUI.Controls;
using FortnitePorting.Framework;
using MenuCommand = FortnitePorting.ViewModels.Commands.MenuCommand;
using MessageBox = AdonisUI.Controls.MessageBox;
using MessageBoxButton = AdonisUI.Controls.MessageBoxButton;
using MessageBoxImage = AdonisUI.Controls.MessageBoxImage;
using MessageBoxResult = AdonisUI.Controls.MessageBoxResult;

namespace FortnitePorting.ViewModels;

public class MainViewModel : ViewModel
{
    public SettingsViewModel SettingsView { get; set; }
    public MenuCommand MenuCommand => new(this);
    
    public void RestartWithWarning()
    {
        var messageBox = new MessageBoxModel
        {
            Text = "An option was changed that requires a restart.\n" +
                   "Fortnite Porting will now restart to apply your changes.",
            Caption = "A restart is required",
            Buttons = MessageBoxButtons.OkCancel(),
            Icon = MessageBoxImage.Warning
        };

        MessageBox.Show(messageBox);

        if (messageBox.Result == MessageBoxResult.OK)
        {
            Restart();
        }
    }

    public void Restart()
    {
        new Process { StartInfo = new ProcessStartInfo { FileName = AppDomain.CurrentDomain.FriendlyName } }.Start();
        Application.Current.Shutdown();
    }

}