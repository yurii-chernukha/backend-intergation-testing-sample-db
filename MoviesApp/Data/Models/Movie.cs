using System;
using System.Collections.Generic;

namespace MoviesApp.Data.Models
{
    public class Movie
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public string Plot { get; set; }

        public virtual ICollection<MovieActor> MovieActors { get; set; }
    }
}
