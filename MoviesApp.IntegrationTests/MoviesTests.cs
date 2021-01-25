using Microsoft.AspNetCore.Mvc.Testing;
using MoviesApp.Dtos;
using NUnit.Framework;
using Refit;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MoviesApp.IntegrationTests
{
    public class Tests
    {
        protected static HttpClient Client { get; private set; }

        protected static IMoviesApi MoviesApi { get; set; }

        [OneTimeSetUp]
        public virtual void OneTimeSetUp()
        {
            var webAppFactory = new WebApplicationFactory<Startup>();
            Client = webAppFactory.CreateClient();
            MoviesApi = RestService.For<IMoviesApi>(Client);
        }      

        [Test]
        public async Task TestGetById_Success()
        {
            var id = new Guid("757f42e5-0b8e-472a-b109-9cee3d215952");
            var response = await Client.GetAsync($"movies/{id}");

            response.EnsureSuccessStatusCode();
            var movie = await response.Content.ReadFromJsonAsync<MovieDto>();

            Assert.AreEqual("The Undoing", movie.Title);
            Assert.AreEqual(id, movie.Id);
        }

        [Test]
        public async Task TestGetById_Refit_Success()
        {
            // arrange
            var id = new Guid("757f42e5-0b8e-472a-b109-9cee3d215952");

            // act
            var movie = await MoviesApi.GetAsync(id);

            // assert
            Assert.AreEqual("The Undoing", movie.Title);
            Assert.AreEqual(id, movie.Id);
        }

        [Test]
        public async Task TestGetAll_Success()
        {
            // arrange
            var expectedCount = 3;

            // act
            var movies = await MoviesApi.GetAsync();

            // assert
            Assert.AreEqual(expectedCount, movies.Count());
        }
    }
}