public class ReplaceWordsMiddleWare
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ReplaceWordsMiddleWare> _logger;

    public ReplaceWordsMiddleWare(RequestDelegate next, ILogger<ReplaceWordsMiddleWare> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        if ((context.Request.Method == "POST" || context.Request.Method == "PUT") && context.Request.ContentType == "application/json")
        {
            var originalBodyStream = context.Response.Body;

            using (var responseBody = new System.IO.MemoryStream())
            {
                context.Response.Body = responseBody;

                await _next(context);

                context.Response.Body.Seek(0, System.IO.SeekOrigin.Begin);

                string body = new System.IO.StreamReader(context.Response.Body).ReadToEnd();

                if (!string.IsNullOrEmpty(body))
                {
                    body = body.Replace("ك", "ک");
                    body = body.Replace("ي", "ی");
                    byte[] data = System.Text.Encoding.UTF8.GetBytes(body);
                    context.Response.Body.Seek(0, System.IO.SeekOrigin.Begin);
                    context.Response.Body.Write(data, 0, data.Length);
                }

                context.Response.Body = originalBodyStream;
            }
        }
        else
        {
            await _next(context);
        }
    }
}
