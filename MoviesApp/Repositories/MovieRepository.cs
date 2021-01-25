using Microsoft.EntityFrameworkCore;
using MoviesApp.Data;
using MoviesApp.Dtos;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

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
                    .ToArray()
            });
        }
    }
}
