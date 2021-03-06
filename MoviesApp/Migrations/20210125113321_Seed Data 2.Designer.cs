﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviesApp.Data;

namespace MoviesApp.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20210125113321_Seed Data 2")]
    partial class SeedData2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MoviesApp.Data.Models.Actor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c546153d-23b8-4b97-b838-8e6f3b69e04b"),
                            FirstName = "Tom",
                            LastName = "Cruise"
                        },
                        new
                        {
                            Id = new Guid("4a9e441a-ff0f-426e-8035-6e51738fb599"),
                            FirstName = "Emily",
                            LastName = "Blunt"
                        },
                        new
                        {
                            Id = new Guid("6159bdd6-8384-4c8b-a0f2-550458780724"),
                            FirstName = "Brendan",
                            LastName = "Gleeson"
                        },
                        new
                        {
                            Id = new Guid("63cadfee-ce97-45a2-bfa0-eb1f34b3aca4"),
                            FirstName = "Robin",
                            LastName = "Wright"
                        },
                        new
                        {
                            Id = new Guid("9d5cf879-581a-4e95-bf9e-bfd0a6e47180"),
                            FirstName = "Michael",
                            LastName = "Kelly"
                        },
                        new
                        {
                            Id = new Guid("814abe05-b21a-46eb-9b63-82e7e7023827"),
                            FirstName = "Kevin",
                            LastName = "Spacey"
                        },
                        new
                        {
                            Id = new Guid("352a0267-5852-4461-8888-87be4576b78f"),
                            FirstName = "Justin",
                            LastName = "Doescher"
                        });
                });

            modelBuilder.Entity("MoviesApp.Data.Models.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Plot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("788cbe5e-0a81-4f8f-b266-2f0f397c141b"),
                            Plot = "A soldier fighting aliens gets to relive the same day over and over again, the day restarting every time he dies.",
                            Title = "Edge of Tomorrow",
                            Year = 2014
                        },
                        new
                        {
                            Id = new Guid("90d3ab20-4b17-4373-baa7-d592d848204c"),
                            Plot = "A Congressman works with his equally conniving wife to exact revenge on the people who betrayed him.",
                            Title = "House of Cards",
                            Year = 2013
                        },
                        new
                        {
                            Id = new Guid("757f42e5-0b8e-472a-b109-9cee3d215952"),
                            Plot = "A modern twist to a classical 'whodunnit' tale, when the life of a wealthy New York therapist turns upside down after she and her family get involved with a murder case.",
                            Title = "The Undoing",
                            Year = 2020
                        });
                });

            modelBuilder.Entity("MoviesApp.Data.Models.MovieActor", b =>
                {
                    b.Property<Guid>("MovieId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ActorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MovieId", "ActorId");

                    b.HasIndex("ActorId");

                    b.ToTable("MovieActors");

                    b.HasData(
                        new
                        {
                            MovieId = new Guid("788cbe5e-0a81-4f8f-b266-2f0f397c141b"),
                            ActorId = new Guid("c546153d-23b8-4b97-b838-8e6f3b69e04b")
                        },
                        new
                        {
                            MovieId = new Guid("788cbe5e-0a81-4f8f-b266-2f0f397c141b"),
                            ActorId = new Guid("4a9e441a-ff0f-426e-8035-6e51738fb599")
                        },
                        new
                        {
                            MovieId = new Guid("788cbe5e-0a81-4f8f-b266-2f0f397c141b"),
                            ActorId = new Guid("6159bdd6-8384-4c8b-a0f2-550458780724")
                        },
                        new
                        {
                            MovieId = new Guid("90d3ab20-4b17-4373-baa7-d592d848204c"),
                            ActorId = new Guid("63cadfee-ce97-45a2-bfa0-eb1f34b3aca4")
                        },
                        new
                        {
                            MovieId = new Guid("90d3ab20-4b17-4373-baa7-d592d848204c"),
                            ActorId = new Guid("9d5cf879-581a-4e95-bf9e-bfd0a6e47180")
                        },
                        new
                        {
                            MovieId = new Guid("90d3ab20-4b17-4373-baa7-d592d848204c"),
                            ActorId = new Guid("814abe05-b21a-46eb-9b63-82e7e7023827")
                        },
                        new
                        {
                            MovieId = new Guid("90d3ab20-4b17-4373-baa7-d592d848204c"),
                            ActorId = new Guid("352a0267-5852-4461-8888-87be4576b78f")
                        });
                });

            modelBuilder.Entity("MoviesApp.Data.Models.MovieActor", b =>
                {
                    b.HasOne("MoviesApp.Data.Models.Actor", "Actor")
                        .WithMany("MovieActors")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MoviesApp.Data.Models.Movie", "Movie")
                        .WithMany("MovieActors")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
