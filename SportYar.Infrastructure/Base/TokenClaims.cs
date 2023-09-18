namespace SportYar.Infrastructure.Base
{
    public sealed class TokenClaims 
    {
        private TokenClaims(string userId)
        {
            UserId = userId;
        }

        private static TokenClaims _instance;
        public string UserId { get; private set; }
 
        public static string GetTokenUserId()
        {
            return _instance.UserId;
        }
        public static TokenClaims CreateInstance(string userId)
        {
            if(_instance is null)
            {
                _instance = new TokenClaims(userId);
                return _instance;
            }
            return _instance;
        }
        public static void Dispose()
        {
            _instance = null;
        }
    }
}
