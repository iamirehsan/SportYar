using Microsoft.EntityFrameworkCore;
using SportYar.Domain.Entites;
using SportYar.Infrastructure;
using SportYar.Repository.Implimentation;

namespace SportYar
{
    public static class WebHostExtension
    {
        public static  WebApplication Seed(this WebApplication host)
        {
            var baseDirectory = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf("bin\\"));
            using (var scope = host.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var databaseContext = serviceProvider.GetRequiredService<ApplicationDbContext>();
                databaseContext.Database.Migrate();
                databaseContext.SeedDataFromExcel<City>(baseDirectory + "SportYar.Infrastructure\\Excels\\Cities.xlsx", ExcelHeaders.CityHeaders());
                databaseContext.SeedDataFromExcel<Province>(baseDirectory + "SportYar.Infrastructure\\Excels\\Provinces.xlsx", ExcelHeaders.CityHeaders());
                databaseContext.SeedDataFromExcel<Region>(baseDirectory + "SportYar.Infrastructure\\Excels\\Regions.xlsx", ExcelHeaders.CityHeaders());
            }

            return host;
        }
    }

}
