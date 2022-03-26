using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedDataSeries
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Series.Any())
                {
                    return;   // DB has been seeded
                }

                context.Series.AddRange(
                    new Series
                    {
                        Title = "When Harry Met Sally",
                        Genre = "Romantic Comedy",
                    },
                    new Series
                    {
                        Title = "The office",
                        Genre = "Commedy",
                    },
                    new Series
                    {
                        Title = "The Bing Bang Theory",
                        Genre = "Commedy"
                    },
                    new Series
                    {
                        Title = "Vampire Diarys",
                        Genre = "Loves"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
