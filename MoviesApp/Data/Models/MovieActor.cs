﻿using System;
using System.Collections.Generic;

namespace MoviesApp.Data.Models
{
    public class MovieActor
    {
        public Guid MovieId { get; set; }

        public Guid ActorId { get; set; }

        public virtual Movie Movie { get; set; }

        public virtual Actor Actor { get; set; }
    }
}
