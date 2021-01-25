using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using MoviesApp.Dtos;
using NUnit.Framework;
using Refit;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.IntegrationTests
{
    public class Tests
    {
        protected static IMoviesApi MoviesApi { get; set; }

        [OneTimeSetUp]
        public virtual void OneTimeSetUp()
        {
            var webAppFactory = new WebApplicationFactory<Startup>()
                .WithWebHostBuilder(hostBuilder =>
                    hostBuilder.UseEnvironment("IntegrationTests"));
            var client = webAppFactory.CreateClient();
            MoviesApi = RestService.For<IMoviesApi>(client);
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
            var expectedCount = 6;

            // act
            var movies = await MoviesApi.GetAsync();

            // assert
            Assert.AreEqual(expectedCount, movies.Count());
        }

        [Test]
        public async Task TestAdd_Success()
        {
            // arrange
            var movieToAdd = new MovieDto
            {
                Title = "My random title",
                Year = 1000,
                Plot = "Info goes here",
                Actors = new string[] { "Jack Doe", "Harry O'Niel", "Tania Skaley", "Alan Bride" }
            };

            // act
            var id = await MoviesApi.AddAsync(movieToAdd);
            var movieRetrieved = await MoviesApi.GetAsync(id);

            // assert
            movieRetrieved.Should().BeEquivalentTo(movieToAdd, options =>
                options.Excluding(o => o.Id));
            movieRetrieved.Actors.Should().BeInAscendingOrder();
        }
    }
}