using System.Windows;
using System.Windows.Controls;
using WpfMovieManager.Desktop.Controls;

namespace WpfMovieManager.Desktop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            mainContent.Content = new TextBlock() { Text = "Welcome to Movie Manager!", FontSize = 20, Margin = new Thickness(10) };
        }

        private void miExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void miShowMovies_Click(object sender, RoutedEventArgs e)
        {
            mainContent.Content = new MovieListControl();
        }

        private void miAddMovie_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
