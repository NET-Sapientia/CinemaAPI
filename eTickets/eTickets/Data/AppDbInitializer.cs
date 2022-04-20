using eTickets.Models;  //new Cinema(){...}....
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;   //List<Cinema>()
using System.Linq;

//Itt talalhatok a kepek, a szovegek stb...

//Default-kent megadja a kepeket, a szoveget...

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",   //Cinema One Brasso
                            Logo = "https://www.fest.ro/files/places/11/image_1199_1_large.jpg",
                            Description = "Cinema One Brașov este destinația ideală pentru cinefilii care doresc să își petreacă timpul liber într-o atmosferă deosebită. Aici pot fi vizionate cele mai noi filme, într-un spațiu creat special pentru pasionații de film și spectacol."
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",   //Cinema City Maros
                            Logo = "https://www.cinemacity.ro/static/dam/jcr:c57b232e-7e50-49df-aa3f-1faf21bdc841/terms_and_conditions.jpg",
                            Description = "Cinema City este cel mai mare operator de cinema din România şi face parte din Cineworld Group, al doilea mare lanţ de cinema din Europa."
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",   //Cineplexx Maros
                            Logo = "https://s3proxygw.cineplexx.at/vapc-ro-pimcore/assets/_default_upload_bucket/89339725_136908084528296_2319869874186223616_n_1.jpg",
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
                            Bio = "This is the Bio of Dylan O'Brien",
                            ProfilePictureURL = "https://ichef.bbci.co.uk/news/976/cpsprodpb/A033/production/_89111014_dylan2.jpg",

                        },
                        new Actor()
                        {
                            FullName = "Kim Min-gue",   //Kim Min-gue
                            Bio = "This is the Bio of Kim Min-gue",
                            ProfilePictureURL = "https://www.themoviedb.org/t/p/w500/w4NojHsHdLGf7LLoT6jfyDcE8K6.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Joseph Gordon-Levitt",  //Joseph Gordon-Levitt
                            Bio = "This is the Bio of Joseph Gordon-Levitt",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BMTY3NTk0NDI3Ml5BMl5BanBnXkFtZTgwNDA3NjY0MjE@._V1_.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Selena Gomez",  //Selena Gomez
                            Bio = "This is the Bio of Selena Gomez",
                            ProfilePictureURL = "https://pbs.twimg.com/media/DvNGwVWWoAA8Psi.jpg"
                },
                         new Actor()
                        {
                            FullName = "Thomas Brodie-Sangster",  //Joseph Gordon-Levitt
                            Bio = "This is the Bio of Thomas Brodie-Sangster",
                            ProfilePictureURL = "https://www.thewikifeed.com/wp-content/uploads/2021/06/thomas-brodie-sangster-1.jpg"
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
                            FullName = "Bong Joon-ho",  //Parasites
                            Bio = "Bio",
                            ProfilePictureURL = "https://www.indiewire.com/wp-content/uploads/2021/05/bong-joon-ho.png"
                        },
                        new Producer()
                        {
                            FullName = "Wes Ball",  //The Maze Runner
                            Bio = "Bio",
                            ProfilePictureURL = "https://c8d8q6i8.stackpathcdn.com/wp-content/uploads/2020/02/Wes-Ball-Contact-Information.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Robert Zemeckis",  //The Walk
                            Bio = "Bio",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/d/d7/Robert_Zemeckis_%22The_Walk%22_at_Opening_Ceremony_of_the_28th_Tokyo_International_Film_Festival_%2821835891403%29_%28cropped%29.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Alice Dewey",  //Hotel Transyilvania 4
                            Bio = "Bio",
                            ProfilePictureURL = "https://eurweb.com/wp-content/uploads/2022/01/Alice-Goldstone.jpg"
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
                            Name = "The Maze Runner",
                            Description = "This is the Maze Runner description",
                            Price = 29.50,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMjUyNTA3MTAyM15BMl5BanBnXkFtZTgwOTEyMTkyMjE@._V1_FMjpg_UX1000_.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.science_fiction  //science fiction
                        },
                        new Movie()
                        {
                            Name = "Parasites",
                            Description = "description",
                            Price = 39.50,
                            ImageURL = "https://images.moviesanywhere.com/76cd3a853ffede1f5983f090839cacc8/8ca75d25-0bc2-4584-9d4c-3a381232c870.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 2,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "The Walk",
                            Description = "description",
                            Price = 39.50,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BNTY4MzA4Mzc5Nl5BMl5BanBnXkFtZTgwNDIzMzk5NjE@._V1_.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Hotel Transylvania 4",
                            Description = "This is Hotel Transylvania 4 movie description",
                            Price = 39.50,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BYmRhNzZlOTMtOTczMi00NzZhLWFiZWItMTc1NjI3NTY5NTIzXkEyXkFqcGdeQXVyMTA3MDk2NDg2._V1_.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 3,
                            ProducerId = 4,
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
                            ActorId = 5,
                            MovieId = 1
                        },
                        /**/

                        

                         new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 2
                        },
                         

                          /**/
                           

                                new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 3
                        },
                                /**/
                        
                         
                           new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                    });
                    context.SaveChanges();
                }

            }
        }


    }
}
