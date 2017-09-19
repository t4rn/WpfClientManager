﻿using System;

namespace WpfMovieManager.Domain.Persons
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public string FullName { get { return $"{ FirstName} {LastName}"; } }
    }
}