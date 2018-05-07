using System.IO;
using System.Windows;

namespace CefSharp.MinimalExample.Wpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var dir = Directory.GetCurrentDirectory();
            Browser.Address = "file:///" + dir.Replace("\\", "/") + "/201805071024008880.html";
        }
    }
}
