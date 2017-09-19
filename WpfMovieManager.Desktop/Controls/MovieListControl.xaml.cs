using System.Windows;
using System.Windows.Controls;
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

        private void btnGetMovies_Click(object sender, RoutedEventArgs e)
        {
            _model.Movies = _movieService.GetMovies();
        }
    }
}
