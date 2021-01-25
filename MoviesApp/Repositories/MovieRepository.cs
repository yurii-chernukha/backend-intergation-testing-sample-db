using Microsoft.EntityFrameworkCore;
using MoviesApp.Data;
using MoviesApp.Dtos;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using MoviesApp.Data.Models;

namespace MoviesApp.Repositories
{
    public class MovieRepository
    {
        private readonly MovieContext _context;
        
        public MovieRepository(MovieContext context)
        {
            _context = context;
        }

        public async Task<MovieDto> GetByIdAsync(Guid id)
        {
            var movie = await _context.Movies
                .Include(x => x.MovieActors)
                    .ThenInclude(x => x.Actor)
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            if (movie is null) return null;

            return new MovieDto
            {
                Id = movie.Id,
                Title = movie.Title,
                Year = movie.Year,
                Plot = movie.Plot,
                Actors = movie.MovieActors
                    .Select(ma => ma.Actor)
                    .Select(a => $"{a.FirstName} {a.LastName}")
                    .OrderBy(x => x)
                    .ToArray()
            };
        }

        public async Task<IEnumerable<MovieDto>> GetAsync()
        {
            var movies = await _context
                .Movies
                .Include(x => x.MovieActors)
                    .ThenInclude(x => x.Actor)
                .ToListAsync();

            return movies.Select(x => new MovieDto
            {
                Id = x.Id,
                Title = x.Title,
                Year = x.Year,
                Plot = x.Plot,
                Actors = x.MovieActors
                    .Select(ma => ma.Actor)
                    .Select(a => $"{a.FirstName} {a.LastName}")
                    .OrderBy(x => x)
                    .ToArray()
            });
        }

        public async Task<Guid> AddAsync(MovieDto dto)
        {
            var movie = new Movie
            {
                Id = Guid.NewGuid(),
                Title = dto.Title,
                Year = dto.Year,
                Plot = dto.Plot
            };
            await _context.Movies.AddAsync(movie);

            var actors = dto.Actors.Select(x => new Actor
            {
                Id = Guid.NewGuid(),
                FirstName = x.Split(" ").FirstOrDefault(),
                LastName = x.Split(" ").LastOrDefault()
            }).ToArray();
            await _context.Actors.AddRangeAsync(actors);

            var movieActors = actors.Select(x => new MovieActor
            {
                ActorId = x.Id,
                MovieId = movie.Id
            }).ToArray();
            await _context.MovieActors.AddRangeAsync(movieActors);
            await _context.SaveChangesAsync();

            return movie.Id;
        }
    }
}
