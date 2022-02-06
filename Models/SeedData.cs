#define Second
#if First
#region FirstVersion
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
#endregion
#endif
#if Second
#region SecondVersion
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "El ultimo tour del mundo",
                        ReleaseDate = DateTime.Parse("02/12/2021"),
                        Genre = "Regueton",
                        Rating = "R",
                        Price = 199
                    },

                    new Movie
                    {
                        Title = "La hora de dormir ",
                        ReleaseDate = DateTime.Parse("13-03-2022"),
                        Genre = "Country",
                        Rating = "PG",
                        Price = 189
                    },

                    new Movie
                    {
                        Title = "Little sky",
                        ReleaseDate = DateTime.Parse("23-02-2022"),
                        Genre = "Alternative",
                        Rating = "PG",
                        Price = 250
                    },

                    new Movie
                    {
                        Title = "LATAM",
                        ReleaseDate = DateTime.Parse("15-04.2022"),
                        Genre = "pop",
                        Rating = "G",
                        Price = 130
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
#endregion
#endif
