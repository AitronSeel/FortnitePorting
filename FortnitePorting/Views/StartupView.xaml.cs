using System.Windows;
using FortnitePorting.Framework;
using FortnitePorting.ViewModels;

namespace FortnitePorting.Views;

public partial class StartupView
{
    private readonly StartupViewModel _startupView;
    
    public StartupView()
    {
        InitializeComponent();
        _startupView = new StartupViewModel();
        DataContext = _startupView;
    }

    private void OnBrowseArchivePath(object sender, RoutedEventArgs e)
    {
        if (Helper.TrySelectFolder(out var path)) _startupView.ArchivePath = path;
    }
}