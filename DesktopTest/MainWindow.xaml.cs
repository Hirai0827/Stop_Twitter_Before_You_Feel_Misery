using System.Windows;

namespace DesktopTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void OpenPostWindow(object sender, RoutedEventArgs e)
        {
            string baseURL = "https://twitter.com/intent/tweet?";
            string addURL = CheckBox_UseHashtag.IsChecked.GetValueOrDefault() ? "hashtags=惨めな気分になる前にTwitterを辞めろ" : "";
            System.Diagnostics.Process.Start(baseURL + addURL);
        }

        public void OpenNotificationWindow(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/notifications");
        }

        public void OpenDirectMessageWindow(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/messages");
        }
    }
}