using System;
using System.Collections.Generic;
using WpfMovieManager.Domain.Persons;

namespace WpfMovieManager.Domain.Movies
{
    public class MovieService
    {
        public MovieService()
        {

        }

        public List<Movie> GetMovies()
        {
            var wesBall = new Person { Id=1, FirstName = "Wes", LastName = "Ball", BirthDate = new DateTime(1980, 10, 28) };

            List<Movie> movies = new List<Movie>()
            {
                new Movie() { Id = 1, Title = "The Maze Runner", Gendre = "Thriller", LengthInMinutes = 113, ReleaseDate = new DateTime(2014, 9, 19), IsReleased = true, Director = wesBall },
                new Movie() { Id = 2, Title = "The Scorch Trial", Gendre = "Thriller", LengthInMinutes = 132, ReleaseDate = new DateTime(2015, 9, 1), IsReleased = true, Director = wesBall },
                new Movie() { Id = 3, Title = "The Maze Runner: The Death Cure", Gendre = "Thriller", LengthInMinutes = 0, ReleaseDate = new DateTime(2018, 1, 11), IsReleased = false, Director = wesBall }
            };

            return movies;
        }
    }
}
