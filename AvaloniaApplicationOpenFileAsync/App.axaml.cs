using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

namespace AvaloniaApplicationOpenFileAsync
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            System.Globalization.CultureInfo.CurrentUICulture = new System.Globalization.CultureInfo("ko-KR");


            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
               


                desktop.MainWindow = new MainWindow();


            }

            base.OnFrameworkInitializationCompleted();


           

        }
    }
}
