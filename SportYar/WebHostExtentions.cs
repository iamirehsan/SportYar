using Microsoft.EntityFrameworkCore;
using SportYar.Repository.Implimentation;

namespace SportYar
{
    public static class WebHostExtension
    {
        public static WebApplication Seed(this WebApplication host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;

                var databaseContext = serviceProvider.GetRequiredService<ApplicationDbContext>();


                databaseContext.Database.Migrate();


            }

            return host;
        }
    }





}
