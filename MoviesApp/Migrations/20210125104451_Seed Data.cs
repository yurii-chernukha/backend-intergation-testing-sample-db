using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesApp.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("c546153d-23b8-4b97-b838-8e6f3b69e04b"), "Tom", "Cruise" },
                    { new Guid("4a9e441a-ff0f-426e-8035-6e51738fb599"), "Emily", "Blunt" },
                    { new Guid("6159bdd6-8384-4c8b-a0f2-550458780724"), "Brendan", "Gleeson" },
                    { new Guid("63cadfee-ce97-45a2-bfa0-eb1f34b3aca4"), "Robin", "Wright" },
                    { new Guid("9d5cf879-581a-4e95-bf9e-bfd0a6e47180"), "Michael", "Kelly" },
                    { new Guid("814abe05-b21a-46eb-9b63-82e7e7023827"), "Kevin", "Spacey" },
                    { new Guid("352a0267-5852-4461-8888-87be4576b78f"), "Justin", "Doescher" }
                });

            migrationBuilder.InsertData(
                table: "MovieActors",
                columns: new[] { "MovieId", "ActorId" },
                values: new object[,]
                {
                    { new Guid("788cbe5e-0a81-4f8f-b266-2f0f397c141b"), new Guid("c546153d-23b8-4b97-b838-8e6f3b69e04b") },
                    { new Guid("788cbe5e-0a81-4f8f-b266-2f0f397c141b"), new Guid("4a9e441a-ff0f-426e-8035-6e51738fb599") },
                    { new Guid("788cbe5e-0a81-4f8f-b266-2f0f397c141b"), new Guid("6159bdd6-8384-4c8b-a0f2-550458780724") },
                    { new Guid("90d3ab20-4b17-4373-baa7-d592d848204c"), new Guid("63cadfee-ce97-45a2-bfa0-eb1f34b3aca4") },
                    { new Guid("90d3ab20-4b17-4373-baa7-d592d848204c"), new Guid("9d5cf879-581a-4e95-bf9e-bfd0a6e47180") },
                    { new Guid("90d3ab20-4b17-4373-baa7-d592d848204c"), new Guid("814abe05-b21a-46eb-9b63-82e7e7023827") },
                    { new Guid("90d3ab20-4b17-4373-baa7-d592d848204c"), new Guid("352a0267-5852-4461-8888-87be4576b78f") }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Plot", "Title", "Year" },
                values: new object[,]
                {
                    { new Guid("788cbe5e-0a81-4f8f-b266-2f0f397c141b"), "A soldier fighting aliens gets to relive the same day over and over again, the day restarting every time he dies.", "Edge of Tomorrow", 2014 },
                    { new Guid("90d3ab20-4b17-4373-baa7-d592d848204c"), "A Congressman works with his equally conniving wife to exact revenge on the people who betrayed him.", "House of Cards", 2013 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("352a0267-5852-4461-8888-87be4576b78f"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("4a9e441a-ff0f-426e-8035-6e51738fb599"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("6159bdd6-8384-4c8b-a0f2-550458780724"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("63cadfee-ce97-45a2-bfa0-eb1f34b3aca4"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("814abe05-b21a-46eb-9b63-82e7e7023827"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("9d5cf879-581a-4e95-bf9e-bfd0a6e47180"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("c546153d-23b8-4b97-b838-8e6f3b69e04b"));

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "MovieId", "ActorId" },
                keyValues: new object[] { new Guid("788cbe5e-0a81-4f8f-b266-2f0f397c141b"), new Guid("4a9e441a-ff0f-426e-8035-6e51738fb599") });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "MovieId", "ActorId" },
                keyValues: new object[] { new Guid("788cbe5e-0a81-4f8f-b266-2f0f397c141b"), new Guid("6159bdd6-8384-4c8b-a0f2-550458780724") });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "MovieId", "ActorId" },
                keyValues: new object[] { new Guid("788cbe5e-0a81-4f8f-b266-2f0f397c141b"), new Guid("c546153d-23b8-4b97-b838-8e6f3b69e04b") });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "MovieId", "ActorId" },
                keyValues: new object[] { new Guid("90d3ab20-4b17-4373-baa7-d592d848204c"), new Guid("352a0267-5852-4461-8888-87be4576b78f") });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "MovieId", "ActorId" },
                keyValues: new object[] { new Guid("90d3ab20-4b17-4373-baa7-d592d848204c"), new Guid("63cadfee-ce97-45a2-bfa0-eb1f34b3aca4") });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "MovieId", "ActorId" },
                keyValues: new object[] { new Guid("90d3ab20-4b17-4373-baa7-d592d848204c"), new Guid("814abe05-b21a-46eb-9b63-82e7e7023827") });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "MovieId", "ActorId" },
                keyValues: new object[] { new Guid("90d3ab20-4b17-4373-baa7-d592d848204c"), new Guid("9d5cf879-581a-4e95-bf9e-bfd0a6e47180") });

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("788cbe5e-0a81-4f8f-b266-2f0f397c141b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("90d3ab20-4b17-4373-baa7-d592d848204c"));
        }
    }
}
