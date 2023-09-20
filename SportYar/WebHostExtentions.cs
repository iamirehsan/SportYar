using Microsoft.EntityFrameworkCore;
using SportYar.Domain.Entites;
using SportYar.Infrastructure.Excels;
using SportYar.Repository.Implimentation;

namespace SportYar
{
    public static class WebHostExtension
    {
        public static WebApplication SeedDatabase(this WebApplication host)
        {

            using (var scope = host.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var databaseContext = serviceProvider.GetRequiredService<ApplicationDbContext>();
                databaseContext.Database.Migrate();
            }

            return host;
        }
        public static WebApplication SeedExcel(this WebApplication host, string baseDirectory)
        {

            using (var scope = host.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var databaseContext = serviceProvider.GetRequiredService<ApplicationDbContext>();
                if (!databaseContext.Set<Province>().Any())
                    databaseContext.SeedDataFromExcel<Province>(baseDirectory + "Province.xlsx", ExcelHeaders.ProvinceHeaders());
                if (!databaseContext.Set<City>().Any())
                    databaseContext.SeedDataFromExcel<City>(baseDirectory + "City.xlsx", ExcelHeaders.CityHeaders());
                if (!databaseContext.Set<Region>().Any())
                    databaseContext.SeedDataFromExcel<Region>(baseDirectory + "Region.xlsx", ExcelHeaders.RegionHeaders());

                databaseContext.SaveChanges();
            }

            return host;
        }
    }



}


