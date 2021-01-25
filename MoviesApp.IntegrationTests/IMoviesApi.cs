using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MoviesApp.Dtos;
using Refit;

namespace MoviesApp.IntegrationTests
{
    public interface IMoviesApi
    {
        [Get("/movies/{id}")]
        Task<MovieDto> GetAsync(Guid id);

        [Get("/movies")]
        Task<IEnumerable<MovieDto>> GetAsync();
    }
}
