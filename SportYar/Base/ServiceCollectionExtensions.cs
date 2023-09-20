using System.Text.Json.Serialization;
using System.Text.Json;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using SportYar.Base.JsonConverter;
using SportYar.Service.Interfaces;
using SportYar.Service.Implimentation.Implementations;
using SportYar.Repository;
using SportYar.Repository.Implimentation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using SportYar.Domain.Entites;
using SportYar.Messages.DTOs;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SportYar.Domain.Entites;
using SportYar.Messages.DTOs;
using SportYar.Infrastructure.Base;
using Microsoft.Extensions.DependencyInjection;

namespace SportYar.Base
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterJsonConverterAndCommandValidation(this IServiceCollection services)
        {
            services.AddControllers(options =>
            {
            }).AddJsonOptions(opt =>
            {
                opt.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
                opt.JsonSerializerOptions.Converters.Add(new PersianDateTimeConverter());
                opt.JsonSerializerOptions.Converters.Add(new GuidJsonConverter());
                opt.JsonSerializerOptions.Converters.Add(new IntToStringConverter());
                opt.JsonSerializerOptions.Converters.Add(new LongToStringConverter());
                opt.JsonSerializerOptions.Converters.Add(new DictionaryInt32Converter());
                opt.JsonSerializerOptions.Converters.Add(new DictionaryInt64Converter());
                opt.JsonSerializerOptions.WriteIndented = true;

            })/*.AddFluentValidation(f => f.RegisterValidatorsFromAssemblyContaining<SigninCommandValidator>())*/;
        }
      
        public static void RegisterAllServices(this IServiceCollection services)
        {
            services.AddSingleton<IRedisService, RedisService>();
            services.AddScoped<IServiceHolder, ServiceHolder>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            // Create the mapping between Announcement and AnnouncementsDTO
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.CreateMap<Announcement, AnnouncementsDTO>();
            });

            // Register the IMapper instance with the dependency injection container
            services.AddSingleton(mapperConfig.CreateMapper());
        }

        public static void RegisterIdentityService(this IServiceCollection services)
        {
            services.AddIdentity<User, IdentityRole>()
                .AddErrorDescriber<CustomErrorDescriber>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                    .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;


            });

        }

        public static void RegisterAuthentication(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
           .AddJwtBearer(options =>
           {
               options.TokenValidationParameters = new TokenValidationParameters
               {
                   ValidateIssuer = true,
                   ValidateAudience = true,
                   ValidateLifetime = true,
                   ValidateIssuerSigningKey = true,
                   ValidIssuer = configuration["Jwt:Issuer"],
                   ValidAudience = configuration["Jwt:Audience"],
                   IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]))
               };
           });
        }
    }
}
