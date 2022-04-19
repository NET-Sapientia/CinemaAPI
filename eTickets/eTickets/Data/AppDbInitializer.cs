using eTickets.Models;  //new Cinema(){...}....
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;   //List<Cinema>()
using System.Linq;

//Itt talalhatok a kepek, a szovegek stb...

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService < AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",   //Cinema One Brasso
                            Logo = "images/cinema_one.jpg",
                            Description = "Cinema One Brașov este destinația ideală pentru cinefilii care doresc să își petreacă timpul liber într-o atmosferă deosebită. Aici pot fi vizionate cele mai noi filme, într-un spațiu creat special pentru pasionații de film și spectacol."
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",   //Cinema City Maros
                            Logo = "images/cinema_city.jpg",
                            Description = "Cinema City este cel mai mare operator de cinema din România şi face parte din Cineworld Group, al doilea mare lanţ de cinema din Europa."
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",   //Cineplexx Maros
                            Logo = "images/cineplexx.png",
                            Description = "Cineplexx Targu Mures este cel mai nou multiplex din oras, dotat cu cele mai avansate tehnologii de imagine si sunet din lume: Dolby Atmos, RealD Silver Screen si proiector cu laser."
                        },
                    });

                    context.SaveChanges();

                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Dylan O'Brien",   //Dylan O'Brien
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "images/Dylan_OBrien.jpg",

                        },
                        new Actor()
                        {
                            FullName = "Thomas Brodie-Sangster",  //Thomas Brodie-Sangster
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "images/Thomas_Brodie_Sangster.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Kim Min-gue",   //Kim Min-gue
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "images/Kim_Min_gue.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Joseph Gordon-Levitt",  //Joseph Gordon-Levitt
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "images/Joseph_Gordon_Levitt.jpg"
                        },
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",  //off Maze Runner
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Producer()
                        {
                            FullName = "Producer 2",  //Parasites
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",  //Queens Gambit
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",  //The Walk
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "The Queens Gambit",
                            Description = "description",
                            Price = 39.50,
                            ImageURL = "images/",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "The Maze Runner",
                            Description = "This is the Maze Runner description",
                            Price = 29.50,
                            ImageURL = "images/",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action  //science fiction
                        },
                        new Movie()
                        {
                            Name = "Parasites",
                            Description = "description",
                            Price = 39.50,
                            ImageURL = "images/Parasites.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Hotel Transylvania 4",
                            Description = "This is Hotel Transylvania 4 movie description",
                            Price = 39.50,
                            ImageURL = "images/Hotel_Transylvania_4.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Cartoon
                        },
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();
                }

            }
        }


    }
}
