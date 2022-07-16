using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace eTikects.Data
{
    public class AppDbInitilaizer
    {
        public static void Seed(IApplicationBuilder applicationBulder)
        {
            using(var serviceScope = applicationBulder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();
                //cinema
                if(!context.Cinemas.Any())
                {

                }
                //Actors
                if (!context.Actors.Any())
                {

                }
                //Produces
                if (!context.Producers.Any())
                {

                }
                //Movies
                if (!context.Movies.Any())
                {

                }
                //ActorsMovies
                if (!context.Actors_Movies.Any())
                {

                }
            }
        }
    }
}
