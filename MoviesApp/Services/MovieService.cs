using MoviesApp.Dtos;
using MoviesApp.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoviesApp.Services
{
    public class MovieService
    {
        private readonly MovieRepository _repository;

        public MovieService(MovieRepository repository)
        {
            _repository = repository;
        }

        public Task<MovieDto> GetByIdAsync(Guid id)
        {
            return _repository.GetByIdAsync(id);
        }

        public Task<IEnumerable<MovieDto>> GetAsync()
        {
            return _repository.GetAsync();
        }
    }
}
