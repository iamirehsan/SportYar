using System.Text.Json.Serialization;
using System.Text.Json;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using SportYar.Base.JsonConverter;
using SportYar.Service.Interfaces;
using SportYar.Service.Implimentation.Implementations;
using SportYar.Repository;
using SportYar.Repository.Implimentation;

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

            }).AddFluentValidation(f => f.RegisterValidatorsFromAssemblyContaining<SigninCommandValidator>());
        }
      
        public static void RegisterAllServices(this IServiceCollection services)
        {
            services.AddScoped<IServiceHolder, ServiceHolder>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }


    }
}
