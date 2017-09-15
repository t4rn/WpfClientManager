using System.Windows;
using System.Windows.Controls;
using WpfClientManager.Desktop.Controls;

namespace WpfClientManager.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            mainContent.Content = new TextBlock() { Text = "Welcome to Client Manager!", FontSize = 20, Margin = new Thickness(10) };
        }


        private void miShowClients_Click(object sender, RoutedEventArgs e)
        {
            mainContent.Content = new ClientListControl();
        }

        private void miExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
