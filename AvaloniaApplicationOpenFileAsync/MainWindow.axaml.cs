using Avalonia.Controls;
using AvaloniaApplicationOpenFileAsync.ViewFactory;
using Core;

namespace AvaloniaApplicationOpenFileAsync
{
    public partial class MainWindow : Window
    {
        OpenFileCommand cmd = new OpenFileCommand();

        public static MainWindow currentWindow; //by lack of knowing a better way to get current window handle? 

        public MainWindow()
        {
            InitializeComponent();
            currentWindow = this; //by lack of a better way i know now. 
            FApp.viewsFactory = new AvaloniaViewFactory();
            OpenFileButton.Click += OpenFileButton_Click;
        }

        private void OpenFileButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            cmd.Execute();
        }
    }
}
