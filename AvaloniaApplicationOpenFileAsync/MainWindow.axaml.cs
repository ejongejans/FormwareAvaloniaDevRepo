using Avalonia.Controls;
using AvaloniaApplicationOpenFileAsync.ViewFactory;
using Core;
using FCore;
using System.Collections.Generic;

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
            //OpenFileButton.Click += OpenFileButton_Click;

            MainToolbar.AddToolBar(GetMeSomeCommands(5), "File");
            MainToolbar.AddToolBar(GetMeSomeCommands(3), "Edit");
            MainToolbar.AddToolBar(GetMeSomeCommands(10), "View");
           

            this.Opened += MainWindow_Opened;
        }

        private void MainWindow_Opened(object? sender, System.EventArgs e)
        {
            MainToolbar.LoadToolbar(0);
        }

        private List<ICommand> GetMeSomeCommands(int cnt)
        {
            List<ICommand> cmds = new List<ICommand>();
            
            for(int i = 0; i < cnt; i++)
                cmds.Add(new ExampleCommand(i));

            return cmds;
        }


        private void OpenFileButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            cmd.Execute();
        }
    }
}
