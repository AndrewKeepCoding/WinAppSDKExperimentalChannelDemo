using Microsoft.UI.Xaml;

namespace WinAppSDKExperimentalChannelDemo;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        Microsoft.Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = "ja";
    }

    protected override void OnLaunched(LaunchActivatedEventArgs args)
    {
        _window = new MainWindow();
        _window.Activate();
    }

    private Window _window;
}
