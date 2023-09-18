using StackExchange.Redis;

public interface IRedisService
{
    IDatabase GetDatabase();
}