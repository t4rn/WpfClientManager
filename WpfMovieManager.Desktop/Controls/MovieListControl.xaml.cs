using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfMovieManager.Desktop.Models;
using WpfMovieManager.Domain.Movies;

namespace WpfMovieManager.Desktop.Controls
{
    /// <summary>
    /// Interaction logic for MovieListControl.xaml
    /// </summary>
    public partial class MovieListControl : UserControl
    {
        private readonly MovieService _movieService;
        private readonly MovieListModel _model;

        public MovieListControl()
        {
            InitializeComponent();
            _movieService = new MovieService();
            _model = new MovieListModel();
            DataContext = _model;
        }

        internal void Init(List<Movie> movies)
        {
            _model.Movies = movies;
        }

        private void dgMoviesRow_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGridRow row = sender as DataGridRow;
            Movie movie = row.Item as Movie;

            var movieWindow = new MovieDetails();
            movieWindow.ShowDialog();

        }

    }
}
