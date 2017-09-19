using System;
using System.Collections.Generic;
using WpfMovieManager.Domain.Persons;

namespace WpfMovieManager.Domain.Movies
{
    public class Movie
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Gendre { get; set; }
        public int LengthInMinutes { get; set; }
        public Person Director { get; set; }
        public List<Person> Actors { get; set; }
        public bool IsReleased { get; set; }
    }
}
