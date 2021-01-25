using Microsoft.EntityFrameworkCore;
using MoviesApp.Data.Models;
using System;

namespace MoviesApp.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
        : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Actor> Actors { get; set; }

        public DbSet<MovieActor> MovieActors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieActor>()
                .HasKey(c => new { c.MovieId, c.ActorId });

            // seed data
            modelBuilder.Entity<Movie>()
                .HasData(
                    new Movie
                    {
                        Id = new Guid("788cbe5e-0a81-4f8f-b266-2f0f397c141b"),
                        Title = "Edge of Tomorrow",
                        Year = 2014,
                        Plot = "A soldier fighting aliens gets to relive the same day over and over again, the day restarting every time he dies.",
                    },
                    new Movie
                    {
                        Id = new Guid("90d3ab20-4b17-4373-baa7-d592d848204c"),
                        Title = "House of Cards",
                        Year = 2013,
                        Plot = "A Congressman works with his equally conniving wife to exact revenge on the people who betrayed him.",
                    },
                    new Movie
                    {
                        Id = new Guid("757f42e5-0b8e-472a-b109-9cee3d215952"),
                        Title = "The Undoing",
                        Year = 2020,
                        Plot = "A modern twist to a classical 'whodunnit' tale, when the life of a wealthy New York therapist turns upside down after she and her family get involved with a murder case.",
                    }
                );

            modelBuilder.Entity<Actor>()
                .HasData(
                    new Actor
                    {
                        Id = new Guid("c546153d-23b8-4b97-b838-8e6f3b69e04b"),
                        FirstName = "Tom",
                        LastName = "Cruise"
                    },
                    new Actor
                    {
                        Id = new Guid("4a9e441a-ff0f-426e-8035-6e51738fb599"),
                        FirstName = "Emily",
                        LastName = "Blunt"
                    },
                    new Actor
                    {
                        Id = new Guid("6159bdd6-8384-4c8b-a0f2-550458780724"),
                        FirstName = "Brendan",
                        LastName = "Gleeson"
                    },
                    new Actor
                    {
                        Id = new Guid("63cadfee-ce97-45a2-bfa0-eb1f34b3aca4"),
                        FirstName = "Robin",
                        LastName = "Wright"
                    }, 
                    new Actor
                    {
                        Id = new Guid("9d5cf879-581a-4e95-bf9e-bfd0a6e47180"),
                        FirstName = "Michael",
                        LastName = "Kelly"
                    }, 
                    new Actor
                    {
                        Id = new Guid("814abe05-b21a-46eb-9b63-82e7e7023827"),
                        FirstName = "Kevin",
                        LastName = "Spacey"
                    }, 
                    new Actor
                    {
                        Id = new Guid("352a0267-5852-4461-8888-87be4576b78f"),
                        FirstName = "Justin",
                        LastName = "Doescher"
                    }
                );

            modelBuilder.Entity<MovieActor>()
                .HasData(
                    new MovieActor
                    {
                        MovieId = new Guid("788cbe5e-0a81-4f8f-b266-2f0f397c141b"),
                        ActorId = new Guid("c546153d-23b8-4b97-b838-8e6f3b69e04b")
                    },
                    new MovieActor
                    {
                        MovieId = new Guid("788cbe5e-0a81-4f8f-b266-2f0f397c141b"),
                        ActorId = new Guid("4a9e441a-ff0f-426e-8035-6e51738fb599")
                    },
                    new MovieActor
                    {
                        MovieId = new Guid("788cbe5e-0a81-4f8f-b266-2f0f397c141b"),
                        ActorId = new Guid("6159bdd6-8384-4c8b-a0f2-550458780724")
                    },
                    new MovieActor
                    {
                        MovieId = new Guid("90d3ab20-4b17-4373-baa7-d592d848204c"),
                        ActorId = new Guid("63cadfee-ce97-45a2-bfa0-eb1f34b3aca4")
                    },
                    new MovieActor
                    {
                        MovieId = new Guid("90d3ab20-4b17-4373-baa7-d592d848204c"),
                        ActorId = new Guid("9d5cf879-581a-4e95-bf9e-bfd0a6e47180")
                    },
                    new MovieActor
                    {
                        MovieId = new Guid("90d3ab20-4b17-4373-baa7-d592d848204c"),
                        ActorId = new Guid("814abe05-b21a-46eb-9b63-82e7e7023827")
                    },
                    new MovieActor
                    {
                        MovieId = new Guid("90d3ab20-4b17-4373-baa7-d592d848204c"),
                        ActorId = new Guid("352a0267-5852-4461-8888-87be4576b78f")
                    }
                );
        }
    }
}
