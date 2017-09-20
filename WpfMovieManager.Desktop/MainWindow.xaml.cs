using System;
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
            ShowInProgress((sender as MenuItem).Header.ToString());
        }

        private void miContact_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Contact me on FB...", "Contact Me",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void miAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Application made by https://github.com/t4rn", 
                "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void miTvShows_Click(object sender, RoutedEventArgs e)
        {
            ShowInProgress((sender as MenuItem).Header.ToString());
        }

        private void miActors_Click(object sender, RoutedEventArgs e)
        {
            ShowInProgress((sender as MenuItem).Header.ToString());
        }



        private void ShowInProgress(string caption)
        {
            MessageBox.Show("In progress...", caption, MessageBoxButton.OK);
        }
    }
}
