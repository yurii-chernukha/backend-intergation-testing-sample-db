using System;

namespace MoviesApp.Dtos
{
    public class MovieDto
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public string[] Actors { get; set; }

        public string Plot { get; set; }
    }
}
