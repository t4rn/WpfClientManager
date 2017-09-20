using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfMovieManager.Desktop.Models;
using WpfMovieManager.Domain.Movies;
using WpfMovieManager.Domain.Persons;

namespace WpfMovieManager.Desktop
{
    public partial class MovieDetails : Window
    {
        private MovieDetailsModel _movieModel;

        public MovieDetails()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            _movieModel = new MovieDetailsModel();
            DataContext = _movieModel;
        }

        internal void Init(Movie movie)
        {
            _movieModel.Movie = movie;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Opacity = 0.4;

            var listBox = sender as ListBox;
            var actor = listBox.SelectedItem as Person;
            MessageBox.Show($"{actor.FullName} born on {actor.BirthDate.ToShortDateString()}.", "Actor info", MessageBoxButton.OK);

            Opacity = 1;
        }
    }
}
