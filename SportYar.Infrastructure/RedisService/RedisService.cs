using Microsoft.Extensions.Configuration;
using StackExchange.Redis;

public class RedisService : IRedisService
{
    private readonly ConnectionMultiplexer _redis;

    public RedisService(IConfiguration configuration)
    {
        string connectionString = configuration.GetValue<string>("Redis");
        ConfigurationOptions options = ConfigurationOptions.Parse(connectionString);
        _redis = ConnectionMultiplexer.Connect(options);
    }

    public IDatabase GetDatabase()
    {
        return _redis.GetDatabase();
    }
}
