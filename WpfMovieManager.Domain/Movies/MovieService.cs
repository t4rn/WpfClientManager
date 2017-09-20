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
            var wesBall = new Person { Id = 1, FirstName = "Wes", LastName = "Ball", BirthDate = new DateTime(1980, 10, 28) };
            var cuesta = new Person { Id = 5, FirstName = "Michael", LastName = "Cuesta", BirthDate = new DateTime(1963, 7, 8) };

            var dylan = new Person { Id = 2, FirstName = "Dylan", LastName = "O'Brien", BirthDate = new DateTime(1991, 8, 26) };
            var aml = new Person { Id = 3, FirstName = "Aml", LastName = "Ameen", BirthDate = new DateTime(1991, 7, 11) };
            var kaya = new Person { Id = 4, FirstName = "Kaya", LastName = "Scodelario", BirthDate = new DateTime(1991, 7, 11) };

            var keaton = new Person { Id = 6, FirstName = "Michael", LastName = "Keaton", BirthDate = new DateTime(1951, 9, 5) };
            var sanaa = new Person { Id = 7, FirstName = "Sanaa", LastName = "Lathan", BirthDate = new DateTime(1971, 9, 19) };
            var kitsch = new Person { Id = 8, FirstName = "Taylor", LastName = "Kitsch", BirthDate = new DateTime(1981, 4, 8) };

            List<Movie> movies = new List<Movie>()
            {
                new Movie() { Id = 1, Title = "The Maze Runner", Gendre = "Thriller", LengthInMinutes = 113, ReleaseDate = new DateTime(2014, 9, 19), IsReleased = true, Director = wesBall, Actors = new List<Person> { dylan, aml, kaya } },
                new Movie() { Id = 2, Title = "The Scorch Trial", Gendre = "Thriller", LengthInMinutes = 132, ReleaseDate = new DateTime(2015, 9, 1), IsReleased = true, Director = wesBall, Actors = new List<Person> { dylan, aml, kaya } },
                new Movie() { Id = 3, Title = "The Maze Runner: The Death Cure", Gendre = "Thriller", LengthInMinutes = 0, ReleaseDate = new DateTime(2018, 1, 11), IsReleased = false, Director = wesBall, Actors = new List<Person> { dylan, aml, kaya } },
                new Movie() { Id = 4, Title = "American Assassin", Gendre = "Action", LengthInMinutes = 111, ReleaseDate = new DateTime(2017, 9, 15), IsReleased = true, Director = cuesta, Actors = new List<Person> { dylan, keaton, sanaa, kitsch } }
            };

            return movies;
        }
    }
}
