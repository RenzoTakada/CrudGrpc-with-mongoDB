
using CRUDGrpcService.Adapters.MongoDB.Connection;
using CRUDGrpcService.Adapters.MongoDB.Repository;

namespace CRUDGrpcService.Adapters.MongoDB.Extensions
{
    public static class MongoExtensions
    {
        public static IServiceCollection AddMongoDB(this IServiceCollection services)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json").Build();

            services.AddSingleton(x => configuration.GetSection("MongoDBConnection").Get<ConnectionMongo>());
            services.AddScoped<IMongoRepository, MongoRepository>();
            return services;
        }
    }
}
