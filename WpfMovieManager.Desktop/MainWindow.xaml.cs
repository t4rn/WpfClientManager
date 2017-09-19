using System.Windows;
using System.Windows.Controls;
using WpfMovieManager.Desktop.Controls;
using WpfMovieManager.Domain.Movies;

namespace WpfMovieManager.Desktop
{
    public partial class MainWindow : Window
    {
        private readonly MovieService _movieService;

        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            mainContent.Content = new TextBlock() { Text = "Welcome to Movie Manager!", FontSize = 20, Margin = new Thickness(10) };
            _movieService = new MovieService();
        }

        private void miExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void miShowMovies_Click(object sender, RoutedEventArgs e)
        {
            var movieListControl = new MovieListControl();
            var movies = _movieService.GetMovies();
            movieListControl.Init(movies);

            mainContent.Content = movieListControl;
        }

        private void miAddMovie_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
