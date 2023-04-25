
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using SportYar.Base;
using SportYar.Repository.Implimentation;

namespace SportYar
{
    public class Program
    {
        public static void Main(string[] args)
        {
         
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            ExcelPackage.LicenseContext = LicenseContext.Commercial;

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection")));
            builder.Services.RegisterJsonConverterAndCommandValidation();
            builder.Services.RegisterAllServices();


            var app = builder.Build().Seed(builder.Configuration.GetValue<string>("ExcelRoot"));

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(); 
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}