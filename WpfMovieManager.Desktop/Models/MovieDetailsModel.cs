using System.ComponentModel;
using System.Runtime.CompilerServices;
using WpfMovieManager.Domain.Movies;

namespace WpfMovieManager.Desktop.Models
{
    public class MovieDetailsModel : INotifyPropertyChanged
    {
        public Movie Movie { get; set; }

        public string Actors
        {
            get
            {
                string result = null;
                Movie.Actors.ForEach(x => { result = $"{result} \r\n {x.FullName}"; });
                return result.Trim();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string caller = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }
    }
}
