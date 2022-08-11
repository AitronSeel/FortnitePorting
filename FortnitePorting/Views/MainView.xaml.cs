using System;
using System.Threading.Tasks;
using System.Windows;
using FortnitePorting.Framework;

namespace FortnitePorting.Views;

public partial class MainView
{
    public MainView()
    {
        DataContext = ApplicationView;
        InitializeComponent();
    }

    private void OnLoaded(object sender, RoutedEventArgs e)
    {
        if (UserSettings.Current.FirstStartup)
        {
            Helper.OpenWindow<StartupView>();
            return;
        }
    }
}