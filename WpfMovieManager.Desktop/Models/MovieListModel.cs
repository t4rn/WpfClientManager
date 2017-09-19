using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WpfMovieManager.Domain.Movies;

namespace WpfMovieManager.Desktop.Models
{
    public class MovieListModel : INotifyPropertyChanged
    {
        private List<Movie> movies;
        public List<Movie> Movies
        {
            get { return movies; }
            set { movies = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string caller = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }
    }
}
