using System;
using System.Collections.Generic;

namespace MoviesApp.Data.Models
{
    public class Actor
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<MovieActor> MovieActors { get; set; }
    }
}
